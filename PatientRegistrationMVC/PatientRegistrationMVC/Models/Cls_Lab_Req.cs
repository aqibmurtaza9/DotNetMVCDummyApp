using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication1;

namespace PatientRegistrationMVC.Models
{
    public class Cls_Lab_Req
    {


        DBBridge db = new DBBridge();
        public string User_ID { get; set; }
        public string Mode { get; set; }
        public int Mr_NO { get; set; }
        public int Invoice_No { get; set; }
        public string Test_CODE { get; set; }

        public int QTY { get; set; }
        public string Urgent_Type { get; set; }
        public int Ammount { get; set; }

        public string Special_Instraction { get; set; }
        public bool IS_Active { get; set; }
        public void Update_REQ_DET(Cls_Lab_Req ab)
        {


            try
            {

                SqlParameter[] param = new SqlParameter[15];
                param[0] = new SqlParameter("@MODE", "UPDATE");
                param[1] = new SqlParameter("@INVOICE_NO", ab.Invoice_No);
                param[2] = new SqlParameter("@MR_NO", ab.Mr_NO);
                param[3] = new SqlParameter("@TEST_CODE", ab.Test_CODE);
                param[4] = new SqlParameter("@QTY", ab.QTY);
                param[5] = new SqlParameter("@URGENT_TYPE", ab.Urgent_Type);
                param[6] = new SqlParameter("@AMOUNT", ab.Ammount);
                param[7] = new SqlParameter("@SPECIAL_INSTRUCTION", ab.Special_Instraction);
                param[13] = new SqlParameter("@WUSER_ID", ab.User_ID);
                param[14] = new SqlParameter("@IS_ACTIVE", ab.IS_Active);



                db.ExecuteNonQuery("PRO_REQUEST_DETAIL", param);


            }
            catch (Exception a)
            {

                throw;
            }




        }

    }
}