function DiscountCouponViewModel() {
    var self = this;

    self.DiscountTypeID = ko.observable();
    self.DiscountTypeName = ko.observable();
    self.AllDiscountTypes = ko.observableArray();
    self.AllDiscountTypes = ko.observableArray([self.AllDiscountTypes(0)]);
    self.selectedDiscountType = ko.observable(0);

    self.CouponID      =  ko.observable("");
    self.CouponCode    =  ko.observable("");
    self.CouponComment =  ko.observable("");
    self.IsEnable      =  ko.observable("");
    self.DiscountTypeID  =  ko.observable("");
    self.DiscountAmount  =  ko.observable("");
    self.ActiveFromDate  =  ko.observable("");   
    self.SubtotalRangeBegin  =  ko.observable("");
    self.SubtotalRangeEnd    =  ko.observable(""); 
    self.NumberOfUsers = ko.observable(""); 
    self.ActiveTillDate = ko.observable("");

    $(function () {
        GetAllDiscountType();
    });

    function GetAllDiscountType() { 
        $.ajax({
            url: "/Common/GetDiscountTypeAll",
            cache: false,
            type: "POST", dataType: 'json',
            contentType: 'application/json',
            success: function (model) {
                self.AllDiscountTypes.removeAll();
                self.AllDiscountTypes(model.slice());              
            },
            error: function (data) {
                alertify.alert("Error while updating a item - " + data);
            }
        });
    }

    self.SaveDiscountCoupon = function () {
        var chkvalue;
        var isChecked = $("#chkIsEnable").is(":checked");
        if (isChecked) {
            chkvalue = true;
        } else {
            chkvalue = false;
        }   
        var _CouponDetails = {           
            CouponCode: $("#txtCouponCode").val(),
            CouponComment: self.CouponComment(),
            IsEnable: chkvalue, 
            SubtotalRangeEnd: self.SubtotalRangeEnd(),
            DiscountTypeID: $("#ddDiscountTypeID").val(),
            DiscountAmount: self.DiscountAmount(),
            ActiveFromDate: self.ActiveFromDate(),            
            SubtotalRangeBegin: self.SubtotalRangeBegin(),
            ActiveTillDate: self.ActiveTillDate(),
            NumberOfUsers: self.NumberOfUsers()
        };
        $.post("/DiscountCoupon/AddDiscountCoupon", {
            coupon: _CouponDetails
        }, function (_data) {
            alertify.alert(_data.message);
            ResetControls();            
        });       
    };

    function ResetControls() {
        self.CouponCode("");
        self.CouponComment("");
        self.IsEnable("");
        $("#ddDiscountTypeID").val("");
        self.DiscountAmount("");
        self.ActiveFromDate("");
        self.ActiveTillDate("");
        self.SubtotalRangeBegin("");
        self.SubtotalRangeEnd("");
        self.NumberOfUsers("");
        $("#hdUserID").val("");
        $("#hdEmailID").val("");
    }

    self.selectionChanged = function (event) {  
        if ($("#ddDiscountTypeID").val() === "1")
        {    
            $('#DicountAmount').removeAttr('hidden');          
        }
    }; 

}

ko.applyBindings(new DiscountCouponViewModel);