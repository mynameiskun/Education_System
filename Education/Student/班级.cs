using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace NewLife.School.Enity
{
    /// <summary>班级</summary>
    [Serializable]
    [DataObject]
    [Description("班级")]
    [BindIndex("IX_Class_Name", false, "Name")]
    [BindTable("Class", Description = "班级", ConnName = "Membership", DbType = DatabaseType.SqlServer)]
    public partial class Class : IClass
    {
        #region 属性
        private Int32 _ID;
        /// <summary>班级编号</summary>
        [DisplayName("班级编号")]
        [Description("班级编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("ID", "班级编号", "int")]
        public Int32 ID { get { return _ID; } set { if (OnPropertyChanging(__.ID, value)) { _ID = value; OnPropertyChanged(__.ID); } } }

        private String _Name;
        /// <summary>班级名称</summary>
        [DisplayName("班级名称")]
        [Description("班级名称")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Name", "班级名称", "nvarchar(50)", Master = true)]
        public String Name { get { return _Name; } set { if (OnPropertyChanging(__.Name, value)) { _Name = value; OnPropertyChanged(__.Name); } } }

        private Int32 _DptID;
        /// <summary>系部</summary>
        [DisplayName("系部")]
        [Description("系部")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("DptID", "系部", "int")]
        public Int32 DptID { get { return _DptID; } set { if (OnPropertyChanging(__.DptID, value)) { _DptID = value; OnPropertyChanged(__.DptID); } } }

        private Int32 _TeacherID;
        /// <summary>教师</summary>
        [DisplayName("教师")]
        [Description("教师")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("TeacherID", "教师", "int")]
        public Int32 TeacherID { get { return _TeacherID; } set { if (OnPropertyChanging(__.TeacherID, value)) { _TeacherID = value; OnPropertyChanged(__.TeacherID); } } }

        private Int32 _MajorID;
        /// <summary>专业</summary>
        [DisplayName("专业")]
        [Description("专业")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("MajorID", "专业", "int")]
        public Int32 MajorID { get { return _MajorID; } set { if (OnPropertyChanging(__.MajorID, value)) { _MajorID = value; OnPropertyChanged(__.MajorID); } } }
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
                    case __.DptID : return _DptID;
                    case __.TeacherID : return _TeacherID;
                    case __.MajorID : return _MajorID;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.ID : _ID = Convert.ToInt32(value); break;
                    case __.Name : _Name = Convert.ToString(value); break;
                    case __.DptID : _DptID = Convert.ToInt32(value); break;
                    case __.TeacherID : _TeacherID = Convert.ToInt32(value); break;
                    case __.MajorID : _MajorID = Convert.ToInt32(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得班级字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>班级编号</summary>
            public static readonly Field ID = FindByName(__.ID);

            /// <summary>班级名称</summary>
            public static readonly Field Name = FindByName(__.Name);

            /// <summary>系部</summary>
            public static readonly Field DptID = FindByName(__.DptID);

            /// <summary>教师</summary>
            public static readonly Field TeacherID = FindByName(__.TeacherID);

            /// <summary>专业</summary>
            public static readonly Field MajorID = FindByName(__.MajorID);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得班级字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>班级编号</summary>
            public const String ID = "ID";

            /// <summary>班级名称</summary>
            public const String Name = "Name";

            /// <summary>系部</summary>
            public const String DptID = "DptID";

            /// <summary>教师</summary>
            public const String TeacherID = "TeacherID";

            /// <summary>专业</summary>
            public const String MajorID = "MajorID";
        }
        #endregion
    }

    /// <summary>班级接口</summary>
    public partial interface IClass
    {
        #region 属性
        /// <summary>班级编号</summary>
        Int32 ID { get; set; }

        /// <summary>班级名称</summary>
        String Name { get; set; }

        /// <summary>系部</summary>
        Int32 DptID { get; set; }

        /// <summary>教师</summary>
        Int32 TeacherID { get; set; }

        /// <summary>专业</summary>
        Int32 MajorID { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}