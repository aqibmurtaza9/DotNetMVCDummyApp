using System;
using System.Data;
using System.Data.SqlClient;





namespace WebApplication1
{


    public class ClassBilling
    {

        DBBridge bd = new DBBridge();
        
        public string User_ID { get; set; }
        public string Mode { get; set; }
        public int Mr_NO { get; set; }

        public string Name { get; set; }
        public string Father_Name { get; set; }
        public string Mobile { get; set; }

        public string Marital_Status { get; set; }
        public string Home_Contact { get; set; }
        public string Geder { get; set; }
        public DateTime DOB { get; set; }

        public string Email { get; set; }

        public string City { get; set; }

        public string CNIC { get; set; }

        public string Address { get; set; }
        public bool IsActive { get; set; }
        


        public int Update_PAT_REG(ClassBilling ab)
        {
            

            try
            {

                SqlParameter[] param = new SqlParameter[15];
                param[0] = new SqlParameter("@MODE", "UPDATE");
                param[1] = new SqlParameter("@MR_NO", ab.Mr_NO);
                param[2] = new SqlParameter("@NAME", ab.Name);
                param[3] = new SqlParameter("@FATHER_NAME", ab.Father_Name);
                param[4] = new SqlParameter("@MOBILE", ab.Mobile);
                param[5] = new SqlParameter("@MARITAL_STATUS", ab.Marital_Status);
                param[6] = new SqlParameter("@HOME_CONTACT", ab.Home_Contact);
                param[7] = new SqlParameter("@GENDER", ab.Geder);
                param[8] = new SqlParameter("@DOB", ab.DOB.Date.ToString("d"));
                param[9] = new SqlParameter("@EMAIL", ab.Email);
                param[10] = new SqlParameter("@CITY", ab.City);
                param[11] = new SqlParameter("@CNIC", ab.CNIC);
                param[12] = new SqlParameter("@ADDRESS", ab.Address);
                param[13] = new SqlParameter("@WUSER_ID", ab.User_ID);
                param[14] = new SqlParameter("@IS_ACTIVE", ab.IsActive);



              //  DataSet ds = new DataSet();
              //ds =  bd.ExecuteDataset("PRO_Patient_Registration", param);

              //  int mr = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                return Convert.ToInt32( bd.ExecuteDataset("PRO_Patient_Registration", param).Tables[0].Rows[0][0]);
            }
            catch (Exception a)
            {
                
                throw;
            }




        }



     
    }
}

