
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Web.Script.Serialization;
//using System.Web.Services;
//using WebApplication1;


//namespace PatientRegistrationMVC
//{
//    /// <summary>
//    /// Summary description for WebService1
//    /// </summary>
//    [WebService(Namespace = "http://tempuri.org/")]
//    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
//    [System.ComponentModel.ToolboxItem(false)]
//    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
//    // [System.Web.Script.Services.ScriptService]
//    public class WebService1 : System.Web.Services.WebService
//    {

//        [WebMethod]
//        public string HelloWorld()
//        {
//            return "Hello World";
//        }



//        [WebMethod]
//        public string INSERT
//    (string MR_NO, string NAME, string FATHER_NAME, string MOBILE, string MARITAL_STATUS, string HOME_CONTACT, string GENDER, string DOB, string EMAIL, string CITY, string CNIC, string ADDRESS)
//        {

//            ClassBilling cls = new ClassBilling();

//            cls.MR_NO = MR_NO;
//            cls.NAME = NAME;
//            cls.FATHER_NAME = FATHER_NAME;
//            cls.GENDER = GENDER;
//            cls.MOBILE = MOBILE;
//            cls.HOME_CONTACT = HOME_CONTACT;
//            cls.MARITAL_STATUS = MARITAL_STATUS;
//            cls.DOB = DOB;
//            cls.EMAIL = EMAIL;
//            cls.CITY = CITY;
//            cls.CNIC = CNIC;
//            cls.ADDRESS = ADDRESS;


//            cls.INSERT();
//            return "Hello World";

//        }



//    }
//}
