using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IQUEventors
{
    public class UserSubmission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public byte[] Signature { get; set; }
        public DateTime SubmissionDate { get; set; }
    }
}