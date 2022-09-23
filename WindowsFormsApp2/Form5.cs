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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count <= 0)
                MessageBox.Show("선택할 장비가 존재하지 않거나 장비를 선택하지 않았습니다.");
            else
                while (listView1.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem item in listView1.SelectedItems)
                    {
                        ListViewItem.ListViewSubItemCollection subItem = item.SubItems;
                        MessageBox.Show(subItem[0].Text+" 사이즈:  "+ subItem[2].Text + " 대여완료");
                    }
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }

        }

      

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count <= 0)
                MessageBox.Show("선택할 장비가 존재하지 않거나 장비를 선택하지 않았습니다.");
            else
                while (listView2.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem item in listView2.SelectedItems)
                    {
                        ListViewItem.ListViewSubItemCollection subItem = item.SubItems;
                        MessageBox.Show(subItem[1].Text + " 브랜드의 " + subItem[0].Text + " 판매완료");
                    }
                    listView2.Items.Remove(listView2.SelectedItems[0]);
                }

        }
    }
}

