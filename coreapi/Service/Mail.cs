using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace coreapi.Service
{
	public class Mail : IMail
	{
		public void Sendmail(string param)
		{
			try
			{
				MailMessage mail = new MailMessage();
				SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

				mail.From = new MailAddress("your mail");
				mail.To.Add("sender's mail");
				mail.Subject = "Scoped";
				mail.Body = param;

				SmtpServer.Port = 587;
				SmtpServer.Credentials = new System.Net.NetworkCredential("username", "password");
				SmtpServer.EnableSsl = true;

				SmtpServer.Send(mail);
			}
			catch(Exception ex )
			{

			}
			
		}
	}
}
