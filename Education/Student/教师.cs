using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace NewLife.School.Enity
{
    /// <summary>教师</summary>
    [Serializable]
    [DataObject]
    [Description("教师")]
    [BindIndex("IX_Teacher_Name", false, "Name")]
    [BindTable("Teacher", Description = "教师", ConnName = "Membership", DbType = DatabaseType.SqlServer)]
    public partial class Teacher : ITeacher
    {
        #region 属性
        private Int32 _ID;
        /// <summary>教师编号</summary>
        [DisplayName("教师编号")]
        [Description("教师编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("ID", "教师编号", "int")]
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

        private DateTime _BornDate;
        /// <summary>出生日期</summary>
        [DisplayName("出生日期")]
        [Description("出生日期")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("BornDate", "出生日期", "datetime")]
        public DateTime BornDate { get { return _BornDate; } set { if (OnPropertyChanging(__.BornDate, value)) { _BornDate = value; OnPropertyChanged(__.BornDate); } } }

        private Education.Degree _Degree;
        /// <summary>职称</summary>
        [DisplayName("职称")]
        [Description("职称")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Degree", "职称", "int")]
        public Education.Degree Degree { get { return _Degree; } set { if (OnPropertyChanging(__.Degree, value)) { _Degree = value; OnPropertyChanged(__.Degree); } } }

        private Education.Feature _Feature;
        /// <summary>政治面貌</summary>
        [DisplayName("政治面貌")]
        [Description("政治面貌")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Feature", "政治面貌", "int")]
        public Education.Feature Feature { get { return _Feature; } set { if (OnPropertyChanging(__.Feature, value)) { _Feature = value; OnPropertyChanged(__.Feature); } } }

        private String _TeacherPhone;
        /// <summary>联系方式</summary>
        [DisplayName("联系方式")]
        [Description("联系方式")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("TeacherPhone", "联系方式", "nvarchar(50)")]
        public String TeacherPhone { get { return _TeacherPhone; } set { if (OnPropertyChanging(__.TeacherPhone, value)) { _TeacherPhone = value; OnPropertyChanged(__.TeacherPhone); } } }

        private Int32 _DptID;
        /// <summary>系部</summary>
        [DisplayName("系部")]
        [Description("系部")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("DptID", "系部", "int")]
        public Int32 DptID { get { return _DptID; } set { if (OnPropertyChanging(__.DptID, value)) { _DptID = value; OnPropertyChanged(__.DptID); } } }

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
                    case __.BornDate : return _BornDate;
                    case __.Degree : return _Degree;
                    case __.Feature : return _Feature;
                    case __.TeacherPhone : return _TeacherPhone;
                    case __.DptID : return _DptID;
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
                    case __.BornDate : _BornDate = Convert.ToDateTime(value); break;
                    case __.Degree : _Degree = (Education.Degree)Convert.ToInt32(value); break;
                    case __.Feature : _Feature = (Education.Feature)Convert.ToInt32(value); break;
                    case __.TeacherPhone : _TeacherPhone = Convert.ToString(value); break;
                    case __.DptID : _DptID = Convert.ToInt32(value); break;
                    case __.RoleID : _RoleID = Convert.ToInt32(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得教师字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>教师编号</summary>
            public static readonly Field ID = FindByName(__.ID);

            /// <summary>姓名</summary>
            public static readonly Field Name = FindByName(__.Name);

            /// <summary>性别</summary>
            public static readonly Field Sex = FindByName(__.Sex);

            /// <summary>出生日期</summary>
            public static readonly Field BornDate = FindByName(__.BornDate);

            /// <summary>职称</summary>
            public static readonly Field Degree = FindByName(__.Degree);

            /// <summary>政治面貌</summary>
            public static readonly Field Feature = FindByName(__.Feature);

            /// <summary>联系方式</summary>
            public static readonly Field TeacherPhone = FindByName(__.TeacherPhone);

            /// <summary>系部</summary>
            public static readonly Field DptID = FindByName(__.DptID);

            /// <summary>角色</summary>
            public static readonly Field RoleID = FindByName(__.RoleID);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得教师字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>教师编号</summary>
            public const String ID = "ID";

            /// <summary>姓名</summary>
            public const String Name = "Name";

            /// <summary>性别</summary>
            public const String Sex = "Sex";

            /// <summary>出生日期</summary>
            public const String BornDate = "BornDate";

            /// <summary>职称</summary>
            public const String Degree = "Degree";

            /// <summary>政治面貌</summary>
            public const String Feature = "Feature";

            /// <summary>联系方式</summary>
            public const String TeacherPhone = "TeacherPhone";

            /// <summary>系部</summary>
            public const String DptID = "DptID";

            /// <summary>角色</summary>
            public const String RoleID = "RoleID";
        }
        #endregion
    }

    /// <summary>教师接口</summary>
    public partial interface ITeacher
    {
        #region 属性
        /// <summary>教师编号</summary>
        Int32 ID { get; set; }

        /// <summary>姓名</summary>
        String Name { get; set; }

        /// <summary>性别</summary>
        XCode.Membership.SexKinds Sex { get; set; }

        /// <summary>出生日期</summary>
        DateTime BornDate { get; set; }

        /// <summary>职称</summary>
        Education.Degree Degree { get; set; }

        /// <summary>政治面貌</summary>
        Education.Feature Feature { get; set; }

        /// <summary>联系方式</summary>
        String TeacherPhone { get; set; }

        /// <summary>系部</summary>
        Int32 DptID { get; set; }

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