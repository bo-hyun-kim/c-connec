using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 윈프_과제_홀수반_김한영;

namespace WindowsFormsApp2

{

    public partial class member : Form
    {
        private string SelectedRowIndex;
        DBClass dbc = new DBClass();

        public member()
        {
            InitializeComponent();
            dbc.DB_Open();
            dbc.DB_Access();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.DS.Clear();
                dbc.DBAdapter.Fill(dbc.DS, "membermanage");
                DataTable mmTable = dbc.DS.Tables["membermanage"];
                DataRow newRow = mmTable.NewRow();
                newRow["user_no"] = Convert.ToInt32(1);
                newRow["uname"] = username.Text;
                newRow["uphone"] = userphone.Text;
                newRow["lockernum"] = lockernum.Text;
                newRow["u_startdate"] = startDate.Text;
                newRow["u_memperiod"] = regtype.Text;
                newRow["ukind"] = kind.Text;
                newRow["ucost"] = regfee.Text;
                mmTable.Rows.Add(newRow);
                dbc.DBAdapter.Update(dbc.DS, "membermanage");
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

                dbc.Membermanage = dbc.DS.Tables["membermanage"];
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = dbc.Membermanage.Columns["user_no"];
                dbc.Membermanage.PrimaryKey = PrimaryKey;
                DataRow currRow = dbc.Membermanage.Rows.Find(SelectedRowIndex);
                currRow.BeginEdit();
               // currRow["user_no"] = text.Text;
                currRow["uname"] = username.Text;
                currRow["uphone"] = userphone.Text;
                currRow["lockernum"] = lockernum.Text;
                currRow["u_startdate"] = startDate.Text;
                currRow["u_memperiod"] = regtype.Text;
                currRow["ukind"] = kind.Text;
                currRow["ucost"] = regfee.Text;
                currRow.EndEdit();
                DataSet UpdatedSet = dbc.DS.GetChanges(DataRowState.Modified);
                if (UpdatedSet.HasErrors)
                { MessageBox.Show("변경된 데이터에 문제가 있습니다."); }
                else
                {
                    dbc.DBAdapter.Update(UpdatedSet, "membermanage");
                    dbc.DS.AcceptChanges();
                }
                DBGrid.DataSource = dbc.DS.Tables["membermanage"].DefaultView;
            }
            catch (DataException DE)
            { MessageBox.Show(DE.Message); }
            catch (Exception DE)
            { MessageBox.Show(DE.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                dbc.Membermanage = dbc.DS.Tables["membermanage"];
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = dbc.Membermanage.Columns["user_no"];
                dbc.Membermanage.PrimaryKey = PrimaryKey;
                DataRow currRow = dbc.Membermanage.Rows.Find(SelectedRowIndex);
                currRow.Delete();
                dbc.DBAdapter.Update(dbc.DS.GetChanges(DataRowState.Deleted), "membermanage");
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

        private void member_Load(object sender, EventArgs e)
        {

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
                DataTable membermanage = dbc.DS.Tables["membermanage"];
                if (e.RowIndex < 0)
                {
                    return;
                }
                else if (e.RowIndex > membermanage.Rows.Count - 1)
                {
                    MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                    return;
                }
                DataRow currRow = membermanage.Rows[e.RowIndex];
                //text.Text = currRow["user_no"].ToString();
                username.Text = currRow["uname"].ToString();
                userphone.Text = currRow["uphone"].ToString();
                lockernum.Text = currRow["lockernum"].ToString();
                startDate.Text = currRow["u_startdate"].ToString();
                regtype.Text = currRow["u_memperiod"].ToString();
                kind.Text = currRow["ukind"].ToString();
                regfee.Text = currRow["ucost"].ToString();
                SelectedRowIndex = currRow["user_no"].ToString();
            }
            catch (DataException DE)
            { MessageBox.Show(DE.Message); }
            catch (Exception DE)
            { MessageBox.Show(DE.Message); }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            DialogResult result = f.ShowDialog();
        }
    }
}

