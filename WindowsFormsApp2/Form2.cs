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
    public partial class member : Form
    {
        public member()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            StreamWriter sw = new StreamWriter("name.txt");
            sw.Write("이름: "+textBox1.Text + " ");
            sw.Write("전화번호: "+textBox2.Text + " ");
            sw.Write("생년월일: "+textBox3.Text + " ");
            sw.Write("등록일: "+textBox4.Text + " ");
            sw.Write("종료일: " + textBox5.Text + " ");
            sw.Write("내용: " + textBox6.Text);
            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count < 1)
            {
                MessageBox.Show("선택된 항목이 없음!");
                return;
            }
            if (listBox1.SelectedIndex > -1)
            {
        
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo("name.txt");
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
            StreamWriter sw = new StreamWriter("name.txt");
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sw.WriteLine(listBox1.Items[i].ToString());
            }
            sw.Close();
        }
        }
    }

