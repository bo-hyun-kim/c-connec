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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace 윈프_과제_홀수반_김한영
{
    public partial class Form9 : Form
    {
        DBClass dbc = new DBClass();
        public Form9()
        {
            InitializeComponent();
        }
        //확인
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int seq = dbc.GetSequenceValue("MANAGER_SEQ");
                string adminid = textBox1.Text;
                string adminpasswd = textBox2.Text;
                string adminname = textBox3.Text;

                string strConn = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                OracleConnection conn = new OracleConnection(strConn);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"INSERT INTO admininfo(adminid,adminpasswd,adminregdate,adminname,adminposition,adminexdate) VALUES('{adminid}','{adminpasswd}','2022-11-11','{adminname}','관리자','2023-11-11') ";
                cmd.ExecuteNonQuery();
                conn.Close();
                this.Close();
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
        //취소
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
