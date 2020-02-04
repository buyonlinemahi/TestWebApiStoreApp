using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnlineStore.Domain.Model;
using OnlineStore.Infrastructure.Global;
using OnlineStoreMGTAPP.Helper;
using System.Net.Http;
using System.Collections.Generic;
using System.Net.Mail;
using System.Net;
using Paged = OnlineStore.Domain.Model.Paged;
using System;

namespace OnlineStoreMGTAPP.Controllers
{
    public class CommonController : Controller
    {
        private HttpClient Client;

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetCategoryAll()
        {
            Client = WebApiHelper.Initial();
            var response = Client.GetAsync(GlobalConst.Api.Common + "getAllCategory").Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            IEnumerable<Category> objuser = JsonConvert.DeserializeObject<IEnumerable<Category>>(responseContent);
            return Json(objuser);
        }

        [HttpPost]
        public JsonResult GetUserTypeAll()
        {
            Client = WebApiHelper.Initial();
            var response = Client.GetAsync(GlobalConst.Api.Common + "GetUserTypes").Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            IEnumerable<UserType> objuser = JsonConvert.DeserializeObject<IEnumerable<UserType>>(responseContent);
            return Json(objuser);
        }

        [HttpPost]
        public JsonResult GetDiscountTypeAll()
        {
            Client = WebApiHelper.Initial();
            var response = Client.GetAsync(GlobalConst.Api.Common + "GetDiscountTypes").Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            IEnumerable<DiscountType> discountTypes = JsonConvert.DeserializeObject<IEnumerable<DiscountType>>(responseContent);
            return Json(discountTypes);
        }


        [HttpPost]
        public JsonResult GetSubCategoryByCategoryID(int categoryID)
        {
            Client = WebApiHelper.Initial();
            var response = Client.GetAsync(GlobalConst.Api.Common + "GetSubCategoryByCategoryID\\" + categoryID).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            IEnumerable<SubCategory> objuser = JsonConvert.DeserializeObject<IEnumerable<SubCategory>>(responseContent);
            return Json(objuser);
        }

        [HttpPost]
        public JsonResult GetAllProducts()
        {
            Client = WebApiHelper.Initial();
            var response = Client.GetAsync(GlobalConst.Api.Common + "GetAllProducttypes").Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            IEnumerable<Product> products = JsonConvert.DeserializeObject<IEnumerable<Product>>(responseContent);
            return Json(products);
        }

        [HttpPost]
        public JsonResult GetAllSpecHeading()
        {
            Client = WebApiHelper.Initial();
            var response = Client.GetAsync(GlobalConst.Api.Common + "GetAllSpecHeading").Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            IEnumerable<ProductSpecHeading> productSpecHeadings = JsonConvert.DeserializeObject<IEnumerable<ProductSpecHeading>>(responseContent);
            return Json(productSpecHeadings);
        }

        [HttpPost]
        public JsonResult GetStatusAll()
        {
            Client = WebApiHelper.Initial();
            var response = Client.GetAsync(GlobalConst.Api.Common + "GetAllStatuses").Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            IEnumerable<StockStatus> stockStatuses = JsonConvert.DeserializeObject<IEnumerable<StockStatus>>(responseContent);
            return Json(stockStatuses);
        }

        [HttpPost]
        public JsonResult GetAllUnitMeasurement()
        {
            Client = WebApiHelper.Initial();
            var response = Client.GetAsync(GlobalConst.Api.Common + "GetAllUnitMeasurement").Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            IEnumerable<UnitMeasurement> unitMeasurements = JsonConvert.DeserializeObject<IEnumerable<UnitMeasurement>>(responseContent);
            return Json(unitMeasurements);
        }


    }
}