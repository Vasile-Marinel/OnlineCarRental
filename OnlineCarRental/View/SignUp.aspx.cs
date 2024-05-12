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
                string Query = "insert into CustomerTbl values('{0}','{1}','{2}','{3}')";
                Query = string.Format(Query, name, adr, phone, pass);
                Conn.SetData(Query);
                Response.Redirect("Customer/Cars.aspx");

                ErrorMsg.InnerText = "Account Created";
            }
            catch (Exception Ex)
            {

                //throw;
                ErrorMsg.InnerText = Ex.Message;
            }
        }
    }
}