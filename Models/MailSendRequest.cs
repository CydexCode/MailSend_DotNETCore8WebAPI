namespace SendMail_DotNETCore8WebAPI_Backend.Models
{
    public class MailSendRequest
    {
        public string ToEmail { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }
        public List<IFormFile> Attachments { get;  set; }
    }
}
