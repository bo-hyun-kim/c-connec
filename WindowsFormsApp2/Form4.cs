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
namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("memo.txt");
            sw.Write(textBox1.Text);
            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
                listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo("memo.txt");
            FileStream stream = file.Open(FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            //StreamReader reader = new StreamReader(@"c:\cstest.txt");
            string sampleString = null;
            // 파일의 끝까지 계속해서 읽습니다.
            while (!reader.EndOfStream)
            { // 한줄을 읽습니다
                sampleString = reader.ReadLine();
                if (sampleString == null)
                { break; }
                // 리스트 박스에 추가 
                listBox1.Items.Add(sampleString);
            }
            // 스트림 닫기
            reader.Close();
            stream.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("memo.txt");
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sw.WriteLine(listBox1.Items[i].ToString());
            }
            sw.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo("test.txt");
            FileStream stream = file.Open(FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            //StreamReader reader = new StreamReader(@"c:\cstest.txt");
            string sampleString = null;
            // 파일의 끝까지 계속해서 읽습니다.
            while (!reader.EndOfStream)
            { // 한줄을 읽습니다
                sampleString = reader.ReadLine();
                if (sampleString == null)
                { break; }
                // 리스트 박스에 추가 
                listBox1.Items.Add(sampleString);
            }
            // 스트림 닫기
            reader.Close();
            stream.Close();
        }
    }
    }

