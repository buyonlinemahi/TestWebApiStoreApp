using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnlineStore.Domain.Model;
using OnlineStore.Infrastructure.Global;
using OnlineStoreMGTAPP.Helper;
using System.Net.Http;
using System.Collections.Generic;
using System.Net;
using System;
using OnlineStore.Infrastructure.ApplicationServices.Contracts;
using System.IO;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting;
using System.Security.Cryptography;
using MimeKit;
using MailKit.Net.Smtp;

namespace OnlineStoreMGTAPP.Controllers
{
    public class SellerInformationController : Controller
    {
        private HttpClient Client;
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddSellerInformation(int id, string emailID)
        {
            ViewBag.UserID = id;
            ViewBag.EmailID = emailID;
            return View();
        }

        [HttpPost]
        public ActionResult AddSellerInformation(SellerProfile sellerProfile)
        {
            Client = WebApiHelper.Initial();
            string mID = GenrateMerchantID();
            sellerProfile.MerchantID = Convert.ToInt64(mID) + sellerProfile.UserID;
            HttpResponseMessage _requestMessage = Client.PostAsJsonAsync(GlobalConst.Api.Seller + "AddSellerProfile\\sellerProfile\\", sellerProfile).Result;
            if (_requestMessage.IsSuccessStatusCode)
            {
                sellerProfile.Message = GlobalConst.Message.AddSucessfully;
            }
            BodyBuilder sb = new BodyBuilder();
            sb.HtmlBody = "**THIS IS AN AUTOMATED MESSAGE - PLEASE DO NOT REPLY DIRECTLY TO THIS EMAIL**" + "<br><br>"
            + "Hi, " + "<br><br>"
            + "This is Your MerchantID ." + sellerProfile.MerchantID + "<br>"
             + "<br><br>" + "Thank You,"
            + "<br><br>" + "Innovate Support Team";
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("software@hcrg.com", "software@hcrg.com"));
            message.To.Add(new MailboxAddress(sellerProfile.EmailID, sellerProfile.EmailID));
            message.Subject = "Seller MerchantID";
            message.Body = sb.ToMessageBody();
            using (var client = new SmtpClient())
            {
                client.Connect("smtp.office365.com", 587, false);
                client.Authenticate("software@hcrg.com", "Cuxo9003");
                client.Send(message);
                client.Disconnect(true);
            }
            return Json(sellerProfile);
        }        

        public string GenrateMerchantID()
        {
            var bytes = new byte[4];
            var rng = RandomNumberGenerator.Create();
            rng.GetBytes(bytes);
            uint random = BitConverter.ToUInt32(bytes, 0) % 100000000;
            string MID = String.Concat(random + "00000000");
            return String.Format("{0:D8}", MID);
        }       
    }
}