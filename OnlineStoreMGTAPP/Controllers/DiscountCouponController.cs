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


namespace OnlineStoreMGTAPP.Controllers
{
    public class DiscountCouponController : Controller
    {
        private HttpClient Client;
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddDiscountCoupon(bool flag)
        {
            if (flag == true)
            {
                ViewBag.CouponCode = GenrateDiscountCouponCode(7);
            }
            return View();
        }

        [HttpPost]
        public ActionResult AddDiscountCoupon(Coupon coupon)
        {
            Client = WebApiHelper.Initial();           
            HttpResponseMessage _requestMessage = Client.PostAsJsonAsync(GlobalConst.Api.Coupon + "AddCoupon\\coupon\\", coupon).Result;
            if (_requestMessage.IsSuccessStatusCode)
            {
                coupon.Message = GlobalConst.Message.AddSucessfully;
            }
            return Json(coupon);
        }

        public static string GenrateDiscountCouponCode(int length)
        {
            string allowedLetterChars = GlobalConst.Message.allowedLetterChars;
            string allowedNumberChars = GlobalConst.Message.allowedNumberChars;
            char[] chars = new char[length];
            Random rd = new Random();

            bool useLetter = true;
            for (int i = 0; i < length; i++)
            {
                if (useLetter)
                {
                    chars[i] = allowedLetterChars[rd.Next(0, allowedLetterChars.Length)];
                    useLetter = false;
                }
                else
                {
                    chars[i] = allowedNumberChars[rd.Next(0, allowedNumberChars.Length)];
                    useLetter = true;
                }

            }
            return new string(chars);
        }
    }
}