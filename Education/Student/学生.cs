using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace NewLife.School.Enity
{
    /// <summary>学生</summary>
    [Serializable]
    [DataObject]
    [Description("学生")]
    [BindIndex("IU_Student_Name", true, "Name")]
    [BindTable("Student", Description = "学生", ConnName = "Membership", DbType = DatabaseType.SqlServer)]
    public partial class Student : IStudent
    {
        #region 属性
        private Int32 _ID;
        /// <summary>学号</summary>
        [DisplayName("学号")]
        [Description("学号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("ID", "学号", "int")]
        public Int32 ID { get { return _ID; } set { if (OnPropertyChanging(__.ID, value)) { _ID = value; OnPropertyChanged(__.ID); } } }

        private String _Name;
        /// <summary>姓名</summary>
        [DisplayName("姓名")]
        [Description("姓名")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Name", "姓名", "nvarchar(50)", Master = true)]
        public String Name { get { return _Name; } set { if (OnPropertyChanging(__.Name, value)) { _Name = value; OnPropertyChanged(__.Name); } } }

        private XCode.Membership.SexKinds _Sex;
        /// <summary>性别</summary>
        [DisplayName("性别")]
        [Description("性别")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Sex", "性别", "int")]
        public XCode.Membership.SexKinds Sex { get { return _Sex; } set { if (OnPropertyChanging(__.Sex, value)) { _Sex = value; OnPropertyChanged(__.Sex); } } }

        private Int32 _ClassID;
        /// <summary>班号</summary>
        [DisplayName("班号")]
        [Description("班号")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("ClassID", "班号", "int")]
        public Int32 ClassID { get { return _ClassID; } set { if (OnPropertyChanging(__.ClassID, value)) { _ClassID = value; OnPropertyChanged(__.ClassID); } } }

        private DateTime _BornDate;
        /// <summary>出生日期</summary>
        [DisplayName("出生日期")]
        [Description("出生日期")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("BornDate", "出生日期", "datetime")]
        public DateTime BornDate { get { return _BornDate; } set { if (OnPropertyChanging(__.BornDate, value)) { _BornDate = value; OnPropertyChanged(__.BornDate); } } }

        private Int32 _DptID;
        /// <summary>系部</summary>
        [DisplayName("系部")]
        [Description("系部")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("DptID", "系部", "int")]
        public Int32 DptID { get { return _DptID; } set { if (OnPropertyChanging(__.DptID, value)) { _DptID = value; OnPropertyChanged(__.DptID); } } }

        private Int32 _Phone;
        /// <summary>联系方式</summary>
        [DisplayName("联系方式")]
        [Description("联系方式")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Phone", "联系方式", "int")]
        public Int32 Phone { get { return _Phone; } set { if (OnPropertyChanging(__.Phone, value)) { _Phone = value; OnPropertyChanged(__.Phone); } } }

        private DateTime _InDate;
        /// <summary>入学日期</summary>
        [DisplayName("入学日期")]
        [Description("入学日期")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("InDate", "入学日期", "datetime")]
        public DateTime InDate { get { return _InDate; } set { if (OnPropertyChanging(__.InDate, value)) { _InDate = value; OnPropertyChanged(__.InDate); } } }

        private Int32 _MajorID;
        /// <summary>专业</summary>
        [DisplayName("专业")]
        [Description("专业")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("MajorID", "专业", "int")]
        public Int32 MajorID { get { return _MajorID; } set { if (OnPropertyChanging(__.MajorID, value)) { _MajorID = value; OnPropertyChanged(__.MajorID); } } }

        private Education.Feature _Feature;
        /// <summary>政治面貌</summary>
        [DisplayName("政治面貌")]
        [Description("政治面貌")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Feature", "政治面貌", "nvarchar(50)")]
        public Education.Feature Feature { get { return _Feature; } set { if (OnPropertyChanging(__.Feature, value)) { _Feature = value; OnPropertyChanged(__.Feature); } } }

        private Int32 _RoleID;
        /// <summary>角色</summary>
        [DisplayName("角色")]
        [Description("角色")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("RoleID", "角色", "int")]
        public Int32 RoleID { get { return _RoleID; } set { if (OnPropertyChanging(__.RoleID, value)) { _RoleID = value; OnPropertyChanged(__.RoleID); } } }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        public override Object this[String name]
        {
            get
            {
                switch (name)
                {
                    case __.ID : return _ID;
                    case __.Name : return _Name;
                    case __.Sex : return _Sex;
                    case __.ClassID : return _ClassID;
                    case __.BornDate : return _BornDate;
                    case __.DptID : return _DptID;
                    case __.Phone : return _Phone;
                    case __.InDate : return _InDate;
                    case __.MajorID : return _MajorID;
                    case __.Feature : return _Feature;
                    case __.RoleID : return _RoleID;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.ID : _ID = Convert.ToInt32(value); break;
                    case __.Name : _Name = Convert.ToString(value); break;
                    case __.Sex : _Sex = (XCode.Membership.SexKinds)Convert.ToInt32(value); break;
                    case __.ClassID : _ClassID = Convert.ToInt32(value); break;
                    case __.BornDate : _BornDate = Convert.ToDateTime(value); break;
                    case __.DptID : _DptID = Convert.ToInt32(value); break;
                    case __.Phone : _Phone = Convert.ToInt32(value); break;
                    case __.InDate : _InDate = Convert.ToDateTime(value); break;
                    case __.MajorID : _MajorID = Convert.ToInt32(value); break;
                    case __.Feature : _Feature = (Education.Feature)Convert.ToInt32(value); break;
                    case __.RoleID : _RoleID = Convert.ToInt32(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得学生字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>学号</summary>
            public static readonly Field ID = FindByName(__.ID);

            /// <summary>姓名</summary>
            public static readonly Field Name = FindByName(__.Name);

            /// <summary>性别</summary>
            public static readonly Field Sex = FindByName(__.Sex);

            /// <summary>班号</summary>
            public static readonly Field ClassID = FindByName(__.ClassID);

            /// <summary>出生日期</summary>
            public static readonly Field BornDate = FindByName(__.BornDate);

            /// <summary>系部</summary>
            public static readonly Field DptID = FindByName(__.DptID);

            /// <summary>联系方式</summary>
            public static readonly Field Phone = FindByName(__.Phone);

            /// <summary>入学日期</summary>
            public static readonly Field InDate = FindByName(__.InDate);

            /// <summary>专业</summary>
            public static readonly Field MajorID = FindByName(__.MajorID);

            /// <summary>政治面貌</summary>
            public static readonly Field Feature = FindByName(__.Feature);

            /// <summary>角色</summary>
            public static readonly Field RoleID = FindByName(__.RoleID);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得学生字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>学号</summary>
            public const String ID = "ID";

            /// <summary>姓名</summary>
            public const String Name = "Name";

            /// <summary>性别</summary>
            public const String Sex = "Sex";

            /// <summary>班号</summary>
            public const String ClassID = "ClassID";

            /// <summary>出生日期</summary>
            public const String BornDate = "BornDate";

            /// <summary>系部</summary>
            public const String DptID = "DptID";

            /// <summary>联系方式</summary>
            public const String Phone = "Phone";

            /// <summary>入学日期</summary>
            public const String InDate = "InDate";

            /// <summary>专业</summary>
            public const String MajorID = "MajorID";

            /// <summary>政治面貌</summary>
            public const String Feature = "Feature";

            /// <summary>角色</summary>
            public const String RoleID = "RoleID";
        }
        #endregion
    }

    /// <summary>学生接口</summary>
    public partial interface IStudent
    {
        #region 属性
        /// <summary>学号</summary>
        Int32 ID { get; set; }

        /// <summary>姓名</summary>
        String Name { get; set; }

        /// <summary>性别</summary>
        XCode.Membership.SexKinds Sex { get; set; }

        /// <summary>班号</summary>
        Int32 ClassID { get; set; }

        /// <summary>出生日期</summary>
        DateTime BornDate { get; set; }

        /// <summary>系部</summary>
        Int32 DptID { get; set; }

        /// <summary>联系方式</summary>
        Int32 Phone { get; set; }

        /// <summary>入学日期</summary>
        DateTime InDate { get; set; }

        /// <summary>专业</summary>
        Int32 MajorID { get; set; }

        /// <summary>政治面貌</summary>
        Education.Feature Feature { get; set; }

        /// <summary>角色</summary>
        Int32 RoleID { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}