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
                dbc.DBAdapter.Fill(dbc.DS, "sellmanage");
                dataGridView1.DataSource = dbc.DS.Tables["sellmanage"].DefaultView;
                dbc.DBAdapter.Fill(dbc.DS, "sellmanage");
                dataGridView2.DataSource = dbc.DS.Tables["sellmanage"].DefaultView;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}