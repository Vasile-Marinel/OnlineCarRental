﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineCarRental.View.Admin
{
    public partial class Rents : System.Web.UI.Page
    {
        Models.Functions Conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            Conn = new Models.Functions();
            ShowRents();
        }
        //Am adaugat aceasta metoda pentru a rezolva eroarea pe care o primim la afisarea masinilor
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        private void ShowRents()
        {
            string Query = "select * from RentTbl";
            RentList.DataSource = Conn.GetData(Query);
            RentList.DataBind();
        }

        private void ReturnCar()
        {
            try
            {                
                    string Query = "Delete from RentTbl where RentId={0}";
                    Query = string.Format(Query, RentList.SelectedRow.Cells[1].Text);
                    Conn.SetData(Query);
            }
            catch (Exception Ex)
            {

                //throw;
               // ErrorMsg.InnerText = Ex.Message;
            }
        }

        string LicensePlate;
        protected void RentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LicensePlate = RentList.SelectedRow.Cells[1].Text;
        }

        private void UpdateCar()
        {
            try
            {
                string Status = "Available";
                string Query = "update CarTbl set Status = '{0}' where CplateNum = '{1}'";
                Query = string.Format(Query, Status, RentList.SelectedRow.Cells[2].Text);
                Conn.SetData(Query);
                //ShowRents();

            }
            catch (Exception Ex)
            {

                //throw;
                InfoMsg.InnerText = Ex.Message;
            }
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (RentList.SelectedRow.Cells[1].Text == "")
                {
                    InfoMsg.InnerText = "Select a Rental Car";
                }
                else
                {

                    string Query = "insert into ReturnTbl values('{0}',{1},'{2}',{3},{4})";
                    Query = string.Format(Query, RentList.SelectedRow.Cells[2].Text, RentList.SelectedRow.Cells[3].Text, System.DateTime.Today.Date.ToString(), DelayTb.Value, FineTb.Value);
                    Conn.SetData(Query);
                    UpdateCar();
                    ReturnCar();
                    ShowRents();

                    InfoMsg.InnerText = "Car Returned";
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