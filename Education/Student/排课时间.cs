using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace NewLife.School.Enity
{
    /// <summary>排课时间</summary>
    [Serializable]
    [DataObject]
    [Description("排课时间")]
    [BindIndex("IX_CsTime_Name", false, "Name")]
    [BindTable("CsTime", Description = "排课时间", ConnName = "Membership", DbType = DatabaseType.SqlServer)]
    public partial class CsTime : ICsTime
    {
        #region 属性
        private Int32 _ID;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("ID", "编号", "int")]
        public Int32 ID { get { return _ID; } set { if (OnPropertyChanging(__.ID, value)) { _ID = value; OnPropertyChanged(__.ID); } } }

        private String _Name;
        /// <summary>时间段</summary>
        [DisplayName("时间段")]
        [Description("时间段")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Name", "时间段", "nvarchar(50)", Master = true)]
        public String Name { get { return _Name; } set { if (OnPropertyChanging(__.Name, value)) { _Name = value; OnPropertyChanged(__.Name); } } }

        private String _Descrip;
        /// <summary>描述</summary>
        [DisplayName("描述")]
        [Description("描述")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Descrip", "描述", "nvarchar(50)", Master = true)]
        public String Descrip { get { return _Descrip; } set { if (OnPropertyChanging(__.Descrip, value)) { _Descrip = value; OnPropertyChanged(__.Descrip); } } }
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
                    case __.Descrip : return _Descrip;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.ID : _ID = Convert.ToInt32(value); break;
                    case __.Name : _Name = Convert.ToString(value); break;
                    case __.Descrip : _Descrip = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得排课时间字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field ID = FindByName(__.ID);

            /// <summary>时间段</summary>
            public static readonly Field Name = FindByName(__.Name);

            /// <summary>描述</summary>
            public static readonly Field Descrip = FindByName(__.Descrip);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得排课时间字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String ID = "ID";

            /// <summary>时间段</summary>
            public const String Name = "Name";

            /// <summary>描述</summary>
            public const String Descrip = "Descrip";
        }
        #endregion
    }

    /// <summary>排课时间接口</summary>
    public partial interface ICsTime
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 ID { get; set; }

        /// <summary>时间段</summary>
        String Name { get; set; }

        /// <summary>描述</summary>
        String Descrip { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}