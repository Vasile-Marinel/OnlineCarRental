using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineCarRental.View
{
    public partial class SignUp : System.Web.UI.Page
    {
        Models.Functions Conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            Conn = new Models.Functions();
        }

        protected void ContinueBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = FullNameTb.Value;
                string adr = SignAddTb.Value.ToString();
                string phone = SignPhoneTb.Value.ToString();
                string pass = SignPassTb.Value.ToString();

                string checkQuery = "SELECT COUNT(*) FROM CustomerTbl WHERE CustName = '{0}'";
                checkQuery = string.Format(checkQuery, name);
                int count = Convert.ToInt32(Conn.GetData(checkQuery).Rows[0][0]);

                if (count > 0)
                {
                    ErrorMsg.InnerText = "Username already exists. Please choose another username.";
                }
                else
                {
                    string insertQuery = "INSERT INTO CustomerTbl VALUES('{0}','{1}','{2}','{3}')";
                    insertQuery = string.Format(insertQuery, name, adr, phone, pass);
                    Conn.SetData(insertQuery);

                    ErrorMsg.InnerText = "Account Created";
                    Response.Redirect("Customer/Cars.aspx");
                }
            }
            catch (Exception Ex)
            {
                // În caz de eroare, afișăm un mesaj de eroare
                ErrorMsg.InnerText = Ex.Message;
            }
        }
    }
}