using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace NewLife.School.Enity
{
    /// <summary>选课表</summary>
    [Serializable]
    [DataObject]
    [Description("选课表")]
    [BindTable("SelectCourse", Description = "选课表", ConnName = "Membership", DbType = DatabaseType.SqlServer)]
    public partial class SelectCourse : ISelectCourse
    {
        #region 属性
        private Int32 _ID;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("ID", "编号", "int")]
        public Int32 ID { get { return _ID; } set { if (OnPropertyChanging(__.ID, value)) { _ID = value; OnPropertyChanged(__.ID); } } }

        private String _CourseID;
        /// <summary>课程名称</summary>
        [DisplayName("课程名称")]
        [Description("课程名称")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("CourseID", "课程名称", "nvarchar(50)")]
        public String CourseID { get { return _CourseID; } set { if (OnPropertyChanging(__.CourseID, value)) { _CourseID = value; OnPropertyChanged(__.CourseID); } } }

        private Int32 _StuID;
        /// <summary>学号</summary>
        [DisplayName("学号")]
        [Description("学号")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("StuID", "学号", "int")]
        public Int32 StuID { get { return _StuID; } set { if (OnPropertyChanging(__.StuID, value)) { _StuID = value; OnPropertyChanged(__.StuID); } } }

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

        private Education.state _IsTake;
        /// <summary>是否已选</summary>
        [DisplayName("是否已选")]
        [Description("是否已选")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("IsTake", "是否已选", "int")]
        public Education.state IsTake { get { return _IsTake; } set { if (OnPropertyChanging(__.IsTake, value)) { _IsTake = value; OnPropertyChanged(__.IsTake); } } }
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
                    case __.CourseID : return _CourseID;
                    case __.StuID : return _StuID;
                    case __.DptID : return _DptID;
                    case __.MajorID : return _MajorID;
                    case __.ClassID : return _ClassID;
                    case __.CourseTime : return _CourseTime;
                    case __.TeacherID : return _TeacherID;
                    case __.IsTake : return _IsTake;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.ID : _ID = Convert.ToInt32(value); break;
                    case __.CourseID : _CourseID = Convert.ToString(value); break;
                    case __.StuID : _StuID = Convert.ToInt32(value); break;
                    case __.DptID : _DptID = Convert.ToInt32(value); break;
                    case __.MajorID : _MajorID = Convert.ToInt32(value); break;
                    case __.ClassID : _ClassID = Convert.ToInt32(value); break;
                    case __.CourseTime : _CourseTime = Convert.ToInt32(value); break;
                    case __.TeacherID : _TeacherID = Convert.ToInt32(value); break;
                    case __.IsTake : _IsTake = (Education.state)Convert.ToInt32(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得选课表字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field ID = FindByName(__.ID);

            /// <summary>课程名称</summary>
            public static readonly Field CourseID = FindByName(__.CourseID);

            /// <summary>学号</summary>
            public static readonly Field StuID = FindByName(__.StuID);

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

            /// <summary>是否已选</summary>
            public static readonly Field IsTake = FindByName(__.IsTake);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得选课表字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String ID = "ID";

            /// <summary>课程名称</summary>
            public const String CourseID = "CourseID";

            /// <summary>学号</summary>
            public const String StuID = "StuID";

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

            /// <summary>是否已选</summary>
            public const String IsTake = "IsTake";
        }
        #endregion
    }

    /// <summary>选课表接口</summary>
    public partial interface ISelectCourse
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 ID { get; set; }

        /// <summary>课程名称</summary>
        String CourseID { get; set; }

        /// <summary>学号</summary>
        Int32 StuID { get; set; }

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

        /// <summary>是否已选</summary>
        Education.state IsTake { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}