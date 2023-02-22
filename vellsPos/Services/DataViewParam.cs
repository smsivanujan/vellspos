using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vellsPos.Services
{
    public class DataViewParam
    {
        private string title;
        private string selectSql;
        private string fromSql;
        private string whereSql;
        private string groupSql;
        private string tableName;
        private int searchParamCount = 0;
        private int fixedColumnNumber = 1;
        private string hidebox;//sms
        private string strechImage;//sms
        private string showImage;//sms
        private List<string> titleList = new List<string>();
        private List<int> invisibleColumnList = new List<int>();
        private List<int> numericColumnList = new List<int>();
        private Form addForm;
        private Form viewForm;
        //authorities
        private string addAuthority;
        private string viewAuthority;

        //public DataViewParam(string title, string selectSql, string fromSql, string whereSql, string groupSql, string tableName, int searchParamCount, int fixedColumnNumber, string hidebox, string strechImage, string showImage, List<string> titleList, List<int> invisibleColumnList, List<int> numericColumnList, Form addForm, Form viewForm, string addAuthority, string viewAuthority)
        //{
        //    this.Title = title;
        //    this.SelectSql = selectSql;
        //    this.FromSql = fromSql;
        //    this.WhereSql = whereSql;
        //    this.GroupSql = groupSql;
        //    this.TableName = tableName;
        //    this.SearchParamCount = searchParamCount;
        //    this.FixedColumnNumber = fixedColumnNumber;
        //    this.Hidebox = hidebox;
        //    this.StrechImage = strechImage;
        //    this.ShowImage = showImage;
        //    this.TitleList = titleList;
        //    this.InvisibleColumnList = invisibleColumnList;
        //    this.NumericColumnList = numericColumnList;
        //    this.AddForm = addForm;
        //    this.ViewForm = viewForm;
        //    this.AddAuthority = addAuthority;
        //    this.ViewAuthority = viewAuthority;
        //}

        public string Title { get => title; set => title = value; }
        public string SelectSql { get => selectSql; set => selectSql = value; }
        public string FromSql { get => fromSql; set => fromSql = value; }
        public string WhereSql { get => whereSql; set => whereSql = value; }
        public string GroupSql { get => groupSql; set => groupSql = value; }
        public string TableName { get => tableName; set => tableName = value; }
        public int SearchParamCount { get => searchParamCount; set => searchParamCount = value; }
        public int FixedColumnNumber { get => fixedColumnNumber; set => fixedColumnNumber = value; }
        public string Hidebox { get => hidebox; set => hidebox = value; }
        public string StrechImage { get => strechImage; set => strechImage = value; }
        public string ShowImage { get => showImage; set => showImage = value; }
        public List<string> TitleList { get => titleList; set => titleList = value; }
        public List<int> InvisibleColumnList { get => invisibleColumnList; set => invisibleColumnList = value; }
        public List<int> NumericColumnList { get => numericColumnList; set => numericColumnList = value; }
        public Form AddForm { get => addForm; set => addForm = value; }
        public Form ViewForm { get => viewForm; set => viewForm = value; }
        public string AddAuthority { get => addAuthority; set => addAuthority = value; }
        public string ViewAuthority { get => viewAuthority; set => viewAuthority = value; }
    }
}
