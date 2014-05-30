using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace 医学图像处理系统
{
   public class Patient
    {
        public Connection conn = new Connection();


       public PatientInfo GetPatient_Info(string strNum)
       {
           PatientInfo patInfo = null;
           string strQuerySql="select * from Patient where Num="+"'"+strNum+"'";
            OracleDataReader dataReader=conn.ReadData(strQuerySql);
           while(dataReader.Read())
           {
               patInfo = new PatientInfo();
               patInfo.StrNum = strNum;
               patInfo.StrName = dataReader.GetString(1);
               patInfo.StrSex = dataReader.GetString(2);
               patInfo.IAge = dataReader.GetInt32(3);
               patInfo.StrWorkUnit = dataReader.GetString(4);

           }
           return patInfo;
       }

    }
}
