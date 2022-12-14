using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 윈프_과제_홀수반_김한영;
using Oracle.DataAccess.Client;

namespace WindowsFormsApp2

{

    public partial class member : Form
    {
        private int SelectedRowIndex;
        private string RowIndex;

        DBClass dbc = new DBClass();


        public member()
        {
            InitializeComponent();
            dbc.DB_Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int usernum = dbc.GetSequenceValue("seq_usernum");
                string uname = username.Text;
                string uphone = userphone.Text;
                int lockernum = dbc.GetSequenceValue("seq_lockernum");
                string emnum = empnum.Text;
                string edate = enddate.Text;
                string rtype = regtype.Text;
                string rfee = regfee.Text;
                string pdate = ptdate.Text;
                string pnum = ptnum.Text;
                string rdate = regdate.Text;


                string strConn = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                OracleConnection conn = new OracleConnection(strConn);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"INSERT INTO userinfo (usernum, username, userphone, lockernum, empnum, expiredate, regtype, regfee, ptdate, ptnum, regdate ) VALUES('{usernum}','{uname}','{uphone}','{lockernum}','{emnum}' ,TO_DATE('{edate}', 'YYYY-MM-DD'), '{rtype}', '{rfee}', TO_DATE('{pdate}'), '{pnum}', TO_DATE('{rdate}')) ";
                cmd.ExecuteNonQuery();
                MessageBox.Show("추가 되었습니다!");
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string uname = username.Text;
                string uphone = userphone.Text;
                string emnum = empnum.Text;
                string edate = enddate.Text;
                string rtype = regtype.Text;
                string rfee = regfee.Text;
                string pdate = ptdate.Text;
                string pnum = ptnum.Text;
                string rdate = regdate.Text;


                string strConn = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                OracleConnection conn = new OracleConnection(strConn);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"update userinfo set username = '{uname}', userphone = '{uphone}', empnum = '{emnum}',expiredate = '{edate}', regtype = '{rtype}',regfee = '{rfee}',ptdate = '{pdate}',ptnum = '{pnum}', regdate = '{rdate}'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("수정 되었습니다!");
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string strConn = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                OracleConnection conn = new OracleConnection(strConn);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"delete from userinfo where usernum = '{RowIndex}'";
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

        private void lv1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                dbc.DB_Open();
                dbc.DBAdapter.Fill(dbc.DS, "reginfo");
                DBGrid.DataSource = dbc.DS.Tables["reginfo"].DefaultView;
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

        private void member_Load(object sender, EventArgs e)
        {
            try
            {
                dbc.DB_Open();
                dbc.DBAdapter.Fill(dbc.DS, "reginfo");
                DBGrid.DataSource = dbc.DS.Tables["reginfo"].DefaultView;
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DBGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            DialogResult result = f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.DB_Open_select(username.Text, userphone.Text);
                dbc.DBAdapter.Fill(dbc.DS, "reginfo");
                DBGrid.DataSource = dbc.DS.Tables["reginfo"].DefaultView;
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

        private void DBGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = DBGrid.Rows[e.RowIndex].Cells[0].Value.ToString();

            username.Text = DBGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            userphone.Text = DBGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            //enddate.Text
            string t  = DBGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            enddate.Text = string.Format("{0:yyyy-mm-dd}", t);
            regtype.Text = DBGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
            regfee.Text = DBGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
            ptdate.Text = DBGrid.Rows[e.RowIndex].Cells[8].Value.ToString();
            ptnum.Text = DBGrid.Rows[e.RowIndex].Cells[9].Value.ToString();
            regdate.Text = DBGrid.Rows[e.RowIndex].Cells[10].Value.ToString();
        }
    }
}

