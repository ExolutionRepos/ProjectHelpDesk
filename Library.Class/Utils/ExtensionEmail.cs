using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;

namespace Library.Class.Utils
{
    public static class ExtensionEmail
    {
        //public static string EnviaMensagemEmail(string Destinatario, string Remetente, string Assunto, string enviaMensagem)
        //{
        //    try
        //    {
        //        // valida o email
        //        bool bValidaEmail = ValidaEnderecoEmail(Destinatario);

        //        // Se o email não é validao retorna uma mensagem
        //        if (bValidaEmail == false)
        //            return "Email do destinatário inválido: " + Destinatario;

        //        // cria uma mensagem
        //        MailMessage mensagemEmail = new MailMessage(Remetente, Destinatario, Assunto, enviaMensagem);

        //        SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
        //        client.EnableSsl = true;
        //        NetworkCredential cred = new NetworkCredential("rogerio.guimaraesjr@gmail.com", "22011998");
        //        client.Credentials = cred;

        //        // inclui as credenciais
        //        client.UseDefaultCredentials = true;

        //        // envia a mensagem
        //        client.Send(mensagemEmail);

        //        return "Mensagem enviada para  " + Destinatario + " às " + DateTime.Now.ToString() + ".";
        //    }
        //    catch (Exception ex)
        //    {
        //        string erro = ex.InnerException.ToString();
        //        return ex.Message.ToString() + erro;
        //    }
        //}

        public static bool ValidaEnderecoEmail(string enderecoEmail)
        {
            try
            {
                //define a expressão regulara para validar o email
                string texto_Validar = enderecoEmail;
                Regex expressaoRegex = new Regex(@"\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}");

                // testa o email com a expressão
                if (expressaoRegex.IsMatch(texto_Validar))
                {
                    // o email é valido
                    return true;
                }
                else
                {
                    // o email é inválido
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public static bool EnviarEmail(string msg, string Address)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine(" <!DOCTYPE html> ");
                stringBuilder.AppendLine(" <html> ");
                stringBuilder.AppendLine(" <body> ");
                stringBuilder.AppendLine(" <table border= " + "0" + " cellpadding=" + "0" + " cellspacing=" + "0" + " width=" + "100%" + "> ");
                stringBuilder.AppendLine("  <tr> ");
                stringBuilder.AppendLine("   <td width=" + "60" + " valign=" + "top" + "> ");
                stringBuilder.AppendLine("    <table border=" + "0" + " cellpadding=" + "0" + " cellspacing=" + "0" + " width=" + "100%" + "> ");
                stringBuilder.AppendLine("    <tr> ");
                stringBuilder.AppendLine("    <tr><td>&nbsp;&nbsp;&nbsp;&nbsp;</td></tr> ");
                stringBuilder.AppendLine("    <tr><td>&nbsp;&nbsp;&nbsp;&nbsp;</td></tr> ");
                stringBuilder.AppendLine("      <td> Ola! </td> ");
                stringBuilder.AppendLine("      </tr> ");
                stringBuilder.AppendLine("      <tr><td>&nbsp;&nbsp;&nbsp;&nbsp;</td></tr> ");
                stringBuilder.AppendLine("      <tr> ");
                stringBuilder.AppendLine("      <td>" + msg.ToString() + " </td> ");
                stringBuilder.AppendLine("      <td> </td> ");
                stringBuilder.AppendLine("     </tr> ");
                stringBuilder.AppendLine("     <tr> ");
                stringBuilder.AppendLine("      <td> ");
                stringBuilder.AppendLine("       <img src=" + "data:image/png;base64,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" + " alt=" + "" + " width=" + "15%" + " height=" + "100" + " style=" + "display: block;" + " align=" + "center" + " /> Acesse nosso site!! ");
                stringBuilder.AppendLine("       <a href=" + "  " + " target=" + "_top" + ">Link </a> ");
                stringBuilder.AppendLine("      </td> ");
                stringBuilder.AppendLine("     </tr> ");
                stringBuilder.AppendLine("    </table> ");
                stringBuilder.AppendLine("   </td> ");
                stringBuilder.AppendLine("  </tr> ");
                stringBuilder.AppendLine(" <tr> ");
                stringBuilder.AppendLine(" <tr><td> &nbsp;&nbsp;&nbsp;&nbsp; </td></tr> ");
                stringBuilder.AppendLine(" <table border=" + "0" + " cellpadding=" + "0" + " cellspacing=" + "0" + " width=" + "100%" + "> ");
                stringBuilder.AppendLine("  <tr> ");
                stringBuilder.AppendLine(" <td > ");
                stringBuilder.AppendLine("  <table border=" + "0" + " cellpadding=" + "0" + " cellspacing=" + "0" + "> ");
                stringBuilder.AppendLine("   <tr> ");
                stringBuilder.AppendLine("    <td> ");
                stringBuilder.AppendLine("     <a href=" + "http://www.twitter.com/" + "> ");
                stringBuilder.AppendLine("      <img src=" + "data:image/png;base64,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" + " alt=" + "Twitter" + " width=" + "38" + " height=" + "38" + " style=" + "display: block;" + " border=" + "0" + " /> ");
                stringBuilder.AppendLine("     </a> ");
                stringBuilder.AppendLine("    </td> ");
                stringBuilder.AppendLine("    <td style=" + "font-size: 0; line-height: 0;" + " width=" + "20" + ">&nbsp;</td> ");
                stringBuilder.AppendLine("    <td> ");
                stringBuilder.AppendLine("     <a href=" + "http://www.twitter.com/" + "> ");
                stringBuilder.AppendLine("      <img src=" + "data:image/jpeg;base64,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" + " alt=" + "Facebook" + " width=" + "38" + " height=" + "38" + " style=" + "display: block;" + " border=" + "0" + " /> ");
                stringBuilder.AppendLine("     </a> ");
                stringBuilder.AppendLine("    </td>    ");
                stringBuilder.AppendLine("   </tr> ");
                stringBuilder.AppendLine("  </table> ");
                stringBuilder.AppendLine(" </td> ");
                stringBuilder.AppendLine(" <td width=" + "75%" + "> ");
                stringBuilder.AppendLine("  &reg; HelpDesk 2014<br/> ");
                stringBuilder.AppendLine("  Obrigado! ");
                stringBuilder.AppendLine(" </td> ");
                stringBuilder.AppendLine("  </tr> ");
                stringBuilder.AppendLine(" </table> ");
                stringBuilder.AppendLine(" </tr> ");
                stringBuilder.AppendLine(" </table> ");
                stringBuilder.AppendLine(" <p> ");
                stringBuilder.AppendLine(" Link do E-mail: ");
                stringBuilder.AppendLine(" <a href=" + "mailto:someone@example.com?Subject=Hello%20again" + " target=" + "_top" + ">Send Mail</a> ");
                stringBuilder.AppendLine(" </p> ");
                stringBuilder.AppendLine(" </body> ");
                stringBuilder.AppendLine(" </html> ");

                if (!ValidaEnderecoEmail(Address))
                    return false;

                var fromAddress = new MailAddress("juniorguimaraes50.jr@gmail.com", "From Name");
                var toAddress = new MailAddress(Address, "To Name");
                const string fromPassword = "22011998";
                const string subject = "E-mail HelpDesk Project UNIP";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)

                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = stringBuilder.ToString(),
                    IsBodyHtml = true
                })
                {
                    smtp.Send(message);
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
