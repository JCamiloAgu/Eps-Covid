using Mailjet.Client;
using Mailjet.Client.Resources;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace CitasEps.Services
{
    class EmailService
    {

        public static async Task SendEmailAsync(string to, string code)
        {
            /*
			 * Se crea una instancia a la libreria MailjetClient con el KEY y el SECRET del usuario creado en la
			 * plataforma de mailjet.
			 */
            MailjetClient client = new MailjetClient("b20374fadb92b3c1925b191b84b6f811", "daea60aa14a21ba8b806162d42ee9ccd")
            {
                Version = ApiVersion.V3_1,
            };

            string bodyText = string.Format("<p>Hola! esto es un correo de confirmación de la plataforma de citas de su EPS 'La última morada'.</p><p>Su codigo de confirmación es: <strong> {0} </strong></p>", code);

            MailjetRequest request = new MailjetRequest
            {
                Resource = Send.Resource,
            }.Property(Send.Messages, new JArray {
                new JObject {
                    {"From", new JObject {
                    {"Email", "fernando.zapata.live@gmail.com"},
                    {"Name", "La última morada - EPS"}
                    }},
                    {"To", new JArray {
                    new JObject {
                        {"Email", to},
                        {"Name", "Usuario EPS"}
                        }
                    }},
                    {"Subject", "¡Confirmación de Correo!"},
                    {"TextPart", "La última morada - EPS"},
                    {"HTMLPart", bodyText}
                    }
            });
            await client.PostAsync(request);
        }
    }
}

