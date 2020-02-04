function SellerViewModel() {
    var self = this;

    self.BusinessTitle = ko.observable("");
    self.CompanyName = ko.observable("");
    self.StreetAddress = ko.observable("");
    self.City = ko.observable("");
    self.State = ko.observable("");
    self.Country = ko.observable("");
    self.ZipCode = ko.observable("");
    self.PhoneNumber = ko.observable("");   
    self.NumberOfProducts = ko.observable("");
    self.BrandName = ko.observable("");
    self.MerchantID = ko.observable();
    self.UserID = ko.observable();
    self.EmailID = ko.observable();

    self.SaveSellerProfile = function () {
        
        if (self.BusinessTitle() === '') {
            alertify.alert("BusinessTitle can not be empty");
            return false;
        }
        else if (self.CompanyName() === "") {
            alertify.alert("CompanyName can not be empty ");
        }
        else if (self.StreetAddress() === "") {
            alertify.alert("StreetAddress can not be empty ");
        }
        else if (self.City() === "") {
            alertify.alert("City can not be empty ");
        }
        else if (self.State() === "") {
            alertify.alert("State can not be empty ");
        }
        else if (self.Country() === "") {
            alertify.alert("Country can not be empty ");
        }
        else if (self.ZipCode() === "") {
            alertify.alert("Zip can not be empty ");
        }
        else if (self.PhoneNumber() === "") {
            alertify.alert("Phone can not be empty ");
        }
        else if (self.NumberOfProducts() === "") {
            alertify.alert("NumberofProducts can not be empty ");
        }
        else if (self.BrandName() === "") {
            alertify.alert("BrandName can not be empty ");
        }
        else {
            $("#loaderDiv").attr("hidden", false);   
            var _ProfileDetails =
            {
                    BusinessTitle: self.BusinessTitle(),
                    CompanyName: self.CompanyName(),
                    StreetAddress: self.StreetAddress(),
                    City: self.City(),
                    State: self.State(),
                    Country: self.Country(),
                    ZipCode: self.ZipCode(),
                    PhoneNumber: self.PhoneNumber(),
                    NumberOfProducts: self.NumberOfProducts(),
                    BrandName: self.BrandName(),
                    UserID: $("#hdUserID").val(),
                    EmailID: $("#hdEmailID").val()
            };
            $.post("/SellerInformation/AddSellerInformation", {
                sellerProfile: _ProfileDetails
            }, function (_data) {
                alertify.alert(_data.message);
                ResetControls();
                $("#loaderDiv").attr("hidden", true); 
            });
        }
    };

    function ResetControls() {
        self.BusinessTitle("");
        self.CompanyName("");
        self.StreetAddress("");
        self.City("");
        self.State("");
        self.Country("");
        self.ZipCode("");
        self.PhoneNumber("");
        self.NumberOfProducts("");
        self.BrandName();
        $("#hdUserID").val("");
        $("#hdEmailID").val("");
    }

}

ko.applyBindings(new SellerViewModel);



















