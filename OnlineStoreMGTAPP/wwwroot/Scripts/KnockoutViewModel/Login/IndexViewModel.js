function IndexViewModel() {
    var self = this;
    self.IsActive = ko.observable();
    self.Password = ko.observable();

    self.AllUserTypes = ko.observableArray();
    self.AllUserTypes = ko.observableArray([self.AllUserTypes(0)]);
    self.userTypeID = ko.observable();

    self.UserStatus = ko.observableArray([
        { StatusName: 'Active', StatusValue: 'true' },
        { StatusName: 'Deactive', StatusValue: 'false' }
    ]);

    $(function () {
        $("#loaderDiv").hide();
        $("#phoneMaskID").inputmask({ "mask": "(999) 999-9999" });
        GetAllUserType();
    });

    function GetAllUserType() { 
        $.ajax({
            url: "/Common/GetUserTypeAll",
            cache: false,
            type: "POST", dataType: 'json',
            contentType: 'application/json',
            success: function (model) {
                self.AllUserTypes.removeAll();
                self.AllUserTypes(model.slice());
            },
            error: function (data) {
                alertify.alert("Error while updating a item - " + data);
            }
        });
    }
    $("#emailIDExists").bind("focusout", function () {
        var valueData = $("#emailIDExists").val();
        if (valueData !== "") {
            $.getJSON("/Login/UserExists", { value: valueData }, function (data) {
                if (data === "Yes") {
                    $("#messageblock").show();
                    $("#BtnAdding").attr('disabled', 'disabled');
                }
                else {
                    $("#messageblock").hide();
                    $("#BtnAdding").removeAttr('disabled');
                }              
            });
        }
    });

   

    function StrongPasswordCheck(password) {
        var pattern = /^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%&]).*$/;
        if (pattern.test(password)) {
            return true;
        } else {

            return false;
        }
    }

    $("#objpassword").change(function () {
        if (!StrongPasswordCheck($("#objpassword").val())) {
            $('#objpassword').val('');
            alertify.alert("Must be at least 8 characters, At least 1 number, 1 lowercase, 1 uppercase letter,At least 1 special character from @#$ %&");
            $('#objpassword').focus();
        }
        self.Password($("#objpassword").val());
    });

    self.forgotPassword = function () {
        $("#loaderDiv").show();
        $.post("/User/ForgotPassword", {
            _emailID: $("#EmailID").val()
        },
            function (data) {
                alertify.alert(data);

                $("#loaderDiv").hide();
            });

    };
    $('#objpassword, #objpasswordConfrim').on('keyup', function () {
        if ($('#objpassword').val() === $('#objpasswordConfrim').val()) {
            $('#objpasswordConfrim').css('color', 'green');
        } else
            $('#objpasswordConfrim').css('color', 'red');
    });

    $("#emailIDExists").change(function () {        
        var sEmail = $('#emailIDExists').val();
        if ($.trim(sEmail).length === 0) {
            alert('Please enter valid email address');
        }
        if (validateEmail(sEmail)) {
            $("#emailIDExists").val(sEmail);
        }
	    else {
            alert('Invalid Email Address');
            $("#emailIDExists").val("");
        }
    });

    function validateEmail(sEmail) {
        var filter = /^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$/;
        if (filter.test(sEmail)) {
            return true;
        }
        else {
            return false;
        }
    }
}
ko.applyBindings(new IndexViewModel);