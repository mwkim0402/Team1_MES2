﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using MES_DTO;
using Newtonsoft.Json;

// Service 예제
/* 윈폼에서 불러오는 예제
     private async void button1_Click(object sender, EventArgs e)
        {
            List<UserVO> list = null;
            UserService service = new UserService();
            dataGridView1.DataSource = await service.GetAsync("GetAllUser",list);
        }
 */
namespace AdminForm
{
    public class UserService
    {
        HttpClient client = new HttpClient();
        public UserService()
        {
            string url = $"{ConfigurationManager.AppSettings["ApiAddress"]}api/User/";
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public async Task<T> GetListAsync<T>(string path, T t)
        {
            T obj = default(T);
            try
            {
                using (HttpResponseMessage response = await client.GetAsync(path))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        obj = JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
                        return obj;
                    }
                    return obj;
                }
            }
            catch (Exception)
            {

                return obj;
            }
        }

        // Value 형식 하나만 받는 메서드
        public async Task<T> GetAsync<T>(string path, T t)
        {
            T obj = default(T);
            try
            {
                using (HttpResponseMessage response = await client.GetAsync(path))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        Message<T> msg = JsonConvert.DeserializeObject<Message<T>>(await response.Content.ReadAsStringAsync());
                        obj = msg.Data;

                        return obj;
                    }
                    return obj;
                }
            }
            catch (Exception)
            {
                return obj;
            }
        }
        public async Task<Message> GetAsync(string path)
        {
            Message obj = null;
            try
            {
                using (HttpResponseMessage response = await client.GetAsync(path))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        obj = JsonConvert.DeserializeObject<Message>(await response.Content.ReadAsStringAsync());
                        return obj;
                    }
                    return obj;
                }
            }
            catch (Exception)
            {
                return obj;
            }
        }

        // 등록
        public async Task<Message<T>> PostAsync<T>(string path, T t)
        {
            Message<T> obj = null;
            try
            {
                using (HttpResponseMessage response = await client.PostAsJsonAsync(path, t))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        obj = JsonConvert.DeserializeObject<Message<T>>(await response.Content.ReadAsStringAsync());
                        return obj;
                    }
                    return obj;
                }
            }
            catch (Exception)
            {
                return obj;
            }
        }
    }
}
