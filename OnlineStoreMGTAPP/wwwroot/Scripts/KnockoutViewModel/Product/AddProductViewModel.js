function AddProductViewModel() {
    
    var self = this;
    self.CategoryID = ko.observable();
    self.CategoryName = ko.observable();
    self.SubCategoryID = ko.observable();
    self.SubCategoryName = ko.observable();
    self.CategoryData = ko.observableArray();
    self.SubCategoryData = ko.observableArray();
    self.SubCategories = ko.observableArray();
    self.SubCategories = ko.observableArray([self.SubCategories(0)]);
    self.SelectedSubCategory = ko.observable(0);
    self.AllCategories = ko.observableArray();
    self.AllCategories = ko.observableArray([self.AllCategories(0)]);
    self.selectedCategory = ko.observable(0);
    self.AddProductAllCatregory = ko.observableArray();
    self.AddProductAllCatregory = ko.observableArray([self.AddProductAllCatregory(0)]);
    self.selectedAddProductAllCatregory = ko.observable(0);    
    self.Title = ko.observable();
    self.selectedProduct = ko.observable(0);
    ////////Product Model////////////////////////////////////
    self.Title = ko.observable();
    self.MRP = ko.observable();
    self.Price = ko.observable();
    self.Description = ko.observable();
    self.SpecificationDetailID = ko.observable();
    //////////////////////////////////////////////////////////
    self.TitleHead = ko.observable();
    self.SubHead = ko.observable();
    self.SubHeadDescritption = ko.observable();
    self.ProductHeadingSubDescData = ko.observableArray();
    self.ProductSpecSubHeadingID = ko.observable();
    //////////////////////////////////////////////////////////
    self.searchCategoryName = ko.observable();
    self.searchSubCategoryName = ko.observable();
    ////////////////Product Description ///////////////////////
    self.AllSpecHeadingDropDown = ko.observableArray();
    self.AllSpecHeadingDropDown = ko.observableArray([self.AllSpecHeadingDropDown(0)]);  
    self.selectedHeading = ko.observable(0);
    self.ProductHeadingData = ko.observableArray();
    self.SpecHeadingTitle = ko.observable();
    self.ProductID = ko.observable();
    self.HeadingName = ko.observable();
    self.SubHeading = ko.observable();
    self.SubHeadingDescritption = ko.observable();
    self.SpecHeadingID = ko.observable();
    self.ProductSpecHeadingTitle = ko.observable();
    //////////////StockStatus/////////////////////////////
    self.StockStatUsID = ko.observable();
    self.StatusName = ko.observable();
    self.AllStatus = ko.observableArray();
    self.AllStatus = ko.observableArray([self.AllStatus(0)]);
    self.selectedStatus = ko.observable(0);
    /////////////////UnitMeasurement///////////////////////////////
    self.MeasurementUnitID = ko.observable();
    self.MeasurementUnitName = ko.observable();
    self.AllMeasurementUnit = ko.observableArray();
    self.AllMeasurementUnit = ko.observableArray([self.AllMeasurementUnit(0)]);
    self.selectedMeasurementUnit = ko.observable(0);
    //////////////////Productinventory///////////////////////////////
    self.SKU = ko.observable();
    self.IsManageStock = ko.observable();


    $(function () {       
        GetAllCategory();      
        GetAllSpecHeadingDropDown();
        GetAllStatus();
        GetAllUnitMeasurement();
        //$('#objCategoryName').autocomplete({
        //    source: '/Product/GetCategoriesLikeCategoryName'
        //});
       });
    function check() {
        window.location="/User/AddUser";
    }
   
    self.AddProductDetailSuccess = function () {
    };

    ProductInfoFormBeforeSubmit = function () {
        self.Productphoto = ko.observableArray();
        var _productDetails = {
            Title: $("#txtTitle").val(),
            MRP: $("#txtMRP").val(),
            Price: $("#txtPrice").val(),
            CategoryID: $("#ddCategoryID").val(),
            SubCategoryID: $("#ddsubCategoryID").val(),
            Description: $("#taDescription").val()
        };
        $.post("/Product/AddProduct",
            { product: _productDetails },
            function (model) {                
                var file = "";                
                var xhr = new XMLHttpRequest();
                var fd = new FormData();
                var photoFile;
                var photoName;
                var arr = $('#cropList > div').map(function () {
                    return this.id;
                }).get();
                for (var i = 0; i < arr.length; i++) {
                    var pid = "#photo" + (arr[i].substring(3, arr[i].length));
                    if ($(pid).attr('src').length > 0) {
                        photoFile = $(pid).attr('src');
                        photoName = $("#label" + (arr[i].substring(3, arr[i].length))).text();
                        var photoFiles = "{photoFile:'" + photoFile + "'}";
                        var photoNames = "{photoName:'" + photoName + "'}";                      
                        $.post("/Product/UploadProductPhotos",
                            {
                                photoFiles: photoFile, photoNames: photoName, id: model.productID
                            });
                    }
                }
                $("#main").scrollTop(0);
                alertify.success("Product Added Successfully");
                $("#hdproductID").val(model.productID);
                $("#file").closest('form').trigger('reset');
                $(".imageBox").css("background", "");
                $('#divheadings').removeAttr('hidden');               
            });
    };

    $("#objupload").click(function () {
         $("#EditorModal1").css("display", "block");
         $("#EditorModal1").addClass("in");
    });
    //****************************Image  Crop Popup Code Starts here***********************************************************************//
    function checkImageExtension(fileExtension) {
        if (fileExtension === "jpg" || fileExtension === "png" || fileExtension === "tiff") {
            return true;
        }
        else {
            return false;
        }
    }
   
    var imgCount;
    var cropper;
    var cropperEdit;  
        $("#file").click(function () {       
        document.querySelector('#file').addEventListener('change', function () {    
            var fileExtension = $(this).val().split('.')[$(this).val().split('.').length - 1].toLowerCase();
            var _URL = window.URL || window.webkitURL;
            var file, img;
            if (checkImageExtension(fileExtension)) {
                if (document.getElementById("file").files[0].size <= 8000000) {
                    file = this.files[0];
                    img = new Image();
                    img.onload = function (e) {
                        if (this.width === 522 && this.height === 348) {// file file has exact same dimensions

                            if (!imgCount) {
                                imgCount = 1;
                            }
                            else {
                                imgCount += 1;
                            }

                            if ($("#cropList > div").length >= 4) {
                                $('#btnCrop').prop('disabled', true);
                                $('#file').prop('disabled', true);
                            }

                            //------- converting image to bytes data -------//
                            var canvas = document.createElement("canvas");
                            var img1 = document.createElement("img");

                            img1.setAttribute('src', img.src);
                            canvas.width = img1.width;
                            canvas.height = img1.height;
                            var ctx = canvas.getContext("2d");
                            ctx.drawImage(img1, 0, 0);
                            var imageSource = canvas.toDataURL("image/jpg");
                            //-----------------------------//
                            document.querySelector('#cropList').innerHTML += '<div id="div' + imgCount + '" class="cropImage-outer-div"><img name="NewsPhotoFile" id="photo' + imgCount + '" src="' + imageSource + '" class="croppedImage"><span><img src="/Content/imgs/trash.png" class="remove-icon" onclick="javascript:removePhoto(' + imgCount + ')"></span><label style="display:none;" id="label' + imgCount + '">' + document.getElementById('file').value.substring(0, 10) + imgCount + '.jpg</label></div>';
                        }
                        else if (this.width > 522 && this.height > 348) { // when file dimensions are larger
                            var options =
                            {
                                imageBox: '.imageBox',
                                thumbBox: '.thumbBox',
                                spinner: '.spinner'
                            };
                            var reader = new FileReader();
                            reader.onload = function (e) {
                                options.imgSrc = e.target.result;
                                cropper = new cropbox(options);
                            };
                            reader.readAsDataURL(file);
                            this.files = [];
                        }
                        else {
                            alertify.alert("Image dimensions should be equal to or more than 522(width) X 348(height)");
                        }
                    };
                    img.src = _URL.createObjectURL(this.files[0]);
                }
                else {
                    alertify.alert("File size exceeded maximum limit (8 MB).");
                }
            }
            else {
                alertify.alert("File Invalid");
            }
        });
        // On edit popup file change
        document.querySelector('#file1').addEventListener('change', function () {
            var fileExtension = $(this).val().split('.')[$(this).val().split('.').length - 1].toLowerCase();
            var _URL = window.URL || window.webkitURL;
            var file, img;
            if (checkImageExtension(fileExtension)) {
                if (document.getElementById("file1").files[0].size <= 8000000) {
                    file = this.files[0];
                    img = new Image();
                    img.onload = function (e) {
                        if (this.width === 522 && this.height === 348) {// file file has exact same dimensions
                            if (!imgCount) {
                                imgCount = 1;
                            }
                            else {
                                imgCount += 1;
                            }
                            if ($("#savedImageList > li").length + $("#cropList1 > div").length >= 4) {
                                $('#btnCrop1').prop('disabled', true);
                                $('#file1').prop('disabled', true);
                            }

                            //------- converting image to bytes data -------//
                            var canvas = document.createElement("canvas");
                            var img1 = document.createElement("img");

                            img1.setAttribute('src', img.src);
                            canvas.width = img1.width;
                            canvas.height = img1.height;
                            var ctx = canvas.getContext("2d");
                            ctx.drawImage(img1, 0, 0);
                            var imageSource = canvas.toDataURL("image/jpg");
                            //-----------------------------//
                            document.querySelector('#cropList1').innerHTML += '<div id="div' + imgCount + '" class="cropImage-outer-div"><img name="NewsPhotoFile" id="photo' + imgCount + '" src="' + imageSource + '" class="croppedImage"><span><img src="/Content/imgs/trash.png" class="remove-icon" onclick="javascript:removePhotoEdit(' + imgCount + ')"></span><label style="display:none;" id="label' + imgCount + '">' + document.getElementById('file').value.substring(0, 10) + imgCount + '.jpg</label> </div>';
                        }
                        else if (this.width > 522 && this.height > 348) { // when file dimensions are larger
                            var options =
                            {
                                imageBox: '#imageBox',
                                thumbBox: '#thumbBox',
                                spinner: '#spinner'
                            };
                            var reader = new FileReader();
                            reader.onload = function (e) {
                                options.imgSrc = e.target.result;
                                cropperEdit = new cropbox(options);
                            };
                            reader.readAsDataURL(file);
                            this.files = [];
                        }
                        else {
                            alertify.alert("Image dimensions should be equal to or more than 522(width) X 348(height)");
                        }
                    };
                    img.src = _URL.createObjectURL(this.files[0]);
                }
                else {
                    alertify.alert("File size exceeded maximum limit (8 MB).");
                }
            }
            else {
                alertify.alert("File Invalid");
            }
        });
       
        // file button click in edit photo popup
        $('#myModalPhoto').on('shown.bs.modal', function () {
            checkPhotoLimit();
        });
        //crop button on edit photos popup functionality
        document.querySelector('#btnCrop1').addEventListener('click', function () {
            if ($("#imageBox").css("background-image") !== 'none') {
                var img = cropperEdit.getDataURL();
                if (!imgCount) {
                    imgCount = 1;
                }
                else {
                    imgCount += 1;
                }
                if ($("#savedImageList > li").length + $("#cropList1 > div").length >= 4) {
                    $('#btnCrop1').prop('disabled', true);
                    $('#file1').prop('disabled', true);
                }
                document.querySelector('#cropList1').innerHTML += '<div id="div' + imgCount + '" class="cropImage-outer-div"><img name="NewsPhotoFile" id="photo' + imgCount + '" src="' + img + '" class="croppedImage"><span><img src="/Content/imgs/trash.png" class="remove-icon" onclick="javascript:removePhotoEdit(' + imgCount + ')"></span><label style="display:none;" id="label' + imgCount + '">' + document.getElementById('file').value.substring(0, 10) + imgCount + '.jpg</label> </div>';
            }
        });
        document.querySelector('#btnZoomIn1').addEventListener('click', function () {
            cropperEdit.zoomIn();
        });
        document.querySelector('#btnZoomOut1').addEventListener('click', function () {
            cropperEdit.zoomOut();
        });
        
    });
    //************************************************ Add Photos Methods Starts***********************************//
    document.querySelector('#btnZoomIn').addEventListener('click', function () {
        cropper.zoomIn();
    });

    document.querySelector('#btnZoomOut').addEventListener('click', function () {
        cropper.zoomOut();
    });

    document.querySelector('#btnCrop').addEventListener('click', function () {
        if ($(".imageBox").css("background-image") !== 'none') {
            var img = cropper.getDataURL();
            if (!imgCount) {
                imgCount = 1;
            }
            else {
                imgCount += 1;
            }
            if ($("#cropList > div").length >= 4) {
                $('#btnCrop').prop('disabled', true);
                $('#file').prop('disabled', true);
            }
            document.querySelector('#cropList').innerHTML += '<div id="div' + imgCount + '" class="cropImage-outer-div"><img name="NewsPhotoFile" id="photo' + imgCount + '" src="' + img + '" class="croppedImage"><span><img src="/Content/imgs/trash.png" class="remove-icon" onclick="javascript:removePhoto(' + imgCount + ')"></span><label style="display:none;" id="label' + imgCount + '">' + document.getElementById('file').value.substring(0, 10) + imgCount + '.jpg</label></div>';
        }
    });
    //*****************************END*********************************//    


    $("#btnContinueAddPhoto").click(function () {
        if ($('#cropList > div').length > 0) {
            $('.EditorModal1').modal('hide');
            $(".EditorModal1").css("display", "none");
            $(".EditorModal1").removeClass("in");
            $("#inner-content").removeClass("modal-open");
            $(".modal-backdrop").remove();
        }
        else {
            alertify.alert("No image available to upload.");
        }
    });
    $('#btnCloseAddPhoto').click(function () {
        if ($("#cropList").has("div").length !== 0) {
            alertify.confirm("Are you sure want to remove the cropped image?", function (e) {
                if (e) {
                    removeAddPopupContent();
                }
            });
        }
        else {
            removeAddPopupContent();
        }
    });
    // to clear add photo popup content
    function removeAddPopupContent() {
        $("#cropList").empty();
        $('.EditorModal').modal('hide');
        $(".EditorModal").css("display", "none");
        $(".EditorModal").removeClass("in");
        $("#inner-content").removeClass("modal-open");
        $(".modal-backdrop").remove();      
    }

    //****************************Image Popup Crop Code Ends ***********************************************************************//
    //****************************Category Section***********************************************************************//
    self.SaveCategory = function () {     
        var _CategoryDetails = {
            CategoryName: $("#objCategoryName").val(),
            CategoryID :$("#objCategoryID").val()
        };
        $.post("/Product/AddCategory", {
            category: _CategoryDetails
        }, function (_data) {
            var NewData = _data;
            var data = self.CategoryData;
            if (NewData.message === "Add Sucessfully.") {
                self.CategoryData.push(new InsertCategoryItem(NewData.categoryName, NewData.categoryID));
                alertify.success("Data Insert Successfully");
            }
            else {
                for (var i = 0; i <= data().length - 1; i++) {
                    if (data()[i].CategoryID() === NewData.categoryID) {
                        self.CategoryData.splice(i, 1);
                        self.CategoryData.splice(i, 0, new InsertCategoryItem(NewData.categoryName, NewData.categoryID));
                        alertify.success("Data Updated Successfully");
                        break;
                    }
                }
            }
        });
        ResetControls();
    };

    function InsertCategoryItem(_categoryName, _categoryID) {
        var self = this;
        self.CategoryName = ko.observable(_categoryName);
        self.CategoryID = ko.observable(_categoryID);
    }

    function ResetControls() {
        $('#objCategoryName').val("");
        $('#objCategoryID').val("");
        self.CategoryID("");
    }

    self.DeleteCategory = function (itemToDelete) {
        alertify.confirm("Are you sure want to delete this?", function (e) {
            if (e) {
                $.post("/Product/DeleteCategory", {
                    subCategory: itemToDelete
                }, function (_data) {
                    self.CategoryData.remove(function (item) { return item.CategoryID === itemToDelete.CategoryID });
                    alertify.success(data);
                });
            }
        });
    };

    self.EditCategory = function (config) {
        $("#objCategoryName").val(config.CategoryName());       
        $("#objCategoryID").val(config.CategoryID());
        $(window).scrollTop(0);
    };



    //$("#objCategoryName").change(function () {
    //    alert("Hello");
    //});


    //$("#objCategoryName").on(function () {
    //    alert('I am pretty sure the text box changed');
    //});
    //self.GetCategories = function () {
    //    alert("hello");
    //    //$('#objCategoryName').autocomplete({
    //    //    $:post("/Product/GetCategoriesLikeCategoryName", {
    //    //        searchText: $('#objCategoryName').val()
    //    //    })
    //    //});
    //};

    //************************************End Category *********************************************************************//

    //****************************Sub Category Section***********************************************************************//

    function GetAllCategory() { // also used for Add Product Page category Dropdown
        $.ajax({
            url: "/Common/GetCategoryAll",
            cache: false,
            type: "POST", dataType: 'json',
            contentType: 'application/json',
            success: function (model) {
                self.AllCategories.removeAll();
                self.AllCategories(model.slice());
                self.AddProductAllCatregory.removeAll();
                self.AddProductAllCatregory(model.slice());               
            },
            error: function (data) {
                alertify.alert("Error while updating a item - " + data);
            }
        });
    }

    self.GetSubCategoryByID = function () {
        if (self.selectedAddProductAllCatregory() !== undefined)
            $.post("/Common/GetSubCategoryByCategoryID", {
                categoryID: self.selectedAddProductAllCatregory()
            }, function (_data) {
                self.SubCategories.removeAll();
                self.SubCategories(_data.slice());
            });
        self.SubCategories.removeAll();   
    };
  
    self.SaveSubCategory = function () {
        var _subCategoryDetails = {
            SubCategoryName: $("#subCategoryName").val(),
            CategoryID: $("#CategoryID").val(),
            SubCategoryID: $("#objSubCategoryID").val()
        };
        $.post("/Product/AddSubCategory", {
            subCategory: _subCategoryDetails 
        }, function (_data) {
            var NewData = _data;
            var data = self.SubCategoryData;
            if (NewData.message === "Add Sucessfully.") {
                self.SubCategoryData.push(new InsertSubCategoryItem(NewData.subCategoryName, NewData.categoryID, NewData.categoryName, NewData.subCategoryID));
                alertify.success("Data Insert Successfully");
            }
            else {
                for (var i = 0; i <= data().length - 1; i++) {
                    if (data()[i].SubCategoriesID() === NewData.subCategoriesID) {
                        self.SubCategoryData.splice(i, 1);
                        self.SubCategoryData.splice(i, 0, new InsertSubCategoryItem(NewData.subCategoryName, NewData.categoryID, NewData.categoryName, NewData.subCategoryID));
                        alertify.success("Data Updated Successfully");
                        break;
                    }
                }
            }
        });
        ResetSubControls();
    };

    self.EditSubCategory = function (config) {       
        $("#subCategoryName").val(config.SubName());
        $("#CategoryID").val(config.CategoryID());
        $("#objSubCategoryID").val(config.SubCategoriesID());
        $(window).scrollTop(0);
    };

    function InsertSubCategoryItem(_subCategoryName, _categoryID, _categoryName, _subCategoryID) {
        var self = this;
        self.SubCategoryName = ko.observable(_subCategoryName);
        self.CategoryID = ko.observable(_categoryID);
        self.CategoryName = ko.observable(_categoryName);
        self.subCategoryID = ko.observable(_subCategoryID);         
    }

    function ResetSubControls() {
        $('#subCategoryName').val("");
        self.CategoryID("");
        $('#CategoryID').prop('selectedIndex', 0);
        $('#objSubCategoryID').val("");
    }

    self.DeleteSubCategory = function (itemToDelete) {
        alertify.confirm("Are you sure want to delete this?", function (e) {
            if (e) {
                $.post("/Product/DeleteSubCategory", {
                    subCategory: itemToDelete
                }, function (_data) {
                    self.SubCategoryData.remove(function (item) { return item.subCategoryID === itemToDelete.subCategoryID });
                        alertify.success(_data);
                });
            }
        });
    };

     //************************************End Sub Category*********************************************************//

    //**************************************Product Description and Sub Description*******************************************************//
       

    function GetAllSpecHeadingDropDown() {
        $.ajax({
            url: "/Common/GetAllSpecHeading",
            cache: false,
            type: "POST", dataType: 'json',
            contentType: 'application/json',
            success: function (model) {
                self.AllSpecHeadingDropDown.removeAll();
                self.AllSpecHeadingDropDown(model.slice());
            },
            error: function (data) {
                alertify.alert("Error while updating a item - " + data);
            }
        });
    }

    self.SaveProductDescription = function () {   

        if ($("#txtSpecHeadingTitle").val() === "")
        {
            alertify.alert("Heading Cannot be empty.");
            return false;
        }
        else
        {
            var _Details = {
                SpecHeadingTitle: $("#txtSpecHeadingTitle").val(),
                ProductID: $("#hdproductID").val(),
                SpecHeadingID: $("#hdSpecHeadingID").val()
            };
            $.post("/Product/AddProductdescrption", {
                productSpecHeading: _Details
            }, function (_data) {
                var NewData = _data;
                var data = self.ProductHeadingData;
                if (NewData.message === "Add Sucessfully.") {
                    self.ProductHeadingData.push(new InsertSpecHeadingItem(NewData.specHeadingTitle, NewData.specHeadingID));
                    $("#objSpecHeadingID").val(NewData.specHeadingID);
                    alertify.success("Data Insert Successfully");
                }
                else {
                    for (var i = 0; i <= data().length - 1; i++) {
                        if (data()[i].SpecHeadingID() === NewData.specHeadingID) {
                            self.ProductHeadingData.splice(i, 1);
                            self.ProductHeadingData.splice(i, 0, new InsertSpecHeadingItem(NewData.specHeadingTitle, NewData.specHeadingID));
                            alertify.success("Data Updated Successfully");
                            break;
                        }
                    }
                }              
                GetAllSpecHeadingDropDown();
            });     
        }         
        ResetProductDescriptionControlls();
    };

    function InsertSpecHeadingItem(_specHeadingTitle, _specHeadingID) {
        var self = this;
        self.SpecHeadingTitle = ko.observable(_specHeadingTitle);
        self.SpecHeadingID = ko.observable(_specHeadingID);
    }

    self.EditSpecHeading = function (config) {
        $("#txtSpecHeadingTitle").val(config.SpecHeadingTitle());
        $("#hdSpecHeadingID").val(config.SpecHeadingID());
        $(window).scrollTop(0);
    };

    function ResetProductDescriptionControlls() {
        $("#txtSpecHeadingTitle").val("");       
    }

    self.DeleteSpecHeading = function (itemToDelete) {
        alertify.confirm("Are you sure want to delete this?", function (e) {
            if (e) {
                $.post("/Product/DeleteProductSpecHeading", {
                    productSpecHeading: itemToDelete
                }, function (_data) {
                    self.ProductHeadingData.remove(function (item) { return item.SpecHeadingID === itemToDelete.SpecHeadingID });
                    alertify.success(_data);
                });
            }
        });
    };

    self.SaveProductDescriptionSubHeading = function () {  
        if ($("#txtSubHeading").val() === "") {
            alertify.alert("SubHeading Cannot be empty.");
            return false;
        }
        else if ($("#txtSubHeadingDescritption").val() === "") {
            alertify.alert("SubHeadingDescritption Cannot be empty.");
            return false;
        }
        else
        {
            var _Details = {
                SubHeading: $("#txtSubHeading").val(),
                SubHeadingDescritption: $("#txtSubHeadingDescritption").val(),
                SpecHeadingID: $("#hdSpecHeadingID").val(),
                ProductSpecSubHeadingID: $("#hdProductSpecSubHeadingID").val()
            };
            $.post("/Product/AddProductdescrptionSub", {
                productSpecSubHeading: _Details
            }, function (_data) {
                var NewData = _data;
                var data = self.ProductHeadingSubDescData;
                if (NewData.message === "Add Sucessfully.") {
                    self.ProductHeadingSubDescData.push(new InsertSubDescItem(NewData.subHeading, NewData.productSpecSubHeadingID, NewData.subHeadingDescritption, NewData.productSpecHeadingTitle, NewData.specHeadingID));
                    alertify.success("Data Insert Successfully");
                }
                else {
                    for (var i = 0; i <= data().length - 1; i++) {
                        if (data()[i].ProductSpecSubHeadingID() === NewData.productSpecSubHeadingID) {
                            self.ProductHeadingSubDescData.splice(i, 1);
                            self.ProductHeadingSubDescData.splice(i, 0, new InsertSubDescItem(NewData.subHeading, NewData.productSpecSubHeadingID, NewData.subHeadingDescritption, NewData.productSpecHeadingTitle, NewData.specHeadingID));
                            alertify.success("Data Updated Successfully");
                            break;
                        }
                    }
                }                 
            });
            ResetSubControlls();
        }       
    };

    function InsertSubDescItem(_subHeading, _productSpecSubHeadingID, _subHeadingDescritption, _productSpecHeadingTitle,_specHeadingID) {
        var self = this;
        self.SubHeading = ko.observable(_subHeading);
        self.ProductSpecSubHeadingID = ko.observable(_productSpecSubHeadingID);
        self.SubHeadingDescritption = ko.observable(_subHeadingDescritption);
        self.ProductSpecHeadingTitle = ko.observable(_productSpecHeadingTitle);
        self.SpecHeadingID = ko.observable(_specHeadingID);
    }

    self.EditSubDescItem = function (config) {
        $("#txtSubHeading").val(config.SubHeading());
        $("#hdSpecHeadingID").val(config.SpecHeadingID());
        $("#txtSubHeadingDescritption").val(config.SubHeadingDescritption());        
        $("#hdProductSpecSubHeadingID").val(config.ProductSpecSubHeadingID());
        $(window).scrollTop(0);
    }; 

    self.DeleteSubDesc = function (itemToDelete) {
        alertify.confirm("Are you sure want to delete this?", function (e) {
            if (e) {
                $.post("/Product/DeleteProductSubDesc", {
                    productSpecSubHeading: itemToDelete
                }, function (_data) {
                    self.ProductHeadingSubDescData.remove(function (item) { return item.ProductSpecSubHeadingID === itemToDelete.ProductSpecSubHeadingID });
                    alertify.success(_data);
                });
            }
        });
    };

    function ResetSubControlls() {
        $("#txtSubHeading").val("");
        $("#txtSubHeadingDescritption").val("");
        $("#hdSpecHeadingID").val("");
        $("#txtSpecHeadingTitle").val("");   
        $("#hdProductSpecSubHeadingID").val("");
    }
    //***********************************************END****************************************************************//

    /////*****************************************Product Inventory *******************************************************//

    function GetAllStatus() { // also used for Add Product Page category Dropdown
        $.ajax({
            url: "/Common/GetStatusAll",
            cache: false,
            type: "POST", dataType: 'json',
            contentType: 'application/json',
            success: function (model) {
                self.AllStatus.removeAll();
                self.AllStatus(model.slice());               
            },
            error: function (data) {
                alertify.alert("Error while updating a item - " + data);
            }
        });
    }

    function GetAllUnitMeasurement() { // also used for Add Product Page category Dropdown
        $.ajax({
            url: "/Common/GetAllUnitMeasurement",
            cache: false,
            type: "POST", dataType: 'json',
            contentType: 'application/json',
            success: function (model) {
                self.AllMeasurementUnit.removeAll();
                self.AllMeasurementUnit(model.slice());
            },
            error: function (data) {
                alertify.alert("Error while updating a item - " + data);
            }
        });
    }

    

    self.SaveProductInventory = function () {
        var chkvalue;
        var isChecked = $("#chkIsManage").is(":checked");
        if (isChecked) {
            chkvalue = true;
        } else {
            chkvalue = false;
        }         
        var _ProductInventoryDetails = {
            SKU: $("#txtSKU").val(),
            IsManageStock: chkvalue,
            StockStatUsID: $("#ddStockStatusID").val(),
            MeasurementUnitID: $("#ddMeasurementUnitID").val(),
            ProductID: $("#hdproductID").val()
        };
        $.post("/Product/AddProductInventory", {
            productinventory: _ProductInventoryDetails
        }, function (_data) {            
            if (_data.message === "Add Sucessfully.") {
                alertify.alert(_data.message);
            }            
            });
        ResetProductinventroyControlls();
    };

    function ResetProductinventroyControlls() {
        $("#txtSKU").val("");
        $("#ddStockStatusID").val("");
        $("#ddMeasurementUnitID").val("");       
        $('#chkIsManage').prop('checked', false); 
    }
    //***************************************************END*****************************************************************//

}

ko.applyBindings(new AddProductViewModel);


function removePhoto(i) {
    $("#div" + i).hide('slow', function () { $("#div" + i).remove(); });
    enableFileButtonAdd();
}
function removePhotoEdit(i) {
    $("#div" + i).hide('slow', function () { $("#div" + i).remove(); });
    enableFileButtonEdit();
}
function enableFileButtonAdd() {
    $('#btnCrop').prop('disabled', false);
    $('#file').prop('disabled', false);
}
function enableFileButtonEdit() {
    $('#btnCrop1').prop('disabled', false);
    $('#file1').prop('disabled', false);
}