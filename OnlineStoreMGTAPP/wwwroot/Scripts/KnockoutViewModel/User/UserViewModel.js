 function UserViewModel() {
     var self = this;
     self.Password = ko.observable();
     self.IsActive = ko.observable();

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
     $("#objpassword").change(function () {
         if (!StrongPasswordCheck($("#objpassword").val())) {
             $('#objpassword').val('');
             alertify.alert("Must be at least 8 characters, At least 1 number, 1 lowercase, 1 uppercase letter,At least 1 special character from @#$ %&");
             $('#objpassword').focus();
         }
         self.Password($("#objpassword").val());
     });

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

    $('#Password, #CPassword').on('keyup', function () {
        if ($('#Password').val() === $('#CPassword').val()) {
            $('#CPassword').css('color', 'green');
        } else
            $('#CPassword').css('color', 'red');
    });

    $("#Password").change(function () {
        if (!StrongPasswordCheck($("#Password").val())) {
            $('#Password').val('');
            alertify.alert("Must be at least 8 characters, At least 1 number, 1 lowercase, 1 uppercase letter,At least 1 special character from @#$ %&");
            $('#Password').focus();
        }
        self.Password($("#Password").val());
    });

    function StrongPasswordCheck(password) {
        var pattern = /^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%&]).*$/;
        if (pattern.test(password))
        {
            return true;
        } else
        {
            return false;
        }
     }
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
     
 $("#btnResetPassword").click(function () {
         if ($("#Password").val() === $("#CPassword").val()) {
             $.post("/User/ResetPassword", { _userID: $("#hfUserID").val(), _password: $("#Password").val(), _passwordValidateOTP: $("#hfPasswordOTP").val(), _passwordOTP: $("#PasswordOTP").val() }, function (_data) {
                 var data = $.parseJSON(_data);
                 if (data === "Yes") {
                     alert('Password Changed Successfully.');
                     window.location = "/Home/";
                 }
                 else if (data === "No") {
                     alert('User does not exist.');
                     return false;
                 }
                 else if (data === "Matched") {
                     alert('Old Password and New Password cannot be same.');
                     $("#Password").val('');
                     $("#Cpassword").val('');
                     $("#PasswordOTP").val('');
                     return false;
                 }
                 else {
                     alert('Enter OTP did not match. Please try again.');
                     return false;
                 }
             });
         }
         else {
             alert('Passwords did not match. Please try again.');
             return false;
         }
     });
}
ko.applyBindings(new UserViewModel);