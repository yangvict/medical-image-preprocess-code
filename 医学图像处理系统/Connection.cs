using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;
namespace 医学图像处理系统
{
   public class Connection
    {
       //public list<Patient> pList=new list<Patient>();
        public string strConn = "Server=127.0.0.1;Data Source=orcl;User Id=hsc;Password=hsc;";
        public OracleConnection Conn()
        {
            OracleConnection conn = new OracleConnection(strConn);
            return conn;
        }
       public OracleDataReader ReadData(string strQuerySql)
       {
           try
           {
	           OracleConnection connection = this.Conn();
	           OracleCommand cmd = new OracleCommand(strQuerySql, connection);
	           connection.Open();
	           OracleDataReader dataReader = cmd.ExecuteReader();
               return dataReader;
           }
           catch 
           {
               MessageBox.Show( "数据库连接异常！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
               return null;
           }

       }
    }
}
