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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        DBClass dbc = new DBClass();

        public Form4()
        {
            InitializeComponent();
            dbc.DB_Open_uSales();
            dbc.DB_Open_prdSales();

        }
       
        private void Form4_Load(object sender, EventArgs e)
        {
 
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.DB_Open_prdSales();
                dbc.DBAdapter.Fill(dbc.DS, "prdsales");
                dataGridView1.DataSource = dbc.DS.Tables["prdsales"].DefaultView;

                dbc.DB_Open_uSales();
                dbc.DBAdapter.Fill(dbc.DS, "usales");
                dataGridView2.DataSource = dbc.DS.Tables["usales"].DefaultView;
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
        public void prdslaes_counter()
        {
            int i, sum = 0;
            i = dataGridView1.RowCount;
            sum = Convert.ToInt32(dbc.DS.Tables["prdsales"].Compute("Sum(prd_cost)", ""));
            label4.Text = "물품 총 매출 :" + sum + "원";
        }
   

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        }   
}
