using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 윈프_과제_홀수반_김한영
{
    public partial class Form8 : Form
    {
        DBClass dbc = new DBClass();
        public Form8()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            
            try
            {
                dbc.DB_Open_managerInsert();
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

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.DS.Clear();
                dbc.DB_Open_manager();
                dbc.DBAdapter.Fill(dbc.DS, "managerinfo");
                dbc.Manager = dbc.DS.Tables["managerinfo"];
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = dbc.Manager.Columns["prd_no"];
                dbc.Manager.PrimaryKey = PrimaryKey;
                DataRow currRow = dbc.Manager.Rows.Find(dbc.SelectedRowIndex);
                currRow.Delete();
                dbc.DBAdapter.Update(dbc.DS.GetChanges(DataRowState.Deleted), "managerinfo");
                dataGridView1.DataSource = dbc.DS.Tables["managerinfo"].DefaultView;
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

        private void button4_Click(object sender, EventArgs e)
        {
            

            try
            {
                dbc.DB_Open_manager();
                dbc.DBAdapter.Fill(dbc.DS, "managerinfo");
                dataGridView1.DataSource = dbc.DS.Tables["managerinfo"].DefaultView;
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

                dbc.DS.Clear();
                dbc.DBAdapter.Fill(dbc.DS, "managerinfo");
                DataTable manager = dbc.DS.Tables["managerinfo"];
                if (e.RowIndex < 0)
                {
                    return;
                }
                else if (e.RowIndex > manager.Rows.Count - 1)
                {
                    MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                    return;
                }
                DataRow currRow = manager.Rows[e.RowIndex];
                dbc.SelectedRowIndex = Convert.ToInt32(currRow["empnum"]);
            }
            catch (DataException DE)
            { MessageBox.Show(DE.Message); }
            catch (Exception DE)
            { MessageBox.Show(DE.Message); }
        }
    }
}
