using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IQUEventors
{
    public partial class FormPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SubmitForm(object sender, EventArgs e)
        {
            string name = Request.Form["name"];
            string email = Request.Form["email"];
            string phone = Request.Form["phone"];
            string signatureDataUrl = Request.Form["signatureData"];

            byte[] signatureBytes = ConvertDataUrlToByteArray(signatureDataUrl);

            using (var db = new AppDbContext())
            {
                UserSubmission submission = new UserSubmission
                {
                    Name = name,
                    Email = email,
                    PhoneNumber = phone,
                    Signature = signatureBytes,
                    SubmissionDate = DateTime.Now
                };

                db.UserSubmissions.Add(submission);
                db.SaveChanges();
            }
            UserSubmission sub = new UserSubmission();

            Response.Redirect($"SuccessPage.aspx?id={sub.Id}");
        }

        private byte[] ConvertDataUrlToByteArray(string dataUrl)
        {
            var base64Data = dataUrl.Split(',')[1];
            return Convert.FromBase64String(base64Data);
        }
    }
}