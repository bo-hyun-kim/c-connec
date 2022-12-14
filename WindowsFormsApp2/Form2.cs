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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.DB_Open_insert(regdate.Text, regtype.Text, regfee.Text, username.Text, userphone.Text, empnum.Text);
                dbc.DBAdapter.Fill(dbc.DS, "reginfo");
                DataTable mmTable = dbc.DS.Tables["reginfo"];
                DataRow newRow = mmTable.NewRow();
                //newRow["regnum"] = "seq_usernum.nextval";
                newRow["regdate"] = regdate.Text;
                newRow["regtype"] = regtype.Text;
                newRow["regfee"] =  regfee.Text;
                //newRow["usernum"] = 2;
                newRow["username"] = username.Text;
                newRow["userphone"] = userphone.Text;
                newRow["empnum"] = empnum.Text;
                mmTable.Rows.Add(newRow);
                dbc.DBAdapter.Update(dbc.DS, "reginfo");
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

                dbc.Reginfo = dbc.DS.Tables["reginfo"];
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = dbc.Reginfo.Columns["regnum"];
                dbc.Reginfo.PrimaryKey = PrimaryKey;
                DataRow currRow = dbc.Reginfo.Rows.Find(SelectedRowIndex);
                currRow.BeginEdit();
                //currRow["regnum"] = regnum.Text;
                currRow["regdate"] = regdate.Text;
                currRow["regtype"] = regtype.Text;
                currRow["regfee"] = regfee.Text;
                //currRow["usernum"] = usernum.Text;
                currRow["username"] = username.Text;
                currRow["userphone"] = userphone.Text;
                //currRow["lockernum"] = lockernum.Text;
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

                dbc.Reginfo = dbc.DS.Tables["reginfo"];
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = dbc.Reginfo.Columns["regnum"];
                dbc.Reginfo.PrimaryKey = PrimaryKey;
                DataRow currRow = dbc.Reginfo.Rows.Find(SelectedRowIndex);
                currRow.Delete();
                dbc.DBAdapter.Update(dbc.DS.GetChanges(DataRowState.Deleted), "reginfo");
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
                DataTable reginfo = dbc.DS.Tables["reginfo"];
                if (e.RowIndex < 0)
                {
                    return;
                }
                else if (e.RowIndex > reginfo.Rows.Count - 1)
                {
                    MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                    return;
                }
                DataRow currRow = reginfo.Rows[e.RowIndex];
                empnum.Text = currRow["regnum"].ToString();
                regdate.Text = currRow["regdate"].ToString();
                regtype.Text = currRow["regtype"].ToString();
                usernum.Text = currRow["usernum"].ToString();
                regfee.Text = currRow["regfee"].ToString();
                username.Text = currRow["username"].ToString();
                userphone.Text = currRow["userphone"].ToString();
                lockernum.Text = currRow["lockernum"].ToString();
                SelectedRowIndex = currRow["regnum"].ToString();
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

