using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineCarRental.View.Admin
{
    public partial class Customers : System.Web.UI.Page
    {
        Models.Functions Conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            Conn = new Models.Functions();
            ShowCustomers();
        }

        //Am adaugat aceasta metoda pentru a rezolva eroarea pe care o primim la afisarea masinilor
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        private void ShowCustomers()
        {
            string Query = "select * from CustomerTbl";
            CustomersList.DataSource = Conn.GetData(Query);
            CustomersList.DataBind();
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustNameTb.Value == "" || PhoneTb.Value == "" || PasswordTb.Value == "" || AddTb.Value == "")
                {
                    ErrorMsg.InnerText = "Missing Information";
                }
                else
                {
                    string CustName = CustNameTb.Value;
                    string CustAdd = AddTb.Value;
                    string CustPhone = PhoneTb.Value;
                    string CustPass = PasswordTb.Value;

                    string Query = "insert into CustomerTbl values('{0}','{1}','{2}','{3}')";
                    Query = string.Format(Query, CustName, CustAdd, CustPhone, CustPass);
                    Conn.SetData(Query);
                    ShowCustomers();

                    ErrorMsg.InnerText = "Customer Added";
                }
            }
            catch (Exception Ex)
            {

                //throw;
                ErrorMsg.InnerText = Ex.Message;
            }
        }

        protected void SaveBtn_Click1(object sender, EventArgs e)
        {
            try
            {
                if (CustNameTb.Value == "" || PhoneTb.Value == "" || PasswordTb.Value == "" || AddTb.Value == "")
                {
                    ErrorMsg.InnerText = "Missing Information";
                }
                else
                {
                    string CustName = CustNameTb.Value;
                    string CustAdd = AddTb.Value;
                    string CustPhone = PhoneTb.Value;
                    string CustPass = PasswordTb.Value;

                    string Query = "insert into CustomerTbl values('{0}','{1}','{2}','{3}')";
                    Query = string.Format(Query, CustName, CustAdd, CustPhone, CustPass);
                    Conn.SetData(Query);
                    ShowCustomers();

                    ErrorMsg.InnerText = "Customer Added";
                }
            }
            catch (Exception Ex)
            {

                //throw;
                ErrorMsg.InnerText = Ex.Message;
            }
        }

        protected void CustomersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustNameTb.Value = CustomersList.SelectedRow.Cells[2].Text;
            AddTb.Value = CustomersList.SelectedRow.Cells[3].Text;
            PhoneTb.Value = CustomersList.SelectedRow.Cells[4].Text;
            PasswordTb.Value = CustomersList.SelectedRow.Cells[5].Text;
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (CustNameTb.Value == "")
                {
                    ErrorMsg.InnerText = "Missing Information";
                }
                else
                {
                    string Query = "Delete from CustomerTbl where CustId={0}";
                    Query = string.Format(Query, Convert.ToInt32(CustomersList.SelectedRow.Cells[1].Text));
                    Conn.SetData(Query);
                    ShowCustomers();

                    ErrorMsg.InnerText = "Customer Deleted";
                }
            }
            catch (Exception Ex)
            {

                //throw;
                ErrorMsg.InnerText = Ex.Message;
            }
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustNameTb.Value == "" || PhoneTb.Value == "" || PasswordTb.Value == "" || AddTb.Value == "")
                {
                    ErrorMsg.InnerText = "Missing Information";
                }
                else
                {
                    string CustName = CustNameTb.Value;
                    string CustAdd = AddTb.Value;
                    string CustPhone = PhoneTb.Value;
                    string CustPass = PasswordTb.Value;

                    string Query = "update CustomerTbl set CustName = '{0}',CustAdd = '{1}',CustPhone = '{2}',CustPassword = '{3}' where CustId = '{4}'";
                    Query = string.Format(Query, CustName, CustAdd, CustPhone, CustPass, Convert.ToInt32(CustomersList.SelectedRow.Cells[1].Text));
                    Conn.SetData(Query);
                    ShowCustomers();

                    ErrorMsg.InnerText = "Customer Edited";
                }
            }
            catch (Exception Ex)
            {

                //throw;
                ErrorMsg.InnerText = Ex.Message;
            }
        }
    }
}