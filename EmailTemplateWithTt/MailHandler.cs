using EmailTemplateWithTt.ModelDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailTemplateWithTt
{
    public class MailHandler
    {
        public void Run(DateTime? dateParameter)
        {
            var testDate = new List<TestDto>();
           
            if (testDate.Count>0)
            {
                var template = new EmailTemplate.RunTimeTemplate
                {
                    Items = testDate.ToList()
                };
                var html = template.TransformText();
                SendEmail(html);
            }
        }
        public void SendEmail(string body)
        {
            //var mailApi = new EmailApi(); //kullanılan email api
            //var requestModel = new SendRequest
            //{
            //    To = "",
            //    Cc = "",
            //    Bcc = "",
            //    Body = body,
            //    IsBodyHtml = true,
            //    Subject = "",
            //    VerifyBeforeSend = false
            //};

            //mailApi.EmailPost(requestModel);
        }
    }
}
