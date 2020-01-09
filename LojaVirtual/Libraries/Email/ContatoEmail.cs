using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Email
{
    public static class ContatoEmail
    {
        public static void EnviarContatoPorEmail(Contato contato)
        {
            try
            {

                StringBuilder sb = new StringBuilder();
                sb.Append("<h2>Contato - LojaVirtual</h2>");
                sb.Append(string.Format("<b>Nome: </b> {0} <br/>", contato.Nome));
                sb.Append(string.Format("<b>E-mail: </b> {0} <br/>", contato.Email));
                sb.Append(string.Format("<b>Texto: </b> {0} <br/>", contato.Texto));
                sb.Append(" <br/> E-mail envialdo automaticamente do site LojaVirtual");


                /*
                 * MailMessage -> Message Constructor
                 */

                MailMessage mensagem = new MailMessage();
                mensagem.From = new MailAddress("nicholas.delatorre@gmail.com");
                mensagem.To.Add("nicholas.delatorre@gmail.com");
                mensagem.Subject = "Contato - LojaVirtual - E-mail: " + contato.Email;
                mensagem.Body = sb.ToString();
                mensagem.IsBodyHtml = true;


                /*
                 * SMTP -> Email Sender Server
                 */

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential("nicholas.delatorre@gmail.com", "ra006510");
                    smtp.EnableSsl = true;


                    smtp.Send(mensagem);
                }

            }
            catch (SmtpException ex)
            {

                throw ex;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
