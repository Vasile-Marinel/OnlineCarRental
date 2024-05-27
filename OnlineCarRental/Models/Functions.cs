using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace OnlineCarRental.Models
{
    public class Functions
    {
        private SqlConnection Conn;
        private SqlCommand cmd;
        private DataTable dt;
        private string ConnStr;
        private SqlDataAdapter sda;

        public Functions()
        {
            ConnStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\vasil\\OneDrive\\Documente\\CarRentalDbASP.mdf;Integrated Security=True;Connect Timeout=30";
            Conn = new SqlConnection(ConnStr);
            cmd = new SqlCommand();
            cmd.Connection = Conn;
        }

        //Execută o interogare SQL și returnează rezultatele într-un DataTable.
        public DataTable GetData(string Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, ConnStr);
            sda.Fill(dt);
            return dt;
        }

        //Execută o comandă SQL care modifică datele din baza de date și returnează numărul de rânduri afectate.
        public int SetData(string Query)
        {
            int rcnt = 0;
            if(Conn.State == ConnectionState.Closed)
            {
                Conn.Open();
            }
            cmd.CommandText = Query;
            rcnt = cmd.ExecuteNonQuery();
            Conn.Close();
            return rcnt;
        }
    }
}