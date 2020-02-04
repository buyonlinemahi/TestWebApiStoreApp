function IndexViewModel() {
    var self = this;


    self.AddCoupon = function () {
        window.location = '/DiscountCoupon/AddDiscountCoupon?flag=' + true ;
    };
   

}

ko.applyBindings(new IndexViewModel);