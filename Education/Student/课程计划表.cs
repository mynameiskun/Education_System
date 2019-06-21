using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace NewLife.School.Enity
{
    /// <summary>课程计划表</summary>
    [Serializable]
    [DataObject]
    [Description("课程计划表")]
    [BindIndex("IX_Course_Name", false, "Name")]
    [BindTable("Course", Description = "课程计划表", ConnName = "Membership", DbType = DatabaseType.SqlServer)]
    public partial class Course : ICourse
    {
        #region 属性
        private Int32 _ID;
        /// <summary>课程号</summary>
        [DisplayName("课程号")]
        [Description("课程号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("ID", "课程号", "int")]
        public Int32 ID { get { return _ID; } set { if (OnPropertyChanging(__.ID, value)) { _ID = value; OnPropertyChanged(__.ID); } } }

        private String _Name;
        /// <summary>课程名称</summary>
        [DisplayName("课程名称")]
        [Description("课程名称")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Name", "课程名称", "nvarchar(50)", Master = true)]
        public String Name { get { return _Name; } set { if (OnPropertyChanging(__.Name, value)) { _Name = value; OnPropertyChanged(__.Name); } } }

        private Education.CourseType _CourseType;
        /// <summary>必修/选修</summary>
        [DisplayName("必修_选修")]
        [Description("必修/选修")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("CourseType", "必修/选修", "int")]
        public Education.CourseType CourseType { get { return _CourseType; } set { if (OnPropertyChanging(__.CourseType, value)) { _CourseType = value; OnPropertyChanged(__.CourseType); } } }

        private Int32 _DptID;
        /// <summary>系部</summary>
        [DisplayName("系部")]
        [Description("系部")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("DptID", "系部", "int")]
        public Int32 DptID { get { return _DptID; } set { if (OnPropertyChanging(__.DptID, value)) { _DptID = value; OnPropertyChanged(__.DptID); } } }

        private Int32 _MajorID;
        /// <summary>专业</summary>
        [DisplayName("专业")]
        [Description("专业")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("MajorID", "专业", "int")]
        public Int32 MajorID { get { return _MajorID; } set { if (OnPropertyChanging(__.MajorID, value)) { _MajorID = value; OnPropertyChanged(__.MajorID); } } }

        private Int32 _ClassID;
        /// <summary>班级</summary>
        [DisplayName("班级")]
        [Description("班级")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("ClassID", "班级", "int")]
        public Int32 ClassID { get { return _ClassID; } set { if (OnPropertyChanging(__.ClassID, value)) { _ClassID = value; OnPropertyChanged(__.ClassID); } } }

        private Int32 _CourseTime;
        /// <summary>学时</summary>
        [DisplayName("学时")]
        [Description("学时")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("CourseTime", "学时", "int")]
        public Int32 CourseTime { get { return _CourseTime; } set { if (OnPropertyChanging(__.CourseTime, value)) { _CourseTime = value; OnPropertyChanged(__.CourseTime); } } }

        private Int32 _TeacherID;
        /// <summary>开课教师ID</summary>
        [DisplayName("开课教师ID")]
        [Description("开课教师ID")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("TeacherID", "开课教师ID", "int")]
        public Int32 TeacherID { get { return _TeacherID; } set { if (OnPropertyChanging(__.TeacherID, value)) { _TeacherID = value; OnPropertyChanged(__.TeacherID); } } }
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
                    case __.CourseType : return _CourseType;
                    case __.DptID : return _DptID;
                    case __.MajorID : return _MajorID;
                    case __.ClassID : return _ClassID;
                    case __.CourseTime : return _CourseTime;
                    case __.TeacherID : return _TeacherID;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.ID : _ID = Convert.ToInt32(value); break;
                    case __.Name : _Name = Convert.ToString(value); break;
                    case __.CourseType : _CourseType = (Education.CourseType)Convert.ToInt32(value); break;
                    case __.DptID : _DptID = Convert.ToInt32(value); break;
                    case __.MajorID : _MajorID = Convert.ToInt32(value); break;
                    case __.ClassID : _ClassID = Convert.ToInt32(value); break;
                    case __.CourseTime : _CourseTime = Convert.ToInt32(value); break;
                    case __.TeacherID : _TeacherID = Convert.ToInt32(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得课程计划表字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>课程号</summary>
            public static readonly Field ID = FindByName(__.ID);

            /// <summary>课程名称</summary>
            public static readonly Field Name = FindByName(__.Name);

            /// <summary>必修/选修</summary>
            public static readonly Field CourseType = FindByName(__.CourseType);

            /// <summary>系部</summary>
            public static readonly Field DptID = FindByName(__.DptID);

            /// <summary>专业</summary>
            public static readonly Field MajorID = FindByName(__.MajorID);

            /// <summary>班级</summary>
            public static readonly Field ClassID = FindByName(__.ClassID);

            /// <summary>学时</summary>
            public static readonly Field CourseTime = FindByName(__.CourseTime);

            /// <summary>开课教师ID</summary>
            public static readonly Field TeacherID = FindByName(__.TeacherID);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得课程计划表字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>课程号</summary>
            public const String ID = "ID";

            /// <summary>课程名称</summary>
            public const String Name = "Name";

            /// <summary>必修/选修</summary>
            public const String CourseType = "CourseType";

            /// <summary>系部</summary>
            public const String DptID = "DptID";

            /// <summary>专业</summary>
            public const String MajorID = "MajorID";

            /// <summary>班级</summary>
            public const String ClassID = "ClassID";

            /// <summary>学时</summary>
            public const String CourseTime = "CourseTime";

            /// <summary>开课教师ID</summary>
            public const String TeacherID = "TeacherID";
        }
        #endregion
    }

    /// <summary>课程计划表接口</summary>
    public partial interface ICourse
    {
        #region 属性
        /// <summary>课程号</summary>
        Int32 ID { get; set; }

        /// <summary>课程名称</summary>
        String Name { get; set; }

        /// <summary>必修/选修</summary>
        Education.CourseType CourseType { get; set; }

        /// <summary>系部</summary>
        Int32 DptID { get; set; }

        /// <summary>专业</summary>
        Int32 MajorID { get; set; }

        /// <summary>班级</summary>
        Int32 ClassID { get; set; }

        /// <summary>学时</summary>
        Int32 CourseTime { get; set; }

        /// <summary>开课教师ID</summary>
        Int32 TeacherID { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}