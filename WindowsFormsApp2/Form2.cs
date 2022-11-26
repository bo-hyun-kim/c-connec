using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;


namespace WindowsFormsApp2

{

    public partial class member : Form
    {
        private string SelectedRowIndex;

        public member()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";
                string commandString = "select * from membermanage";
                OracleDataAdapter DBAdapter = new OracleDataAdapter(commandString, connectionString);
                OracleCommandBuilder myCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DataSet DS = new DataSet();
                DBAdapter.Fill(DS, "membermanage");
                DataTable HealthTable = DS.Tables["membermanage"];
                DataRow newRow = HealthTable.NewRow();
                newRow["user_no"] = Convert.ToInt32(text.Text);
                newRow["uname"] = textName.Text;
                newRow["uphone"] = textPhone.Text;
                newRow["lockernum"] = locknum.Text;
                newRow["u_startdate"] = startDate.Text;
                newRow["u_memperiod"] = endDate.Text;
                newRow["ukind"] = kind.Text;
                newRow["ucost"] = cost.Text;
                HealthTable.Rows.Add(newRow);
                DBAdapter.Update(DS, "membermanage");
               
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
                string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";
                string commandString = "select * from membermanage";
                OracleDataAdapter DBAdapter = new OracleDataAdapter(commandString, connectionString);
                OracleCommandBuilder myCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DataSet DS = new DataSet("membermanage");
                DBAdapter.Fill(DS, "membermanage");
                DataTable membermanage = DS.Tables["membermanage"];
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = membermanage.Columns["user_no"];
                membermanage.PrimaryKey = PrimaryKey;
                DataRow currRow = membermanage.Rows.Find(SelectedRowIndex);
                currRow.BeginEdit();
                currRow["user_no"] = Convert.ToInt32(text.Text);
                currRow["uname"] = textName.Text;
                currRow["uphone"] = textPhone.Text;
                currRow["lockernum"] = locknum.Text;
                currRow["u_startdate"] = startDate.Text;
                currRow["u_memperiod"] = endDate.Text;
                currRow["ukind"] = kind.Text;
                currRow["ucost"] = cost.Text;
                currRow.EndEdit();
                DataSet UpdatedSet = DS.GetChanges(DataRowState.Modified);
                if (UpdatedSet.HasErrors)
                { MessageBox.Show("변경된 데이터에 문제가 있습니다."); }
                else
                { DBAdapter.Update(UpdatedSet, "membermanage"); DS.AcceptChanges(); }
                DBGrid.DataSource = DS.Tables["membermanage"].DefaultView;
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
                string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";
                string commandString = "select * from membermanage";
                OracleDataAdapter DBAdapter = new OracleDataAdapter(commandString, connectionString);
                OracleCommandBuilder myCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DataSet DS = new DataSet("membermanage");
                DBAdapter.Fill(DS, "membermanage");
                DataTable membermanage = DS.Tables["membermanage"];
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = membermanage.Columns["user_no"];
                membermanage.PrimaryKey = PrimaryKey;
                DataRow currRow = membermanage.Rows.Find(SelectedRowIndex);
                currRow.Delete();
                DBAdapter.Update(DS.GetChanges(DataRowState.Deleted), "membermanage");
                DBGrid.DataSource = DS.Tables["membermanage"].DefaultView;
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
                string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";
                string commandString = "select * from membermanage";
                OracleDataAdapter DBAdapter = new OracleDataAdapter(commandString, connectionString);
                DataSet DS = new DataSet();
                DBAdapter.Fill(DS, "membermanage");
                DBGrid.DataSource = DS.Tables["membermanage"].DefaultView;
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
                string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";
                string commandString = "select * from membermanage";
                OracleDataAdapter DBAdapter = new OracleDataAdapter(commandString, connectionString);
                DataSet DS = new DataSet();
                DBAdapter.Fill(DS, "membermanage");
                DataTable membermanage = DS.Tables["membermanage"];
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
                text.Text = currRow["user_no"].ToString();
                textName.Text = currRow["uname"].ToString();
                textPhone.Text = currRow["uphone"].ToString();
                locknum.Text = currRow["lockernum"].ToString();
                startDate.Text = currRow["u_startdate"].ToString();
                endDate.Text = currRow["u_memperiod"].ToString();
                kind.Text = currRow["ukind"].ToString();
                cost.Text = currRow["ucost"].ToString();
                SelectedRowIndex = currRow["user_no"].ToString();
            }
            catch (DataException DE)
            { MessageBox.Show(DE.Message); }
            catch (Exception DE)
            { MessageBox.Show(DE.Message); }
        }
    }
    }

