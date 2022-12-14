﻿using System;
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
                cmd.CommandText = $"INSERT INTO userinfo (usernum, username, userphone, lockernum, empnum, expiredate, regtype, regfee, ptdate, ptnum, regdate ) VALUES('{usernum}','{uname}','{uphone}','{lockernum}','{emnum}' ,TO_DATE('{edate}'), '{rtype}', '{rfee}', TO_DATE('{pdate}'), '{pnum}', TO_DATE('{rdate}')) ";
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
            try
            {
                RowIndex = DBGrid.Rows[e.RowIndex].Cells[0].Value.ToString();

                DataTable userinfo = dbc.DS.Tables["userinfo"];
                if (e.RowIndex < 0)
                {
                    return;
 }
                else if (e.RowIndex > userinfo.Rows.Count - 1)
                {
                    MessageBox.Show("해당하는 데이터가 존재하지 않 습니다.");
                 return;
                }
                DataRow currRow = userinfo.Rows[e.RowIndex];
                username.Text = currRow["회원이름"].ToString();
                userphone.Text = currRow["전화번호"].ToString();
                enddate.Text = currRow["만기일자"].ToString();
                regtype.Text = currRow["등록종류"].ToString();
                regfee.Text = currRow["등록비"].ToString();
                ptdate.Text = currRow["PT예약일자"].ToString();
                ptnum.Text = currRow["PT횟수"].ToString();
                regdate.Text = currRow["등록일자"].ToString();
                dbc.SelectedRowIndex = Convert.ToInt32(currRow["회원번호"]);
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
    }
}

