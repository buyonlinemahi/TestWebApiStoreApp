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

using OnlineStore.Infrastructure.ApplicationServices.Contracts;
using System.IO;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting;

namespace OnlineStoreMGTAPP.Controllers
{
    public class ProductController : Controller
    {
       
        private HttpClient Client;
        StorageHelper _storageHelper = new StorageHelper();

        private readonly IHostingEnvironment _appEnvironment;
       
        public ProductController(IHostingEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;          
        }

        #region Category
        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            Client = WebApiHelper.Initial();
            if (category.CategoryID == 0)
            {
                HttpResponseMessage _requestMessage = Client.PostAsJsonAsync(GlobalConst.Api.ProductApi + "AddCategory\\category\\", category).Result;
                if (_requestMessage.IsSuccessStatusCode)
                {
                    category.CategoryID = _requestMessage.Content.ReadAsAsync<int>().Result;
                    category.Message = GlobalConst.Message.AddSucessfully;
                }
            }
            else
            {
                HttpResponseMessage _requestMessage = Client.PutAsJsonAsync(GlobalConst.Api.ProductApi + "UpdateCategory\\category\\", category).Result;
                if (_requestMessage.IsSuccessStatusCode)
                {
                    category.Message = GlobalConst.Message.UpdateSucessfully;
                }
            }
            return Json(category);
        }


        [HttpPost]
        public JsonResult DeleteCategory(Category category)
        {
            Client = WebApiHelper.Initial();
            HttpResponseMessage _requestMessage = Client.DeleteAsync(GlobalConst.Api.ProductApi + "DeleteCategory\\" + category.CategoryID).Result;
            return Json("Category Deleted Successfully");
        }

        [HttpPost]
        public JsonResult GetCategoryByID(int categoryID)
        {
            Client = WebApiHelper.Initial();
            var response = Client.GetAsync(GlobalConst.Api.ProductApi + "GetCategoryByID\\" + categoryID).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            IEnumerable<Category> objcategory = JsonConvert.DeserializeObject<IEnumerable<Category>>(responseContent);
            return Json(objcategory);
        }

        public ActionResult GetCategoriesLikeCategoryName()
        {
            string searchText = HttpContext.Request.Query["term"].ToString();
            Client = WebApiHelper.Initial();
            var response = Client.GetAsync(GlobalConst.Api.ProductApi + "GetCategoriesLikeCategoryName\\" + searchText).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            IEnumerable<Category> objcategory = JsonConvert.DeserializeObject<IEnumerable<Category>>(responseContent);
            return Json(objcategory);
        }
        #endregion

        #region SubCategory
        [HttpPost]
        public ActionResult AddSubCategory(SubCategory subCategory)
        {
            Client = WebApiHelper.Initial();
            if (subCategory.SubCategoryID == 0)
            {
                HttpResponseMessage _requestMessage = Client.PostAsJsonAsync(GlobalConst.Api.ProductApi + "AddSubCategory\\subCategory\\", subCategory).Result;
                if (_requestMessage.IsSuccessStatusCode)
                {
                    var response = Client.GetAsync(GlobalConst.Api.ProductApi + "GetCategoryByID\\" + subCategory.CategoryID).Result;
                    var responseContent = response.Content.ReadAsStringAsync().Result;
                    subCategory.CategoryName = JsonConvert.DeserializeObject<Category>(responseContent).CategoryName;
                    subCategory.SubCategoryID = _requestMessage.Content.ReadAsAsync<int>().Result;
                    subCategory.Message = GlobalConst.Message.AddSucessfully;
                }
            }
            else
            {
                HttpResponseMessage _requestMessage = Client.PutAsJsonAsync(GlobalConst.Api.ProductApi + "UpdateSubCategory\\subCategory\\", subCategory).Result;
                if (_requestMessage.IsSuccessStatusCode)
                {
                    var response = Client.GetAsync(GlobalConst.Api.ProductApi + "GetCategoryByID\\" + subCategory.CategoryID).Result;
                    var responseContent = response.Content.ReadAsStringAsync().Result;
                    subCategory.CategoryName = JsonConvert.DeserializeObject<Category>(responseContent).CategoryName;
                    subCategory.Message = GlobalConst.Message.UpdateSucessfully;
                }
            }
            return Json(subCategory);
        }

        [HttpPost]
        public JsonResult DeleteSubCategory(SubCategory subCategory)
        {
            Client = WebApiHelper.Initial();
            HttpResponseMessage _requestMessage = Client.DeleteAsync(GlobalConst.Api.ProductApi + "DeleteSubCategory\\" + subCategory.SubCategoryID).Result;
            return Json("SubCategory Deleted Successfully");
        }

        [HttpPost]
        public JsonResult GetSubCategoryByID(int subcategoryID)
        {
            Client = WebApiHelper.Initial();
            var response = Client.GetAsync(GlobalConst.Api.ProductApi + "GetSubCategoryByID\\" + subcategoryID).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            IEnumerable<SubCategory> objSubcategory = JsonConvert.DeserializeObject<IEnumerable<SubCategory>>(responseContent);
            return Json(objSubcategory);
        }

        [HttpPost]
        public JsonResult GetSubCategoriesLikeSubCategoryName(string searchText)
        {
            Client = WebApiHelper.Initial();
            var response = Client.GetAsync(GlobalConst.Api.ProductApi + "GetSubCategoriesLikeSubCategoryName\\" + searchText).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            IEnumerable<SubCategory> objSubcategory = JsonConvert.DeserializeObject<IEnumerable<SubCategory>>(responseContent);
            return Json(objSubcategory);
        }

        #endregion

        #region Product

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(Product product)
        {             
            Client = WebApiHelper.Initial();
            HttpResponseMessage _requestMessage = Client.PostAsJsonAsync(GlobalConst.Api.ProductApi + "AddProduct\\products\\", product).Result;
            if (_requestMessage.IsSuccessStatusCode)
                {
                     product.ProductID = _requestMessage.Content.ReadAsAsync<int>().Result;                  
                }        
            return Json(product);          
        }


        [HttpPost]
        public ActionResult UploadProductPhotos(string[] photoFiles, string[] photoNames, int id)  
        {
            ProductImage objImage = new ProductImage();
            Client = WebApiHelper.Initial();
            for (int i = 0; i < photoFiles.Length; i++)
            {
                byte[] bytes = Convert.FromBase64String(photoFiles[i].Split(',')[1]);
                string UploadFolder = Path.Combine(_appEnvironment.WebRootPath, "Storage");               
                string filepath = _storageHelper.SetProductPhotoStoragePath((UploadFolder + GlobalConst.ConstantChar.DoubleBackSlash), photoNames[i]);
                using (System.IO.FileStream stream = new System.IO.FileStream(filepath, System.IO.FileMode.Create))
                {
                    stream.Write(bytes, 0, bytes.Length);
                    stream.Flush();
                }               
                objImage.ProductID = id;
                objImage.ProductPhoto = Path.GetFileName(filepath);               
                HttpResponseMessage _requestMessage = Client.PostAsJsonAsync(GlobalConst.Api.ProductApi + "AddProductImage\\productImage\\", objImage).Result;
            }
            return Json("Photos added Successfully");
        }
        #endregion

        #region ProductSpecHeading
        [HttpPost]
        public ActionResult AddProductdescrption(ProductSpecHeading productSpecHeading)
        {
            Client = WebApiHelper.Initial();
            if (productSpecHeading.SpecHeadingID == 0)
            {
                HttpResponseMessage _requestMessage = Client.PostAsJsonAsync(GlobalConst.Api.ProductApi + "AddProductSpecHeading\\productSpecHeading\\", productSpecHeading).Result;
                if (_requestMessage.IsSuccessStatusCode)
                {
                    productSpecHeading.SpecHeadingID = _requestMessage.Content.ReadAsAsync<int>().Result;
                    productSpecHeading.Message = GlobalConst.Message.AddSucessfully;
                }
            }
            else
            {
                HttpResponseMessage _requestMessage = Client.PutAsJsonAsync(GlobalConst.Api.ProductApi + "UpdateProductSpecHeading\\productSpecHeading\\", productSpecHeading).Result;
                if (_requestMessage.IsSuccessStatusCode)
                {
                    productSpecHeading.Message = GlobalConst.Message.UpdateSucessfully;
                }
            }
            return Json(productSpecHeading);
        }

        [HttpPost]
        public JsonResult DeleteProductSpecHeading(ProductSpecHeading productSpecHeading)
        {
            Client = WebApiHelper.Initial();
            HttpResponseMessage _requestMessage = Client.DeleteAsync(GlobalConst.Api.ProductApi + "DeleteProductSpecHeading\\" + productSpecHeading.SpecHeadingID).Result;
            return Json("Deleted Successfully");
        }
        #endregion

        #region ProductSpecSubHeading
        [HttpPost]
        public ActionResult AddProductdescrptionSub(ProductSpecSubHeading productSpecSubHeading)
        {
            Client = WebApiHelper.Initial();
            if (productSpecSubHeading.ProductSpecSubHeadingID == 0)
            {
                HttpResponseMessage _requestMessage = Client.PostAsJsonAsync(GlobalConst.Api.ProductApi + "AddProductSpecSubHeading\\productSpecSubHeading\\", productSpecSubHeading).Result;
                if (_requestMessage.IsSuccessStatusCode)
                {
                    var response = Client.GetAsync(GlobalConst.Api.ProductApi + "GetProductSpecHeadingByID\\" + productSpecSubHeading.SpecHeadingID).Result;
                    var responseContent = response.Content.ReadAsStringAsync().Result;
                    productSpecSubHeading.ProductSpecHeadingTitle = JsonConvert.DeserializeObject<ProductSpecHeading>(responseContent).SpecHeadingTitle;
                    productSpecSubHeading.ProductSpecSubHeadingID = _requestMessage.Content.ReadAsAsync<int>().Result;
                    productSpecSubHeading.Message = GlobalConst.Message.AddSucessfully;
                }
            }
            else
            {
                HttpResponseMessage _requestMessage = Client.PutAsJsonAsync(GlobalConst.Api.ProductApi + "UpdateProductSpecSubHeading\\productSpecSubHeading\\", productSpecSubHeading).Result;
                if (_requestMessage.IsSuccessStatusCode)
                {
                    var response = Client.GetAsync(GlobalConst.Api.ProductApi + "GetProductSpecHeadingByID\\" + productSpecSubHeading.SpecHeadingID).Result;
                    var responseContent = response.Content.ReadAsStringAsync().Result;
                    productSpecSubHeading.ProductSpecHeadingTitle = JsonConvert.DeserializeObject<ProductSpecHeading>(responseContent).SpecHeadingTitle;
                    productSpecSubHeading.Message = GlobalConst.Message.UpdateSucessfully;
                }
            }
            return Json(productSpecSubHeading);
        }


        [HttpPost]
        public JsonResult DeleteProductSubDesc(ProductSpecSubHeading productSpecSubHeading)
        {
            Client = WebApiHelper.Initial();
            HttpResponseMessage _requestMessage = Client.DeleteAsync(GlobalConst.Api.ProductApi + "DeleteProductSpecSubHeading\\" + productSpecSubHeading.ProductSpecSubHeadingID).Result;
            return Json("Deleted Successfully");
        }
        #endregion

        [HttpPost]
        public ActionResult AddProductInventory(Productinventory productinventory)
        {           
            Client = WebApiHelper.Initial();
            HttpResponseMessage _requestMessage = Client.PostAsJsonAsync(GlobalConst.Api.ProductApi + "AddProductInventroy\\productinventory\\", productinventory).Result;
            if (_requestMessage.IsSuccessStatusCode)
            {
                productinventory.ProductInventoryID = _requestMessage.Content.ReadAsAsync<int>().Result;
                productinventory.Message = GlobalConst.Message.AddSucessfully;
            }
            return Json(productinventory);
        }

        public ActionResult test()
        {
            return View();
        }

        public ActionResult search()
        {
            return View();
        }
    }
}