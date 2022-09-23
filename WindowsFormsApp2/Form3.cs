using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        

        public Form3(Form1 main_Form)
        {
          
        }

        private void button_log_Click(object sender, EventArgs e)
        {
            if(textBox_ID.Text == "김한영" && textBox_PW.Text == "1234")
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
