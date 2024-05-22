using SendMail_DotNETCore8WebAPI_Backend.Models;

namespace SendMail_DotNETCore8WebAPI_Backend.Interfaces
{
    public interface IMailSendService
    {
        public Task SendEmailAsync(MailSendRequest mailrequest);
    }
}
