﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class UserDAC : ConnectionAccess
    {
        public List<UserGroupManagerVO> UserGroupManagerForm()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "select UserGroup_Code,UserGroup_Name,Use_YN from UserGroup_Master";
                cmd.CommandType = CommandType.Text;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<UserGroupManagerVO> list = Helper.DataReaderMapToList<UserGroupManagerVO>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

        public void InsUserGroupManagerForm(UserGroupManagerVO user)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"insert into UserGroup_Master (UserGroup_Code,UserGroup_Name,Admin,Use_YN,Ins_Date)
                                    values (@UserGroup_Code,@UserGroup_Name,'N',@Use_YN,GETDATE())";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@UserGroup_Code", user.UserGroup_Code);
                cmd.Parameters.AddWithValue("@UserGroup_Name", user.UserGroup_Name);
                cmd.Parameters.AddWithValue("@Use_YN", user.Use_YN);

                cmd.Connection.Open();
                cmd.ExecuteScalar();
                cmd.Connection.Close();
            }
        }
        public void UpdateUserGroupManagerForm(UserGroupManagerVO user)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"update UserGroup_Master
                                    set UserGroup_Name = @UserGroup_Name,
                                    	Use_YN = @Use_YN
                                    where UserGroup_Code = @UserGroup_Code";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@UserGroup_Code", user.UserGroup_Code);
                cmd.Parameters.AddWithValue("@UserGroup_Name", user.UserGroup_Name);
                cmd.Parameters.AddWithValue("@Use_YN", user.Use_YN);

                cmd.Connection.Open();
                cmd.ExecuteScalar();
                cmd.Connection.Close();
            }
        }
        public List<UserGroupPowerSettingVO> GetAllUserGroupPowerSettingForm()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"select u.UserGroup_Name,s.Screen_Code,s.Pre_Type
                                    from ScreenItem_Authority s inner join UserGroup_Master u on s.UserGroup_Code = u.UserGroup_Code ";
                cmd.CommandType = CommandType.Text;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<UserGroupPowerSettingVO> list = Helper.DataReaderMapToList<UserGroupPowerSettingVO>(reader);
                cmd.Connection.Close();
                return list;
            }
        }
        public List<UserManagerVO> GetAllUserManager()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"select u.User_Name,u.User_ID,um.UserGroup_Code,um.UserGroup_Name,um.Use_YN,u.Pw_Reset_Count,u.Default_Process_Code,u.User_Type
                                    from User_Master u inner join UserGroup_Mapping m on m.User_ID = u.User_ID
                                    inner join UserGroup_Master um on um.UserGroup_Code = m.UserGroup_Code";
                cmd.CommandType = CommandType.Text;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<UserManagerVO> list = Helper.DataReaderMapToList<UserManagerVO>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

        public List<ProCodeVo> GetList()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "select Process_name from Process_Master ";
                cmd.CommandType = CommandType.Text;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<ProCodeVo> list = Helper.DataReaderMapToList<ProCodeVo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }


        public void InsUserManager(UserManagerVO user)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "InsUserManager";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@User_ID", user.User_ID);
                cmd.Parameters.AddWithValue("@User_Name", user.User_Name);
                cmd.Parameters.AddWithValue("@User_Type", user.User_Type);
                cmd.Parameters.AddWithValue("@Default_Process_Code", user.Default_Process_Code);
                cmd.Parameters.AddWithValue("@Use_YN", user.Use_YN);
                cmd.Parameters.AddWithValue("@UserGroup_Name", user.UserGroup_Name);
                cmd.Parameters.AddWithValue("@UserGroup_Code", user.UserGroup_Code);
                
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }
        public void UpdateUserManager(UserManagerVO user)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "UpdateUserManager";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@User_ID", user.User_ID);
                cmd.Parameters.AddWithValue("@UserGroup_Code", user.UserGroup_Code);
                cmd.Parameters.AddWithValue("@UserGroup_Name", user.UserGroup_Name);
                cmd.Parameters.AddWithValue("@User_Type", user.User_Type);
                cmd.Parameters.AddWithValue("@Default_Process_Code", user.Default_Process_Code);
                cmd.Parameters.AddWithValue("@Use_YN", user.Use_YN);


                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }
        public List<UserPlanVo> GetUserPlan(int userID)
        {
            List<UserPlanVo> list;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"select User_ID, Seq, CONVERT(CHAR(10),Plan_Date,23) Plan_Date, Title, Notice from User_PlanNotice where User_ID = @User_ID
                                                order by 3";
               
                cmd.Parameters.AddWithValue("@User_ID", userID);
                cmd.Connection.Open();
                list = Helper.DataReaderMapToList<UserPlanVo>(cmd.ExecuteReader());
                cmd.Connection.Close();
            }
            return list;
        }

    }
}
