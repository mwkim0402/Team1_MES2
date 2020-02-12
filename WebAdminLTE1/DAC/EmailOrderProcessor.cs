using WebApplication0106.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;

namespace WebApplication0106
{
    public class EmailSettings
    {
        public string MailToAddress = "a01031352651@gmail.com";//자기의 메일
        public string MailFromAddress = "danawa@gudi.com";
        public bool UseSsl = true;
        public string Username = "a01031352651@gmail.com";//자기의Gmail
        public string Password = "wldms111";//자기의 Gmail비밀번호
        public string ServerName = "smtp.gmail.com";
        public int ServerPort = 587;
    }

    public class EmailOrderProcessor
    {
        private EmailSettings emailSettings;

        public EmailOrderProcessor(EmailSettings settings)
        {
            emailSettings = settings;
        }

        
    }
}