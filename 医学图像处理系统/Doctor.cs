using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OracleClient;

namespace 医学图像处理系统
{
   public class Doctor
    {
          public Connection conn = new Connection();


       public  DoctorInfo GetDoctor_Info(string strNum)
       {
           DoctorInfo docInfo = null;
           string strQuerySql="select * from doctor where Num="+"'"+strNum+"'";
            OracleDataReader dataReader=conn.ReadData(strQuerySql);
           while(dataReader.Read())
           {
               docInfo = new DoctorInfo();
               docInfo.StrNum = strNum;
               docInfo.StrName = dataReader.GetString(1);
               docInfo.StrSex = dataReader.GetString(2);
               docInfo.IAge = dataReader.GetInt32(3);
              

           }
           return docInfo;
       }

    }
}
