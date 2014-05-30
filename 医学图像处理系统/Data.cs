using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;
namespace 医学图像处理系统
{
    public class PatientInfo
    {
        private string strNum;//编号

        public string StrNum
        {
            get { return strNum; }
            set { strNum = value; }
        }
        private string strName;//名子

        public string StrName
        {
            get { return strName; }
            set { strName = value; }
        }
        private string strSex;//性别

        public string StrSex
        {
            get { return strSex; }
            set { strSex = value; }
        }
        private string strWorkUnit;//工作单位

        public string StrWorkUnit
        {
            get { return strWorkUnit; }
            set { strWorkUnit = value; }
        }
        private int iAge;

        public int IAge//年龄
        {
            get { return iAge; }
            set { iAge = value; }
        }
    }
    public class DoctorInfo
    {
        private string strNum;//编号

        public string StrNum
        {
            get { return strNum; }
            set { strNum = value; }
        }
        private int iAge;

        public int IAge
        {
            get { return iAge; }
            set { iAge = value; }
        }
        private string strSex;

        public string StrSex
        {
            get { return strSex; }
            set { strSex = value; }
        }
        private string strName;//姓名
        public string StrName
        {
            get { return strName; }
            set { strName = value; }
        }
        private string strPassword;//密码

        public string StrPassword
        {
            get { return strPassword; }
            set { strPassword = value; }
        }
        private string strAcademicTitle;

        public string StrAcademicTitle
        {
            get { return strAcademicTitle; }
            set { strAcademicTitle = value; }
        }
    }
}
