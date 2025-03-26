using QLNongSan.DAL;
using QLNongSan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QLNongSan.BUS
{
    public class BUS_HoTro
    {
        private DAL_HoTro dalHoTro = new DAL_HoTro();
        public bool HoTroKH(DTO_HoTro ht)
        {
            // Lưu phản hồi vào cơ sở dữ liệu
            bool result = dalHoTro.HoTroKH(ht);

            // Gửi email xác nhận
            if (result)
            {
                guiMailHoTro(ht.Email, ht.NoiDung, ht.ThoiGian);
                guiMailQuanLy(ht.Email, ht.NoiDung, ht.ThoiGian);
            }

            return result;
        }

        public void guiMailHoTro(string emailHT, string noidung, DateTime thoigian)
        {
            try
            {
                var fromAddress = new MailAddress("DuAnQuanLyNongSan@gmail.com", "Phần mềm quản lý nông sản");
                var toAddress = new MailAddress(emailHT);//Địa chỉ email của khách hàng nhập trong form hỗ trợ
                const string fromPassword = "sqsc sbex rmcs ypjp";
                const string subject = "Cảm ơn bạn đã gửi phản hồi";
                string body = $"Chào bạn. \nCảm ơn bạn đã phản hồi với nội dung : \n{noidung} \n \nVào {thoigian} \nĐây là email tự động không cần trả lời. \nXin cảm ơn. \nPhần mềm quản lý nông sản.";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi gửi email: " + ex.Message);
            }
        }
        private string guiMailQuanLy(string userEmail, string noidung, DateTime thoigian)
        {
            try
            {
                var fromAddress = new MailAddress("DuAnQuanLyNongSan@gmail.com", "Phản hồi");
                var toAddress = new MailAddress("DuAnQuanLyNongSan@gmail.com"); // Địa chỉ email của quản lý cửa hàng
                const string fromPassword = "sqsc sbex rmcs ypjp";
                const string subject = "Phản hồi mới từ khách hàng";
                string body = $"Xin chào.\nKhách hàng với email '{userEmail}' đã phản hồi với nội dung: '{noidung}' \nVào {thoigian}";

                var smtp = new SmtpClient
                {
                    Host = "smtp.office365.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
                return null; // Return null if email is sent successfully
            }
            catch (Exception ex)
            {
                return "Lỗi gửi email cho quản lý: " + ex.Message;
            }
        }

    }
}
