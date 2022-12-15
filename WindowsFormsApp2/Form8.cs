using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 윈프_과제_홀수반_김한영
{
    public partial class Form8 : Form
    {

        private String SelectedRowIndex;
        DBClass dbc = new DBClass();
        public Form8()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {


        }
        //추가
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int seq = dbc.GetSequenceValue("MANAGER_SEQ");
                string empname = managername.Text;
                string empaddr = addr.Text;
                string empemail = email.Text;

                string strConn = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                OracleConnection conn = new OracleConnection(strConn);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"INSERT INTO managerinfo(empnum,empname,empaddr,empemail) VALUES('{seq}','{empname}','{empaddr}','{empemail}') ";
                cmd.ExecuteNonQuery();
                conn.Close();
                managername.Text = "";
                addr.Text = "";
                email.Text = "";
                dbc.DB_Open_Trainer();
                dbc.DBAdapter.Fill(dbc.DS, "trainer");
                dataGridView1.DataSource = dbc.DS.Tables["trainer"].DefaultView;
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
        //수정
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {   

                string empname = managername.Text;
                string empaddr = addr.Text;
                string empemail = email.Text;
                string strConn = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                OracleConnection conn = new OracleConnection(strConn);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"update managerinfo set empname = '{empname}', empaddr= '{empaddr}', empemail= '{empemail}' where empnum = '{SelectedRowIndex}'";
                cmd.ExecuteNonQuery();
                conn.Close();
                managername.Text = "";
                addr.Text = "";
                email.Text = "";
                textBox2.Text = "";
                dbc.DB_Open_Trainer();
                dbc.DBAdapter.Fill(dbc.DS, "trainer");
                dataGridView1.DataSource = dbc.DS.Tables["trainer"].DefaultView;
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
        //삭제
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = "";
                string strConn = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                OracleConnection conn = new OracleConnection(strConn);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"delete from managerinfo where empnum = {SelectedRowIndex}";
                cmd.ExecuteNonQuery();
                conn.Close();
                managername.Text = "";
                addr.Text = "";
                email.Text = "";
                textBox2.Text = "";
                dbc.DB_Open_Trainer();
                dbc.DBAdapter.Fill(dbc.DS, "trainer");
                dataGridView1.DataSource = dbc.DS.Tables["trainer"].DefaultView;

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
        //조회
        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                textBox2.Text = "";
                dbc.DB_Open_Trainer();
                dbc.DBAdapter.Fill(dbc.DS, "trainer");
            
                dataGridView1.DataSource = dbc.DS.Tables["trainer"].DefaultView;
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {   
                SelectedRowIndex = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                
                managername.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                addr.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                email.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox2.Text = $"Index {SelectedRowIndex}";
            }
            catch (DataException DE)
            { MessageBox.Show(DE.Message); }
            catch (Exception DE)
            { MessageBox.Show(DE.Message); }
        }

    }
}
