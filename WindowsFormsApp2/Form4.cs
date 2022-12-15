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

        }
       
        private void Form4_Load(object sender, EventArgs e)
        {
 
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                dbc.DB_Open_prdSales(txtFind1.Text);
                dbc.DBAdapter.Fill(dbc.DS, "prdsales");
                dataGridView1.DataSource = dbc.DS.Tables["prdsales"].DefaultView;
                
                int prdsum = Convert.ToInt32(dbc.DS.Tables["prdsales"].Compute("Sum(총액)", ""));
                textBox1.Text = $"{prdsum}";

                dbc.DB_Open_uSales(txtFind1.Text);
                dbc.DBAdapter.Fill(dbc.DS, "usersales");
                dataGridView2.DataSource = dbc.DS.Tables["usersales"].DefaultView;

                int usersum = Convert.ToInt32(dbc.DS.Tables["usersales"].Compute("Sum(등록비)", ""));
                textBox2.Text = $"{usersum}";

                int wholesum = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
                textBox3.Text = $"{wholesum}";
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


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }   
}
