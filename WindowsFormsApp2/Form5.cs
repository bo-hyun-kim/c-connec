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
    public partial class Form5 : Form
    {
        private int SelectedRowIndex;
        DBClass dbc = new DBClass();
        Random rand = new Random();
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
                dbc.DS.Clear();
                dbc.DBAdapter.Fill(dbc.DS, "prdtransaction");
                DataTable PrdTable = dbc.DS.Tables["prdtransaction"];
                DataRow newRow = PrdTable.NewRow();
                newRow["prdtype"] = "추가";
                newRow["prdname"] = textBox_prdname.Text;
                newRow["prdcnt"] = textBox_prdcnt.Text;
                newRow["prdcost"] = textBox_prdcost.Text;
                newRow["prddate"] = textBox_prddate.Text;
                newRow["prdno"] = rand.Next();
                newRow["prdendno"] = "0";
                PrdTable.Rows.Add(newRow);
                dbc.DBAdapter.Update(dbc.DS, "prdtransaction");


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
                dbc.DS.Clear();
                dbc.DBAdapter.Fill(dbc.DS, "prdtransaction");
                DataTable PrdTable = dbc.DS.Tables["prdtransaction"];
                DataRow newRow = PrdTable.NewRow();
                newRow["prdtype"] = "폐기";
                newRow["prdname"] = textBox_prdname.Text;
                newRow["prdcnt"] = textBox_prdcnt.Text;
                newRow["prdcost"] = textBox_prdcost.Text;
                newRow["prddate"] = textBox_prddate.Text;
                newRow["prdno"] = rand.Next();
                newRow["prdendno"] = "1";
                PrdTable.Rows.Add(newRow);
                dbc.DBAdapter.Update(dbc.DS, "prdtransaction");

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
                dbc.DS.Clear();
                dbc.DBAdapter.Fill(dbc.DS, "prdtransaction");
                DataTable PrdTable = dbc.DS.Tables["prdtransaction"];
                DataRow newRow = PrdTable.NewRow();
                newRow["prdtype"] = "판매";
                newRow["prdname"] = textBox_prdname.Text;
                newRow["prdcnt"] = textBox_prdcnt.Text;
                newRow["prdcost"] = textBox_prdcost.Text;
                newRow["prddate"] = textBox_prddate.Text;
                newRow["prdno"] = rand.Next();
                newRow["prdendno"] = "2";
                PrdTable.Rows.Add(newRow);
                dbc.DBAdapter.Update(dbc.DS, "prdtransaction");

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
                dbc.DB_Open_Product();
                dbc.DS.Clear();
                dbc.DBAdapter.Fill(dbc.DS, "prdtransaction");
                dbc.Prdtransaction = dbc.DS.Tables["prdtransaction"];
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = dbc.Prdtransaction.Columns["prdno"];
                dbc.Prdtransaction.PrimaryKey = PrimaryKey;
                DataRow currRow = dbc.Prdtransaction.Rows.Find(SelectedRowIndex);
                currRow.Delete();
                dbc.DBAdapter.Update(dbc.DS.GetChanges(DataRowState.Deleted), "prdtransaction");
                PrdGridView.DataSource = dbc.DS.Tables["prdtransaction"].DefaultView;
                textBox1.Text = "";
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

                dbc.DBAdapter.Fill(dbc.DS, "prdtransaction");
                DataTable prdtransaction = dbc.DS.Tables["prdtransaction"];
                if (e.RowIndex < 0)
                {
                    return;
                }
                else if (e.RowIndex > prdtransaction.Rows.Count - 1)
                {
                    MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                    return;
                }
                DataRow currRow = prdtransaction.Rows[e.RowIndex];
                textBox1.Text = $"Selected {e.RowIndex}";
                SelectedRowIndex = Convert.ToInt32(currRow["prdno"]);
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

