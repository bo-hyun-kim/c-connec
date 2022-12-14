using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Oracle.DataAccess.Client;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.InteropServices.ComTypes;
using 윈프_과제_홀수반_김한영;
using System.Data.Common;

namespace WindowsFormsApp2
{
    public partial class Form5 : Form
    {
        private String SelectedRowIndex;
        DBClass dbc = new DBClass();
        private OracleConnection odpConn = new OracleConnection();
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                dbc.DB_Open_Product();
                dbc.DBAdapter.Fill(dbc.DS, "prdtradeinfo");
                PrdGridView.DataSource = "";
                PrdGridView.DataSource = dbc.DS.Tables["prdtradeinfo"].DefaultView;
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int seq = dbc.GetSequenceValue("PRDTRADEINFO_SEQ");
                string prdname = textBox_prdname.Text;
                string prdcnt = textBox_prdcnt.Text;
                string prdcost = textBox_prdcost.Text;
                string prddate = textBox_prddate.Text;
                string strConn= "User Id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                OracleConnection conn = new OracleConnection(strConn);

                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"INSERT INTO prdtradeinfo(prdno,prdname,prdcnt,prdcost,prddate,prdendno) VALUES('{seq}','{prdname}','{prdcnt}','{prdcost}','{prddate}','0')";
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int seq = dbc.GetSequenceValue("PRDTRADEINFO_SEQ");
                string prdname = textBox_prdname.Text;
                string prdcnt = textBox_prdcnt.Text;
                string prdcost = textBox_prdcost.Text;
                string prddate = textBox_prddate.Text;
                string strConn = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                OracleConnection conn = new OracleConnection(strConn);

                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"INSERT INTO prdtradeinfo(prdno,prdname,prdcnt,prdcost,prddate,prdendno) VALUES('{seq}','{prdname}','{prdcnt}','{prdcost}','{prddate}','1')";
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int seq = dbc.GetSequenceValue("PRDTRADEINFO_SEQ");
                string prdname = textBox_prdname.Text;
                string prdcnt = textBox_prdcnt.Text;
                string prdcost = textBox_prdcost.Text;
                string prddate = textBox_prddate.Text;
                string strConn = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                OracleConnection conn = new OracleConnection(strConn);

                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"INSERT INTO prdtradeinfo(prdno,prdname,prdcnt,prdcost,prddate,prdendno) VALUES('{seq}','{prdname}','{prdcnt}','{prdcost}','{prddate}','2')";
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            try
            {   
                string strConn = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                OracleConnection conn = new OracleConnection(strConn);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"delete from prdtradeinfo where prdno = {SelectedRowIndex}";
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }



        private void PrdGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SelectedRowIndex = PrdGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox1.Text = $"Selected {SelectedRowIndex}";
            }
            catch (DataException DE)
            { MessageBox.Show(DE.Message); }
            catch (Exception DE)
            { MessageBox.Show(DE.Message); }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {   
                dbc.DB_Open_Product();
                dbc.DBAdapter.Fill(dbc.DS, "prdtradeinfo");
                PrdGridView.DataSource = dbc.DS.Tables["prdtradeinfo"].DefaultView;
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

    }
}

