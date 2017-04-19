using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using KDTHK_MOULD_SYSTEM.services;

namespace KDTHK_MOULD_SYSTEM.utils
{
    public class EmailUtil
    {
        public static void SendEmail(string from, string to, string subject)
        {
            //return; /* Added by Cato Yeung 2017/04/13 */
            string hostname = "Kdmail.km.local";
            string text = "Fixed Asset Approval required. Please click <a href=\"\\\\kdthk-dm1\\project\">HERE</a> to approval process.";
            string content = "<p><span style=\"font-family: Calibri;\">" + text + "</span></p>";

            SmtpClient client = new SmtpClient(hostname);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;

            MailMessage mail = new MailMessage(from, to);
            mail.IsBodyHtml = true;
            mail.Subject = subject;
            mail.Body = content;
            client.Send(mail);
        }

        public static void SendNotificationMail()
        {
            //return; /* Added by Cato Yeung 2017/04/13 */
            string hostname = "Kdmail.km.local";
            string subject = "Ringi Approved";
            string text = "Ringi has been approved. Please go forward for further operation.";
            string content = "<p><span style=\"font-family: Calibri;\">" + text + "</span></p>";

            SmtpClient client = new SmtpClient(hostname);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;

            string email = GlobalService.Owner == GlobalService.CM1st ? "sammy.chow@dthk.kyocera.com" : "ken.lai@dthk.kyocera.com";

            //MailMessage mail = new MailMessage("ken.ho@dthk.kyocera.com", "ken.ho@dthk.kyocera.com");
            MailMessage mail = new MailMessage(email, "zoe.lee@dthk.kyocera.com");
            mail.IsBodyHtml = true;
            mail.Subject = subject;
            mail.Body = content;
            mail.CC.Add("winnie.lau@dthk.kyocera.com");
            mail.CC.Add("sharon.li@dthk.kyocera.com");
            client.Send(mail);

        }
    }
}
