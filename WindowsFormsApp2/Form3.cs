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
            dbc.DB_Open_Manager();
        }
        

        public Form3(Form1 main_Form)
        {
          
        }

        private void button_log_Click(object sender, EventArgs e)
        {
            dbc.DBAdapter.Fill(dbc.DS, "manager");
            DataTable ManagerTable = dbc.DS.Tables["manager"];
            DataRow currRow = ManagerTable.Rows[0];



            if (textBox_ID.Text == currRow["user_id"].ToString() && textBox_PW.Text == currRow["user_password"].ToString())
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("암호가 일치하지 않습니다", "확인", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
