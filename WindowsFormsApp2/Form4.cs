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
namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        string salesql;
        DBClass dbc = new DBClass();
        DataRow currRow;

        public Form4()
        {
            InitializeComponent();
            dbc.DB_Open_Sales();
            dbc.DB_ObjCreate();
            dbc.DB_Open_Sales_Access();
        }
        public void sql_execute(String sqlstr, DataSet dsstr)
        {
            dbc.DCom.CommandText = sqlstr;
            dbc.DBAdapter.SelectCommand = dbc.DCom;
            dbc.DBAdapter.Fill(dsstr, "sales");
            dsstr.Tables["sales"].Clear();
            dbc.DBAdapter.Fill(dsstr, "sales");
            int i;
            i = 0;
            while (i < dsstr.Tables["sales"].Rows.Count)
            {
                DataRow currRow = dsstr.Tables["sales"].Rows[i];
                i = i + 1;
            }
            dataGridView1.DataSource = dsstr.Tables["sales"].DefaultView;
            sales_header();
        }
        public void sales_header()
        {
            dataGridView1.Columns[0].HeaderText = "index";
            dataGridView1.Columns[1].HeaderText = "날짜";
            dataGridView1.Columns[2].HeaderText = "등록매출";
            dataGridView1.Columns[3].HeaderText = "물품매출";
            dataGridView1.Columns[4].HeaderText = "누적매출";

            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
        }
        public void sales_search(String Find, String Sort) //날짜 검색
        {
            salesql = "Select * From sales ORDER BY 날짜";//<<<<<<<<<<수정해야됨
            sql_execute(salesql, dbc.DS);
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            sales_search("", "");
            increaselist();//증감리스트
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtFind1.Text.Trim() == "")
                MessageBox.Show("날짜 미입력");
            else
                sales_search(txtFind1.Text.Trim(), "");
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            sales_search("", "");
        }

        public void sql_execute2(String sqlstr, DataSet dsstr)
        {
            dbc.DCom.CommandText = sqlstr;
            dbc.DBAdapter.SelectCommand = dbc.DCom;

            dbc.DBAdapter.Fill(dsstr, "sales_increase");
            dsstr.Tables["sales_increase"].Clear();
            dbc.DBAdapter.Fill(dsstr, "sales_increase");

            dataGridView2.DataSource = dsstr.Tables["sales_increase"].DefaultView;
            increase_header();
        }
        public void increase_header()
        {
            dataGridView2.Columns[0].HeaderText = "선택 월";
            dataGridView2.Columns[1].HeaderText = "매출";
            dataGridView2.Columns[2].HeaderText = "전달매출";
            dataGridView2.Columns[3].HeaderText = "증감수치";

            dataGridView2.Columns[0].Width = 50;
            dataGridView2.Columns[1].Width = 100;
            dataGridView2.Columns[2].Width = 100;
            dataGridView2.Columns[3].Width = 100;
        }
        public void increaselist()
        {
            salesql = "";//셀렉트 쿼리문<<<<<<<<<<<<<<<<<<<<<<
            sql_execute2(salesql, dbc.DS);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}