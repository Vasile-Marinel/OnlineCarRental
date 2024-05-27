using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineCarRental.View.Customer
{
    public partial class PendingRentals : System.Web.UI.Page
    {
        Models.Functions Conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            Conn = new Models.Functions();
            ShowCars();
        }
        //Am adaugat aceasta metoda pentru a rezolva eroarea pe care o primim la afisarea masinilor
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        private void ShowCars()
        {
            string Query = "select * from RentTbl where customer = " + Login.CustId + " ";
            PendingList.DataSource = Conn.GetData(Query);
            PendingList.DataBind();
        }

        private void UpdateCar()
        {
            try
            {
                string Status = "Available";
                string Query = "update CarTbl set Status = '{0}' where CplateNum = '{1}'";
                Query = string.Format(Query, Status, PendingList.SelectedRow.Cells[2].Text);
                Conn.SetData(Query);
                //ShowRents();

            }
            catch (Exception Ex)
            {

                //throw;
                InfoMsg.InnerText = Ex.Message;
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "Delete from RentTbl where RentId={0}";
                Query = string.Format(Query, PendingList.SelectedRow.Cells[1].Text);
                Conn.SetData(Query);
                UpdateCar();
                ShowCars();

                InfoMsg.InnerText = "The rental has been cancelled";
            }
            catch (Exception Ex)
            {

                //throw;
                InfoMsg.InnerText = Ex.Message;
            }
        }
    }
}