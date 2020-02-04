namespace OnlineStore.Infrastructure.Global
{
    public class GlobalConst
    {

        public struct Api
        {
            public const string UserApi = "Api\\user\\";
            public const string ProductApi = "Api\\product\\";
            public const string Common = "Api\\common\\";
            public const string Seller = "Api\\Seller\\";
            public const string Coupon = "Api\\Coupon\\";
        }

        public struct UserController
        {
            public const string UserApi = "Api\\user\\";
        }

        public struct Controller
        {
           public const string User = "User";
           public const string Login = "Login";
           public const string Product = "Product";
           public const string SellerInformation = "SellerInformation";
           public const string Home = "Home";
        }

        public struct Actions
        {
            public struct UserController
            {
                public const string AddUser = "AddUser";
                public const string Index = "Index";
                public const string ForgotPassword = "ForgotPassword";
            }            

            public struct LoginController
            {
                public const string AddUser = "AddUser";
                public const string Index = "Index";
            }

            public struct ProductController
            {
                public const string AddProduct = "AddProduct";
            }

            public struct SellerInformationController
            {
                public const string AddSellerInformation = "AddSellerInformation";
            }

            public struct HomeController
            {
                public const string Index = "Index";
            }
        }

        public struct Message
        {
            public const string allowedLetterChars = "abcdefghijkmnpqrstuvwxyzABCDEFGHJKLMNPQRSTUVWXYZ";
            public const string allowedNumberChars = "123456789";
            public const string UserAdded = "User added Successfully.";
            public const string UserFail = "User Not Added.";
            public const string AddSucessfully = "Add Sucessfully.";
            public const string UpdateSucessfully = "Update Sucessfully.";
            public const string EmailNotExists = "Email or UserName Not Exists";
            public const string EmailSentSuccessfully = "Email Sent Successfully";
            public const string EmailSentToRegisteredEmail = "Email has been sent to the registered address";
        }

        public struct reCaptchaValidation
        {
            public const string ErrorOccuredPleasetryAgain ="Error occured. Please try again";
            public const string TheResponsParameterIsInvalidOrMalFormed ="The response parameter is invalid or malformed.";
            public const string InvalidInputResponse = "invalid-input-response";
            public const string TheResponseParameterIsMissing =  "The response parameter is missing.";
            public const string MissingInputResponse = "missing-input-response";
            public const string TheSecretParameterIsinvalidOrmalformed = "The secret parameter is invalid or malformed.";
            public const string InvalidInputSecret= "invalid-input-secret";
            public const string TheSecretParameterIsMissing= "The secret parameter is missing.";
            public const string missingInputSecret = "missing-input-secret";
            public const string formatString = "https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}";
            public const string seceretKey = "6LcUB8UUAAAAAMWGs_Z7uTj11qWTqwrOERcURFHF";
            public const string recaptchaResponse = "g-recaptcha-response";
            public const string ValidResult = "Valid";
        }

        public struct Records
        {
            public const int Skip = 0;
            public const int Take = 10;
            public const int Take15 = 15;
            public const int LandingTake = 50;
            public const int LandingTakeTest = 4;
            public const int Take5 = 5;
            public const int take500 = 500;
            public const int take5000 = 5000;
        }

        public struct ConstantChar
        {
            public const string DoubleBackSlash = @"\";
            public const char Char_C = 'C';
            public const int Zero = 0;
            public const int One = 1;
            public const char Char_R = 'R';
            public const string Colon = ":";
            public const string UnderScore = "_";
            public const string Blank = "";
            public const string Comma = ",";
            public const string Url = "http://192.168.2.150:98/";
        }

        public struct ContentTypes
        {
            public const string PDF = "application/pdf";
            public const string TextHtml = "text/html";
        }

        public struct FolderName
        {
            public const string Storage = "/Storage";
            public const string Product = "Product";

        }

    }
}
