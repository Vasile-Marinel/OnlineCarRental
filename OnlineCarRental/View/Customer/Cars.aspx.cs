using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineCarRental.View.Customer
{
    public partial class Cars : System.Web.UI.Page
    {
        Models.Functions Conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            Conn = new Models.Functions();
            ShowCars();
            CustName.InnerText = Login.CName;
            int Customer = Login.CustId;
        }

        //Am adaugat aceasta metoda pentru a rezolva eroarea pe care o primim la afisarea masinilor
        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        private void ShowCars()
        {
            String St = "Available";
            string Query = "select * from CarTbl where Status = '"+St+"' ";
            CarList.DataSource = Conn.GetData(Query);
            CarList.DataBind();
        }

        private void UpdateCar()
        {
            try
            {
                string Status = "Booked";
                string Query = "update CarTbl set Status = '{0}' where CplateNum = '{1}'";
                Query = string.Format(Query, Status, CarList.SelectedRow.Cells[1].Text);
                Conn.SetData(Query);
                ShowCars();

            }
            catch (Exception Ex)
            {

                //throw;
                InfoMsg.InnerText = Ex.Message;
            }
        }

        protected void BookBtn_Click(object sender, EventArgs e)
        {
            TimeSpan DDays = Convert.ToDateTime(ReturnDate.Value) - DateTime.Today.Date;
            int Days = DDays.Days;
            int DPrice = Convert.ToInt32(CarList.SelectedRow.Cells[4].Text);
            int Fees = DPrice * Days;

            try
            {
                if (CarList.SelectedRow.Cells[1].Text == "")
                {
                    InfoMsg.InnerText = "Missing Information";
                }
                else
                {

                    string Query = "insert into RentTbl values('{0}',{1},'{2}','{3}',{4})";
                    Query = string.Format(Query, CarList.SelectedRow.Cells[1].Text, Login.CustId, System.DateTime.Today.Date.ToString(), ReturnDate.Value, Fees);
                    Conn.SetData(Query);
                    UpdateCar();
                    ShowCars();

                    InfoMsg.InnerText = "Car Rented";
                }
            }
            catch (Exception Ex)
            {

                //throw;
                InfoMsg.InnerText = Ex.Message;
            }
        }
    }
}