using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;//ADO.Net 개체 참조
using System.Data; //DataSet 개체 참조
using System.Windows.Forms; //MessageBox 개체 참조

namespace 윈프_과제_홀수반_김한영
{
    class DBClass //DBClass 정의 시작
    {
        OracleConnection con;
        OracleCommand dcom;
        private int selectedRowIndex;//수정하거나 삭제하기 위해 선택된 행의 인덱스를 저장한다.
        private int selectedKeyValue; // 수정, 삭제할 때 필요한 레코드의 키값을 보관할 필드
        OracleDataAdapter dBAdapter; // Data Provider인 DBAdapter 입니다.
        DataSet dS;// DataSet 객체입니다.
        OracleCommandBuilder myCommandBuilder; // 추가, 수정, 삭제시에 필요한 명령문을 자동으로 작성해주는 객체
        DataTable reginfo;// DataTable 객체입니다.
        DataTable prdtransaction;
        DataTable reservation;

        public OracleConnection Con { get { return con; } set { con = value; } }
        public OracleCommand DCom { get { return dcom; } set { dcom = value; } }
        public int SelectedRowIndex { get { return selectedRowIndex; } set { selectedRowIndex = value; } }
        public int SelectedKeyValue { get { return selectedKeyValue; } set { selectedKeyValue = value; } }
        public OracleDataAdapter DBAdapter { get { return dBAdapter; } set { dBAdapter = value; } }
        public DataSet DS { get { return dS; } set { dS = value; } }
        public OracleCommandBuilder MyCommandBuilder
        {
            get { return myCommandBuilder; }
            set { myCommandBuilder = value; }
        }
        public DataTable Reginfo { get { return reginfo; } set { reginfo = value; } }
        public DataTable Prdtransaction { get { return prdtransaction; } set { prdtransaction = value; } }
        public DataTable Reservation { get { return reservation; } set { reservation = value; } }
        //public DataTable PrdSales { get { return prdtransaction; } set { prdtransaction = value; } }
        //public DataTable USales { get { return reginfo; } set { reginfo = value; } }

        //회원관리 부분
        public void DB_Open()
        {
            try
            {
                string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                string commandString = "select u.usernum as 회원번호, u.username as 회원이름, u.userphone as 전화번호, u.lockernum as 사물함번호,  u.empnum as 직원번호,m.empname as 직원이름, u.expiredate as 만기일자, u.regtype as 등록종류, u.regfee as 등록비, u.ptdate as pt예약일자, u.ptnum as pt횟수, u.regdate as 등록일자 from userinfo u, managerinfo m where m.empnum = u.empnum ";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                MyCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
        public void DB_Open_select(string username)
        {
            try
            {
                string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                string commandString = $"select u.usernum as 회원번호, u.username as 회원이름, u.userphone as 전화번호, u.lockernum as 사물함번호, u.empnum as 직원번호, u.expiredate as 만기일자, u.regtype as 등록종류, u.regfee as 등록비, u.ptdate as pt예약일자, u.ptnum as pt횟수, u.regdate as 등록일자 from userinfo u, managerinfo m where m.empnum = u.empnum and u.username = '{username}' ";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                MyCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
        //통화조회 - 트레이너 소속 회원 불러오기
        public void DB_date_findMember(string trainer)
        {
            try
            {
                string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                string commandString = $"select u.usernum as 회원번호, u.username as 회원이름, u.userphone as 전화번호, m.empname as 트레이너이름, u.regtype as 등록종류, u.ptnum as pt횟수, u.ptdate as pt예약일자 from managerinfo m, userinfo u where (m.empname = '{trainer}') and u.empnum = m.empnum";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                MyCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
        public void DB_date_all(string index)
        {
            try
            {
                string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                string commandString = $"select usernum as 회원번호, username as 회원이름, userphone as 전화번호, lockernum as 사물함번호, expiredate as 만기일자, regtype as 등록종류, regfee as 등록비, ptdate as pt예약일자, ptnum as pt횟수, regdate as 등록일자 from userinfo where usernum = '{index}'";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                MyCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
        //통합조회 - 물품재고 불러오기
        public void DB_stock()
        {
            try
            {
                string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                string commandString = "select prdnum as 물품번호, prdname as 물품명, prdcnt as 물품수량, prdexdate as 유통기한 from stockinfo";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                MyCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
        //통합조회 - 회원 pt일정 불러오기
        public void DB_ptdate(string ptdate)
        {
            try
            {
                string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                string commandString = $"select u.username as 회원이름, u.userphone as 전화번호, m.empname as 트레이너이름, u.regtype as 등록종류, u.ptnum as 남은pt횟수, u.ptdate as pt예약일자 from managerinfo m, userinfo u where u.ptdate = '{ptdate}' and u.empnum = m.empnum";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                MyCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        public void DB_Open_Admin()
        {
            try
            {
                string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                string commandString = "select * from admininfo";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                MyCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
        public void DB_Open_Product()
        {
            try
            {
                string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                string commandString = "select p.prdno as 일련번호,p.prdname as 처리물품명, p.prdcnt as 처리물품수량, p.prdcost as 처리물품가격, p.prddate as 처리날짜, t.prdendname as 처리형태명 from prdtradeinfo p, prdendtype t where p.prdendno=t.prdendno";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                MyCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
        public void DB_Open_Trainer()
        {
            try
            {
                string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                string commandString = "select * from managerinfo";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                MyCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        public void DB_Open_prdSales(string mon)
        {
            try
            {
                string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                string commandString = $"select prdname as 상품명, prddate as 거래날짜, to_number(prdcnt) * to_number(prdcost) as 총액 from prdtradeinfo where prddate between to_date('{mon}+01') and to_date('{mon}+30')";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                MyCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
        public void DB_Open_uSales(string mon)
        {
            try
            {
                string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                string commandString = $"select username as 회원이름, regdate as 등록일자, regtype as 등록종류, to_number(regfee) as 등록비 from userinfo where  regdate between to_date('{mon}+01') and to_date('{mon}+30') ";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                MyCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        public void DB_Access()
        {
            try
            {
                string My_con = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";
                Con = new OracleConnection();
                Con.ConnectionString = My_con;
                DCom = new OracleCommand();
                DCom.Connection = Con;
                Con.Open();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        public int GetSequenceValue(string seq)
        {
            try
            {
                string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";
                //string commandString = "select * from Phone";
                OracleDataAdapter DBAdapter = new OracleDataAdapter("select " + seq + ".nextval as n from dual", connectionString);
                OracleCommandBuilder MyCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DataSet DS = new DataSet();
                DBAdapter.Fill(DS, "seq");
                return int.Parse(DS.Tables["seq"].Rows[0]["n"].ToString());
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            return -1;
        }

        public void DB_ObjCreate()
        {
            Reginfo = new DataTable();
            Prdtransaction = new DataTable();

        }
    }
}