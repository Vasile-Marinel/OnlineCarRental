using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineCarRental.View
{
    public partial class Login : System.Web.UI.Page
    {
        Models.Functions Conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            Conn = new Models.Functions();
        }
        public static string CName = "";
        public static int CustId;
        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            if (AdminRadio.Checked)
            {
                if(UserNameTb.Value == "Admin" && PasswordTb.Value == "admin1122")
                {
                    CName = "Admin";
                    Response.Redirect("Admin/Home.aspx");
                }
                else
                {
                    InfoMsg.InnerText = "Invalid Admin!";
                }
            }
            else
            {
                string sql = "select custname, custpassword, custid from customertbl where custname = '{0}' and custpassword = '{1}'";
                sql = string.Format(sql, UserNameTb.Value, PasswordTb.Value);
                DataTable dt = Conn.GetData(sql);
                if(dt.Rows.Count == 0)
                {
                    InfoMsg.InnerText = "Invalid Customer!";
                }
                else
                {
                    CName = dt.Rows[0][0].ToString();
                    CustId = Convert.ToInt32(dt.Rows[0][2].ToString());
                    Response.Redirect("Customer/Cars.aspx");
                }
            }
        }

        protected void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (CustRadio.Checked)
            {
                Response.Redirect("SignUp.aspx");
            }
            else
            {
                // Dacă utilizatorul este administrator, afișează un mesaj de eroare sau ignorați acțiunea
                InfoMsg.InnerText = "Registration is only allowed for customers.";
            }
        }
    }
}