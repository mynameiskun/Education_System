using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace NewLife.School.Enity
{
    /// <summary>课表</summary>
    [Serializable]
    [DataObject]
    [Description("课表")]
    [BindTable("CsTable", Description = "课表", ConnName = "Membership", DbType = DatabaseType.SqlServer)]
    public partial class CsTable : ICsTable
    {
        #region 属性
        private Int32 _ID;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("ID", "编号", "int")]
        public Int32 ID { get { return _ID; } set { if (OnPropertyChanging(__.ID, value)) { _ID = value; OnPropertyChanged(__.ID); } } }

        private String _Time;
        /// <summary>时间段</summary>
        [DisplayName("时间段")]
        [Description("时间段")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Time", "时间段", "nvarchar(50)", Master = true)]
        public String Time { get { return _Time; } set { if (OnPropertyChanging(__.Time, value)) { _Time = value; OnPropertyChanged(__.Time); } } }

        private String _CourseName;
        /// <summary>课程名</summary>
        [DisplayName("课程名")]
        [Description("课程名")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("CourseName", "课程名", "nvarchar(50)")]
        public String CourseName { get { return _CourseName; } set { if (OnPropertyChanging(__.CourseName, value)) { _CourseName = value; OnPropertyChanged(__.CourseName); } } }

        private String _Techaer;
        /// <summary>教师</summary>
        [DisplayName("教师")]
        [Description("教师")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Techaer", "教师", "nvarchar(50)")]
        public String Techaer { get { return _Techaer; } set { if (OnPropertyChanging(__.Techaer, value)) { _Techaer = value; OnPropertyChanged(__.Techaer); } } }

        private String _ClassRoom;
        /// <summary>教室</summary>
        [DisplayName("教室")]
        [Description("教室")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("ClassRoom", "教室", "nvarchar(50)")]
        public String ClassRoom { get { return _ClassRoom; } set { if (OnPropertyChanging(__.ClassRoom, value)) { _ClassRoom = value; OnPropertyChanged(__.ClassRoom); } } }

        private String _Classm;
        /// <summary>班级</summary>
        [DisplayName("班级")]
        [Description("班级")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Classm", "班级", "nvarchar(50)")]
        public String Classm { get { return _Classm; } set { if (OnPropertyChanging(__.Classm, value)) { _Classm = value; OnPropertyChanged(__.Classm); } } }
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
                    case __.Time : return _Time;
                    case __.CourseName : return _CourseName;
                    case __.Techaer : return _Techaer;
                    case __.ClassRoom : return _ClassRoom;
                    case __.Classm : return _Classm;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.ID : _ID = Convert.ToInt32(value); break;
                    case __.Time : _Time = Convert.ToString(value); break;
                    case __.CourseName : _CourseName = Convert.ToString(value); break;
                    case __.Techaer : _Techaer = Convert.ToString(value); break;
                    case __.ClassRoom : _ClassRoom = Convert.ToString(value); break;
                    case __.Classm : _Classm = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得课表字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field ID = FindByName(__.ID);

            /// <summary>时间段</summary>
            public static readonly Field Time = FindByName(__.Time);

            /// <summary>课程名</summary>
            public static readonly Field CourseName = FindByName(__.CourseName);

            /// <summary>教师</summary>
            public static readonly Field Techaer = FindByName(__.Techaer);

            /// <summary>教室</summary>
            public static readonly Field ClassRoom = FindByName(__.ClassRoom);

            /// <summary>班级</summary>
            public static readonly Field Classm = FindByName(__.Classm);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得课表字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String ID = "ID";

            /// <summary>时间段</summary>
            public const String Time = "Time";

            /// <summary>课程名</summary>
            public const String CourseName = "CourseName";

            /// <summary>教师</summary>
            public const String Techaer = "Techaer";

            /// <summary>教室</summary>
            public const String ClassRoom = "ClassRoom";

            /// <summary>班级</summary>
            public const String Classm = "Classm";
        }
        #endregion
    }

    /// <summary>课表接口</summary>
    public partial interface ICsTable
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 ID { get; set; }

        /// <summary>时间段</summary>
        String Time { get; set; }

        /// <summary>课程名</summary>
        String CourseName { get; set; }

        /// <summary>教师</summary>
        String Techaer { get; set; }

        /// <summary>教室</summary>
        String ClassRoom { get; set; }

        /// <summary>班级</summary>
        String Classm { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}