using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite.Internal.UrlActions;
using Newtonsoft.Json;
using OnlineStore.Domain.Model;
using OnlineStore.Infrastructure.Global;
using OnlineStoreMGTAPP.Helper;
using OnlineStoreMGTAPP.Models;
using System.Diagnostics;
using System.Net;
using System.Net.Http;

namespace OnlineStoreMGTAPP.Controllers
{
    public class LoginController : Controller
    {
        private HttpClient Client;
                
        public ActionResult Index(string _message)
        {
            ViewBag.Message = _message;
            Client = WebApiHelper.Initial();
            HttpResponseMessage _requestMessage = Client.GetAsync(GlobalConst.Api.UserApi).Result;
            if (_requestMessage.IsSuccessStatusCode)
                ViewBag.Stgtxt = _requestMessage.Content.ReadAsAsync<string>().Result;
            return View();
        }
        [HttpPost]
        public ActionResult Index(User _user)
        {
            Client = WebApiHelper.Initial();
            HttpResponseMessage _requestMessage = Client.GetAsync(GlobalConst.Api.UserApi + "GetByEmailID\\" + _user.EmailID).Result;
            if (_requestMessage.IsSuccessStatusCode)
            {                
                var user = _requestMessage.Content.ReadAsAsync<User>().Result;
                if (_user.EmailID == user.EmailID && _user.Password == user.Password)
                {
                    if (user.UserTypeID == 2)
                    {
                        HttpResponseMessage _msg = Client.GetAsync(GlobalConst.Api.Seller + "GetSellerProfileByUserID\\" + user.UserID).Result;
                        if (_msg.IsSuccessStatusCode)
                        {                            
                            return RedirectToAction(GlobalConst.Actions.HomeController.Index, GlobalConst.Controller.Home);                           
                        }
                        else
                        {
                            return RedirectToAction(GlobalConst.Actions.SellerInformationController.AddSellerInformation
                                , GlobalConst.Controller.SellerInformation
                                , new { id = user.UserID, emailID = user.EmailID });
                        }
                    }
                    else
                    {
                        return RedirectToAction(GlobalConst.Actions.HomeController.Index, GlobalConst.Controller.Home);
                    }
                }
                else
                {
                    return View();
                }
            }
            return View();
        }

        [HttpGet]
        public JsonResult UserExists(string value)
        {
            var message = "";
            Client = WebApiHelper.Initial();
            HttpResponseMessage _requestMessage = Client.GetAsync(GlobalConst.Api.UserApi + "GetByEmailID\\" + value).Result;
            if (_requestMessage.IsSuccessStatusCode)
            {
                var user = _requestMessage.Content.ReadAsAsync<User>().Result;
                if (user.EmailID == value)
                {
                    message = "Yes";
                }
                else
                {
                    message = "No";
                }
            }
            else
            {
                message = "No";
            }
            return Json(message);
        }

        [HttpPost]
        public ActionResult AddUser(User objuser)
        {
            string reCaptchaResult = ValidateCaptcha();

            if (reCaptchaResult == GlobalConst.reCaptchaValidation.ValidResult)
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
                return RedirectToAction(GlobalConst.Actions.LoginController.Index, GlobalConst.Controller.Login, new { _message = TempData["message"] });
            }
            else
            {
                return RedirectToAction(GlobalConst.Actions.LoginController.Index, GlobalConst.Controller.Login, new { _message = reCaptchaResult });
            }
        }

        public string ValidateCaptcha()
        {
            string result = GlobalConst.reCaptchaValidation.ValidResult;
            var response = HttpContext.Request.Form[GlobalConst.reCaptchaValidation.recaptchaResponse];
            //secret that was generated in key value pair
            const string secret = GlobalConst.reCaptchaValidation.seceretKey;

            var client = new WebClient();
            var reply =
                client.DownloadString(
                    string.Format(GlobalConst.reCaptchaValidation.formatString, secret, response));

            var captchaResponse = JsonConvert.DeserializeObject<CaptchaResponse>(reply);

            //when response is false check for the error message
            if (!captchaResponse.Success)
            {
                if (captchaResponse.ErrorCodes.Count <= 0) return result;

                var error = captchaResponse.ErrorCodes[0].ToLower();
                switch (error)
                {
                    case (GlobalConst.reCaptchaValidation.missingInputSecret):
                        result = GlobalConst.reCaptchaValidation.TheSecretParameterIsMissing;
                        break;
                    case (GlobalConst.reCaptchaValidation.InvalidInputSecret):
                        result = GlobalConst.reCaptchaValidation.TheSecretParameterIsinvalidOrmalformed;
                        break;

                    case (GlobalConst.reCaptchaValidation.MissingInputResponse):
                        result = GlobalConst.reCaptchaValidation.TheResponseParameterIsMissing;
                        break;
                    case (GlobalConst.reCaptchaValidation.InvalidInputResponse):
                        result = GlobalConst.reCaptchaValidation.TheResponsParameterIsInvalidOrMalFormed;
                        break;

                    default:
                        result = GlobalConst.reCaptchaValidation.ErrorOccuredPleasetryAgain;
                        break;
                }
            }
            else
            {
                result = GlobalConst.reCaptchaValidation.ValidResult;
            }

            return result;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
