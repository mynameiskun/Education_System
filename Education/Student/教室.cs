using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace NewLife.School.Enity
{
    /// <summary>教室</summary>
    [Serializable]
    [DataObject]
    [Description("教室")]
    [BindTable("ClassRoom", Description = "教室", ConnName = "Membership", DbType = DatabaseType.SqlServer)]
    public partial class ClassRoom : IClassRoom
    {
        #region 属性
        private Int32 _ID;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("ID", "编号", "int")]
        public Int32 ID { get { return _ID; } set { if (OnPropertyChanging(__.ID, value)) { _ID = value; OnPropertyChanged(__.ID); } } }

        private String _RoomName;
        /// <summary>教室名称</summary>
        [DisplayName("教室名称")]
        [Description("教室名称")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("RoomName", "教室名称", "nvarchar(50)")]
        public String RoomName { get { return _RoomName; } set { if (OnPropertyChanging(__.RoomName, value)) { _RoomName = value; OnPropertyChanged(__.RoomName); } } }

        private Int32 _StuNumber;
        /// <summary>容纳人数</summary>
        [DisplayName("容纳人数")]
        [Description("容纳人数")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("StuNumber", "容纳人数", "int")]
        public Int32 StuNumber { get { return _StuNumber; } set { if (OnPropertyChanging(__.StuNumber, value)) { _StuNumber = value; OnPropertyChanged(__.StuNumber); } } }
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
                    case __.RoomName : return _RoomName;
                    case __.StuNumber : return _StuNumber;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.ID : _ID = Convert.ToInt32(value); break;
                    case __.RoomName : _RoomName = Convert.ToString(value); break;
                    case __.StuNumber : _StuNumber = Convert.ToInt32(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得教室字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field ID = FindByName(__.ID);

            /// <summary>教室名称</summary>
            public static readonly Field RoomName = FindByName(__.RoomName);

            /// <summary>容纳人数</summary>
            public static readonly Field StuNumber = FindByName(__.StuNumber);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得教室字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String ID = "ID";

            /// <summary>教室名称</summary>
            public const String RoomName = "RoomName";

            /// <summary>容纳人数</summary>
            public const String StuNumber = "StuNumber";
        }
        #endregion
    }

    /// <summary>教室接口</summary>
    public partial interface IClassRoom
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 ID { get; set; }

        /// <summary>教室名称</summary>
        String RoomName { get; set; }

        /// <summary>容纳人数</summary>
        Int32 StuNumber { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}