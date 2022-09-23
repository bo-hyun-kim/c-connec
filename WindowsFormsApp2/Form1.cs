using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        
        public int openclosecount // 로그인 폼에서 openclosecount 값 전달받는곳, 즉 로그인폼에서 메인폼으로 값 전달
        {
            set; get;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    
        private void button_member_Click(object sender, EventArgs e)
        {
            member m = new member();
            DialogResult result = m.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            DialogResult result = f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            DialogResult result = f.ShowDialog();
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show();

            Form3 form3 = new Form3();
            DialogResult result = form3.ShowDialog();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            DialogResult result = f.ShowDialog();

        }

     
        private void 도움말ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            help help = new help();
            help.Show();
        }

        private void 나가기ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }


