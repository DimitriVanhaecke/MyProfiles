using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Specialized;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MyProfiles
{
    public class Message
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string TextMessage { get; set; }
    }
}