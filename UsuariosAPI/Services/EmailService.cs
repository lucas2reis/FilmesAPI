using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsuariosAPI.Models;

namespace UsuariosAPI.Services
{
    public class EmailService
    {
        public IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void EnviarEmail(string[] destinatario, string assunto,
            int usuarioId, string code)
        {
            Mensagem mensagem = new Mensagem (destinatario,
                assunto, usuarioId, code);

            var mensagemDeEmail = CriaCorpoDoEmail(mensagem);
            Enviar(mensagemDeEmail);
        }

        private void Enviar(MimeMessage mensagemDeEmail)
        {
            using(var client = new SmtpClient())
            {
                try
                {
                    client.Connect(_configuration.GetValue<string>("EmailSettings:SmtpServer"),
                        _configuration.GetValue<int>("EmailSettings:Port"), true); //conexão com os servidor de email
                    client.AuthenticationMechanisms.Remove("XOUATH2");
                    client.Authenticate(_configuration.GetValue<string>("EmailSettings:from"),
                        _configuration.GetValue<string>("EmailSettings:Password"));

                    client.Send(mensagemDeEmail);
                }
                catch
                {
                    throw;
                }
                finally
                {
                    client.Disconnect(true);
                    client.Dispose();
                }
            }
        }

        private MimeMessage CriaCorpoDoEmail(Mensagem mensagem )
        {
            var mensagemdeEmail = new MimeMessage();
            mensagemdeEmail.From.Add(new MailboxAddress(
                _configuration.GetValue<string>("EmailSettings:From")));
            mensagemdeEmail.To.AddRange(mensagem.Destinatario); //encaminha a mensagem ao destinatario
            mensagemdeEmail.Subject = mensagem.Assunto;
            mensagemdeEmail.Body = new TextPart(MimeKit.Text.TextFormat.Text) //converte para compor o conteudo da mensagem
            {
                Text = mensagem.Conteudo

            };

            return mensagemdeEmail;
        }
    }
}
