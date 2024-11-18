using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IQUEventors
{
    public partial class SuccessPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                int id = int.Parse(Request.QueryString["id"]);

                using (var db = new AppDbContext())
                {
                    var submission = db.UserSubmissions.FirstOrDefault(s => s.Id == id);

                    if (submission != null)
                    {
                        Response.Write($"<p><strong>Name:</strong> {submission.Name}</p>");
                        Response.Write($"<p><strong>Email:</strong> {submission.Email}</p>");
                        Response.Write($"<p><strong>Phone Number:</strong> {submission.PhoneNumber}</p>");
                        Response.Write($"<h3>Signature:</h3><img src='data:image/png;base64,{Convert.ToBase64String(submission.Signature)}' alt='User Signature' />");
                    }
                }
            }
        }
    }
}