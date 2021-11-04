using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1;

namespace PatientRegistrationMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Bill_Payment()
        {
            if (Session["user_id"] == "true")
            {
                return View("Bill_Payment");
            }
            else
            {
                return View("Login");
            }


        }
        public ActionResult Login()
        {

            return View();

        }

        public ActionResult All_Patient()
        {
            return View();
        }

        public ActionResult User_Login(string un, string pass)
        {
            if (un == "user" && pass == "123")
            {
                Session["user_id"] = "true";
                return RedirectToAction("Bill_Payment");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }


        public   JsonResult INSERT_PAT_REG( string MR_NO ,  string NAME , string FATHER_NAME , string GENDER , string MOBILE , string HOME_CONTACT , string MARITAL_STATUS , string DOB , string EMAIL , string CNIC , string ADDRESS  , string CITY , string user)  
        {

            ClassBilling cls = new ClassBilling();

            cls.Mr_NO =  Convert.ToInt32( MR_NO);
            cls.Name = NAME;
            cls.Father_Name = FATHER_NAME;
            cls.Geder = GENDER;
            cls.Mobile = MOBILE;
            cls.Home_Contact = HOME_CONTACT;
            cls.Marital_Status = MARITAL_STATUS;
            cls.DOB = Convert.ToDateTime(DOB);
            cls.Email = EMAIL;
            cls.City = CITY;
            cls.CNIC = CNIC;
            cls.Address = ADDRESS;
            cls.User_ID = user;
            cls.IsActive = true;

             // cls.Update_PAT_REG(cls);





             return Json( cls.Update_PAT_REG(cls).ToString(), JsonRequestBehavior.AllowGet);
        }
        
      

        public JsonResult Insert_D(string Invoice , string MR_NO , string TEST_CODE , string QTY , string URGENT_TYPE  , string  SPECIAL_INSTRUCTION , string AMOUNT , string USER)
        {

            PatientRegistrationMVC.Models.Cls_Lab_Req cls = new Models.Cls_Lab_Req();

            cls.Invoice_No = Convert.ToInt32( Invoice);
            cls.Mr_NO = Convert.ToInt32( MR_NO);
            cls.Test_CODE = TEST_CODE;
            cls.QTY = Convert.ToInt32( QTY);
            cls.Urgent_Type = URGENT_TYPE;
            cls.Special_Instraction = SPECIAL_INSTRUCTION;
            cls.Ammount = Convert.ToInt32( AMOUNT);
            cls.User_ID = USER;
            cls.Update_REQ_DET(cls);

            return Json("", JsonRequestBehavior.AllowGet);
        }


    }
}