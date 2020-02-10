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

        public void ProcessOrder(Cart cart, ShipInfo shipInfo)
        {
            using (var smtpClient = new SmtpClient())
            {

                smtpClient.EnableSsl = emailSettings.UseSsl;
                smtpClient.Host = emailSettings.ServerName;
                smtpClient.Port = emailSettings.ServerPort;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials
                    = new NetworkCredential(emailSettings.Username,
                          emailSettings.Password);

                StringBuilder body = new StringBuilder()
                    .AppendLine("주문처리가 완료되었습니다.")
                    .AppendLine("---")
                    .AppendLine("Items:");

                foreach (var line in cart.Lines)
                {
                    var subtotal = line.product.Price * line.Qty;
                    body.AppendFormat("         - {0} x {1} (subtotal: {2:c})", 
                                      line.product.Name, line.Qty,
                                      subtotal);
                    body.AppendLine();
                }
                body.AppendLine();

                body.AppendFormat("Total order value: {0:c}", cart.ComputeTotalValue())
                    .AppendLine()
                    .AppendLine("---")
                    .AppendLine("배송지정보:")
                    .AppendLine(shipInfo.Name)
                    .AppendLine(shipInfo.Addr1)
                    .AppendLine(shipInfo.Addr2 ?? "")
                    .AppendLine(shipInfo.Message ?? "")
                    .AppendLine("---");

                MailMessage mailMessage = new MailMessage(
                                       emailSettings.MailFromAddress,   // From
                                       emailSettings.MailToAddress,     // To
                                       "신규 주문 완료!",                // Subject
                                       body.ToString());                // Body

                smtpClient.Send(mailMessage);
            }
        }
    }
}