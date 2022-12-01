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
    public partial class Form4: Form
    {

        DBClass dbc = new DBClass();
        Random rand = new Random();
        public Form4()
        {
            InitializeComponent();
            dbc.DB_Open_Sales();
            dbc.DB_ObjCreate();
        }


        private void Form4_Load(object sender, EventArgs e)
        {

            try
            {
                dbc.DBAdapter.Fill(dbc.DS, "sales");
                SalesGridView.DataSource = dbc.DS.Tables["sales"].DefaultView;
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
                dbc.DS.Clear();
                dbc.DBAdapter.Fill(dbc.DS, "membermanage");
                DBGrid.DataSource = dbc.DS.Tables["membermanage"].DefaultView;
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
        private void DBGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

 

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void SalesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

