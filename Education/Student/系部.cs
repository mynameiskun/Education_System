using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace NewLife.School.Enity
{
    /// <summary>系部</summary>
    [Serializable]
    [DataObject]
    [Description("系部")]
    [BindIndex("IX_Dpt_Name", false, "Name")]
    [BindTable("Dpt", Description = "系部", ConnName = "Membership", DbType = DatabaseType.SqlServer)]
    public partial class Dpt : IDpt
    {
        #region 属性
        private Int32 _ID;
        /// <summary>系部代码</summary>
        [DisplayName("系部代码")]
        [Description("系部代码")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("ID", "系部代码", "int")]
        public Int32 ID { get { return _ID; } set { if (OnPropertyChanging(__.ID, value)) { _ID = value; OnPropertyChanged(__.ID); } } }

        private String _Name;
        /// <summary>系部名称</summary>
        [DisplayName("系部名称")]
        [Description("系部名称")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Name", "系部名称", "nvarchar(50)", Master = true)]
        public String Name { get { return _Name; } set { if (OnPropertyChanging(__.Name, value)) { _Name = value; OnPropertyChanged(__.Name); } } }

        private String _Dptdescription;
        /// <summary>系部介绍</summary>
        [DisplayName("系部介绍")]
        [Description("系部介绍")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Dptdescription", "系部介绍", "nvarchar(50)")]
        public String Dptdescription { get { return _Dptdescription; } set { if (OnPropertyChanging(__.Dptdescription, value)) { _Dptdescription = value; OnPropertyChanged(__.Dptdescription); } } }
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
                    case __.Dptdescription : return _Dptdescription;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.ID : _ID = Convert.ToInt32(value); break;
                    case __.Name : _Name = Convert.ToString(value); break;
                    case __.Dptdescription : _Dptdescription = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得系部字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>系部代码</summary>
            public static readonly Field ID = FindByName(__.ID);

            /// <summary>系部名称</summary>
            public static readonly Field Name = FindByName(__.Name);

            /// <summary>系部介绍</summary>
            public static readonly Field Dptdescription = FindByName(__.Dptdescription);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得系部字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>系部代码</summary>
            public const String ID = "ID";

            /// <summary>系部名称</summary>
            public const String Name = "Name";

            /// <summary>系部介绍</summary>
            public const String Dptdescription = "Dptdescription";
        }
        #endregion
    }

    /// <summary>系部接口</summary>
    public partial interface IDpt
    {
        #region 属性
        /// <summary>系部代码</summary>
        Int32 ID { get; set; }

        /// <summary>系部名称</summary>
        String Name { get; set; }

        /// <summary>系部介绍</summary>
        String Dptdescription { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}