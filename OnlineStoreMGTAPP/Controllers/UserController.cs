using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnlineStore.Domain.Model;
using OnlineStore.Infrastructure.Global;
using OnlineStoreMGTAPP.Helper;
using System.Net.Http;
using System.Collections.Generic;
using System.Net;
using MimeKit;
using MailKit.Net.Smtp;
using Paged = OnlineStore.Domain.Model.Paged;
using System;
using System.Text;
using OnlineStore.Infrastructure.ApplicationServices.Contracts;
using System.Security.Cryptography;
using OnlineStoreMGTAPP.Models;

namespace OnlineStoreMGTAPP.Controllers
{
    public class UserController : Controller
    {
        private HttpClient Client;
        WebApiHelper ObjHelper = new WebApiHelper();
        
        [HttpGet]
        public ActionResult Index()
        {           
            return View();
        }
        [HttpPost]
        public ActionResult GetDataForIndex()
        {
            Client = WebApiHelper.Initial();
            var response = Client.GetAsync(GlobalConst.Api.UserApi + "GetUsersByName\\" + GlobalConst.ConstantChar.UnderScore + "," + GlobalConst.Records.Skip + "," + GlobalConst.Records.Take).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            Paged.User objUser = JsonConvert.DeserializeObject<Paged.User>(responseContent);
            return Json(objUser);
        }

        [HttpPost]
        public ActionResult GetPagedUserData(int skip)
        {
            Client = WebApiHelper.Initial();
            var response = Client.GetAsync(GlobalConst.Api.UserApi + "GetUsersByName\\" + GlobalConst.ConstantChar.UnderScore + "," + skip + "," + GlobalConst.Records.Take).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            Paged.User objUser = JsonConvert.DeserializeObject<Paged.User>(responseContent);
            return Json(objUser);
        }

        [HttpPost]
        public ActionResult GetUserByUserName(string searchtext, int? skip)
        {
            Paged.User objUser = new Paged.User();
            Client = WebApiHelper.Initial();
            if (skip == null)
            {
                var response = Client.GetAsync(GlobalConst.Api.UserApi + "GetUsersByName\\" +  searchtext  + "," + GlobalConst.Records.Skip + "," + GlobalConst.Records.Take).Result;
                var responseContent = response.Content.ReadAsStringAsync().Result;
                objUser = JsonConvert.DeserializeObject<Paged.User>(responseContent);
            }
            else
            {
                var response = Client.GetAsync(GlobalConst.Api.UserApi + "GetUsersByName\\" +  searchtext  + "," + skip.Value + "," + GlobalConst.Records.Take).Result;
                var responseContent = response.Content.ReadAsStringAsync().Result;
                objUser = JsonConvert.DeserializeObject<Paged.User>(responseContent);
            }            
            return Json(objUser);
        }

        public ActionResult AddUser()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddUser(User objuser)
        {
                Client = WebApiHelper.Initial();
                objuser.IsActive = true;
                HttpResponseMessage _requestMessage = Client.PostAsJsonAsync(GlobalConst.Api.UserApi + "AddUser\\_users\\", objuser).Result;
                if (_requestMessage.IsSuccessStatusCode)
                {
                    TempData["message"] = GlobalConst.Message.UserAdded;
                }
                else
                {
                    TempData["message"] = GlobalConst.Message.UserFail;
                }
            return RedirectToAction(GlobalConst.Actions.UserController.Index, GlobalConst.Controller.User, new { _message = TempData["message"] });
        }



        public ActionResult ResetPassword(string id, string cnt)
        {
            string[] DecryptData = new string[1];
            DecryptData[0] = ObjHelper.DecryptString(id);
            var _data = DecryptData[0].Split(',');
            string _userId = _data[0];
            DateTime _datetime = Convert.ToDateTime(_data[1]);
            DateTime date1 = _datetime;
            DateTime date2 = System.DateTime.Now;
            TimeSpan ts = date2 - date1;
            User Objuser = new User();
            Objuser.UserIDEncry = ObjHelper. EncryptString(_userId);
            Objuser.Cnt = int.Parse(ObjHelper.DecryptString(cnt));
            Objuser.PasswordOTP = ObjHelper.EncryptString(_data[2]);
            if (ts.TotalHours > 1)
            Objuser.Message = "Expired";
            Objuser.EmailID = null;
            Objuser.Password = null;
            Objuser.UserID = 0;
            return View(Objuser);
        }

        [HttpPost]
        public JsonResult ResetPassword(string _userID, string _password, string _passwordValidateOTP, string _passwordOTP)
        {
            int UID = Convert.ToInt32(ObjHelper.DecryptString(_userID));
            User Objuser = new User();
            if (UID > 0)
            {
                Client = WebApiHelper.Initial();
                HttpResponseMessage _requestMessage = Client.PutAsJsonAsync(GlobalConst.UserController.UserApi + "updatePasswordByID\\" + UID +","+ ObjHelper.HashPassword(_password),"").Result;
                Objuser.UserID = UID;
                Objuser.Password = ObjHelper.HashPassword(_password);
                return Json("Yes");
            }
            else
            return Json("No");
        }

        [HttpPost]
        public ActionResult ForgotPassword(string _emailID)
        {
            Client = WebApiHelper.Initial();
            HttpResponseMessage _requestMessage = Client.GetAsync(GlobalConst.UserController.UserApi + "GetByEmailID\\" + _emailID).Result;
            if (_requestMessage.IsSuccessStatusCode)
            {
                var user = _requestMessage.Content.ReadAsAsync<User>().Result;
                if (user != null)
                {
                    Random Generator = new Random();
                    String _strOTP = Generator.Next(0, 999999).ToString("D6");
                    string _datetime = System.DateTime.Now.ToString();
                    DateTime currentTime = DateTime.Now;
                    DateTime x60MinsLater = currentTime.AddMinutes(60);
                    string _concatinate = user.UserID.ToString() + "," + _datetime + "," + _strOTP;
                    string encryptedData = ObjHelper.EncryptString(_concatinate);
                    BodyBuilder sb = new BodyBuilder();
                    sb.HtmlBody = "**THIS IS AN AUTOMATED MESSAGE - PLEASE DO NOT REPLY DIRECTLY TO THIS EMAIL**" + "<br><br>"
                    + "Hello " + user.FirstName + " " + user.LastName + "," + "<br><br>"
                    + "Please use the following link and One Time Password to update your account."
                    + "<br><br>" + "One Time Password: " + _strOTP + "<br>"
                    + "Link: <a href='" + GlobalConst.ConstantChar.Url + "User/ResetPassword/" + encryptedData + @"/" + ObjHelper.EncryptString("0").ToString() + "'>Reset Password</a><br><br>" +
                   "One Time Password and Link will expire in " + x60MinsLater + "<br><br>" +
                   "If you did not request this please disregard this email." +
                   "<br><br>" + "Thank You,"
                   + "<br><br>" + "Innovate Support Team";
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("software@hcrg.com", "software@hcrg.com"));
                    message.To.Add(new MailboxAddress("pkaur@vsaindia.com", "pkaur@vsaindia.com"));
                    message.Subject = "Forgot Password";
                    message.Body = sb.ToMessageBody();
                    using (var client = new SmtpClient())
                    {
                        client.Connect("smtp.office365.com", 587, false);
                        client.Authenticate("software@hcrg.com", "Cuxo9003");
                        client.Send(message);
                        client.Disconnect(true);
                    }
                    return Json(GlobalConst.Message.EmailSentToRegisteredEmail);
                }
                else
                {
                    return Json(GlobalConst.Message.EmailNotExists);
                }
            }
            return View();
        }

    }
}