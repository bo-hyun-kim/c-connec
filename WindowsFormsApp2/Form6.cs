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
    public partial class Form6 : Form
    {
        DBClass dbc = new DBClass();
        public Form6()
        {
            InitializeComponent();



        }
        private void button4_Click_2(object sender, EventArgs e)
        {
            try
            {
                dbc.DS.Clear();
                dbc.DBAdapter.Fill(dbc.DS, "reservation");
                DBGrid.DataSource = dbc.DS.Tables["reservation"].DefaultView;
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
        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void 메뉴ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                dbc.DB_ptdate(ptdate.Text);
                dbc.DBAdapter.Fill(dbc.DS, "userinfo");
                DBGrid.DataSource = dbc.DS.Tables["userinfo"].DefaultView;
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
            try
            {
                dbc.DB_date_findMember(findTrainer.Text);
                dbc.DBAdapter.Fill(dbc.DS, "managerinfo");
                DBGrid3.DataSource = dbc.DS.Tables["managerinfo"].DefaultView;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                dbc.DB_stock();
                dbc.DBAdapter.Fill(dbc.DS, "stockinfo");
                DBGrid2.DataSource = dbc.DS.Tables["stockinfo"].DefaultView;
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

        private void DBGrid3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string index = DBGrid3.Rows[e.RowIndex].Cells[0].Value.ToString();
                dbc.DB_date_all(index);
                dbc.DBAdapter.Fill(dbc.DS, "userinfo");
                DBGrid4.DataSource = dbc.DS.Tables["userinfo"].DefaultView;
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
