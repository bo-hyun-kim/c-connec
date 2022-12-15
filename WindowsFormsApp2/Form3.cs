using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using 윈프_과제_홀수반_김한영;

namespace WindowsFormsApp2
{   
    public partial class Form3 : Form
    {
        DBClass dbc = new DBClass();
        private void ClearTextBoxes()
        {
            textBox_ID.Clear();
            textBox_PW.Clear();
        }

        public Form3()
        {
            InitializeComponent();
            dbc.DB_Open_Admin();
        }
        

        public Form3(Form1 main_Form)
        {
          
        }

        private void button_log_Click(object sender, EventArgs e)
        {
            dbc.DBAdapter.Fill(dbc.DS, "admin");
            DataTable ManagerTable = dbc.DS.Tables["admin"];

            if (textBox_ID.Text == "")
            {
                MessageBox.Show("ID를 입력해주세요!");
                return;
            }
            if(textBox_PW.Text == "")
            {
                MessageBox.Show("비밀번호를 입력해주세요!");
                return;
            }

            for (int i = 0; i < ManagerTable.Rows.Count; i++)
            {
                DataRow currRow = ManagerTable.Rows[i];
                if (textBox_ID.Text == currRow["adminid"].ToString() && textBox_PW.Text == currRow["adminpasswd"].ToString())
                {
                    Form1.loginid = currRow["adminid"].ToString();
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
            
            }
        

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form9 f = new Form9();
            DialogResult result = f.ShowDialog();
        }
    }
}
