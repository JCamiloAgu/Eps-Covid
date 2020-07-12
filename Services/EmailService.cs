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
            MailjetClient client = new MailjetClient("f1fc20c420ef0e7f5f0f7d78b2d00dab", "d27d02d5056fed87219187ca439b3496")
            {
                Version = ApiVersion.V3_1,
            };

            string bodyText = string.Format("<p>Acá tienes tu código de verificación para completar el registro en la EPS " +
                "<strong> Todos Son covid </strong>.</p><p>Su codigo de confirmación es: <strong> {0} </strong></p>", code);

            MailjetRequest request = new MailjetRequest
            {
                Resource = Send.Resource,
            }.Property(Send.Messages, new JArray {
                new JObject {
                    {"From", new JObject {
                    {"Email", "jcagudelo42@misena.edu.co"},
                    {"Name", "EPS Todos son Covid"}
                    }},
                    {"To", new JArray {
                    new JObject {
                        {"Email", to},
                        {"Name", "Usuario de la EPS"}
                        }
                    }},
                    {"Subject", "Confirmar correo electrónico"},
                    {"TextPart", "Todos son Covid"},
                    {"HTMLPart", bodyText}
                    }
            });
            await client.PostAsync(request);
        }
    }
}

