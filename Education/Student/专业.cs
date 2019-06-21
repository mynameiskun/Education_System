using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace NewLife.School.Enity
{
    /// <summary>专业</summary>
    [Serializable]
    [DataObject]
    [Description("专业")]
    [BindIndex("IX_Major_Name", false, "Name")]
    [BindTable("Major", Description = "专业", ConnName = "Membership", DbType = DatabaseType.SqlServer)]
    public partial class Major : IMajor
    {
        #region 属性
        private Int32 _ID;
        /// <summary>专业代码</summary>
        [DisplayName("专业代码")]
        [Description("专业代码")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("ID", "专业代码", "int")]
        public Int32 ID { get { return _ID; } set { if (OnPropertyChanging(__.ID, value)) { _ID = value; OnPropertyChanged(__.ID); } } }

        private String _Name;
        /// <summary>专业名称</summary>
        [DisplayName("专业名称")]
        [Description("专业名称")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Name", "专业名称", "nvarchar(50)", Master = true)]
        public String Name { get { return _Name; } set { if (OnPropertyChanging(__.Name, value)) { _Name = value; OnPropertyChanged(__.Name); } } }

        private Int32 _DptID;
        /// <summary>系部</summary>
        [DisplayName("系部")]
        [Description("系部")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("DptID", "系部", "int")]
        public Int32 DptID { get { return _DptID; } set { if (OnPropertyChanging(__.DptID, value)) { _DptID = value; OnPropertyChanged(__.DptID); } } }

        private String _Dptdescription;
        /// <summary>专业介绍</summary>
        [DisplayName("专业介绍")]
        [Description("专业介绍")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Dptdescription", "专业介绍", "nvarchar(50)")]
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
                    case __.DptID : return _DptID;
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
                    case __.DptID : _DptID = Convert.ToInt32(value); break;
                    case __.Dptdescription : _Dptdescription = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得专业字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>专业代码</summary>
            public static readonly Field ID = FindByName(__.ID);

            /// <summary>专业名称</summary>
            public static readonly Field Name = FindByName(__.Name);

            /// <summary>系部</summary>
            public static readonly Field DptID = FindByName(__.DptID);

            /// <summary>专业介绍</summary>
            public static readonly Field Dptdescription = FindByName(__.Dptdescription);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得专业字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>专业代码</summary>
            public const String ID = "ID";

            /// <summary>专业名称</summary>
            public const String Name = "Name";

            /// <summary>系部</summary>
            public const String DptID = "DptID";

            /// <summary>专业介绍</summary>
            public const String Dptdescription = "Dptdescription";
        }
        #endregion
    }

    /// <summary>专业接口</summary>
    public partial interface IMajor
    {
        #region 属性
        /// <summary>专业代码</summary>
        Int32 ID { get; set; }

        /// <summary>专业名称</summary>
        String Name { get; set; }

        /// <summary>系部</summary>
        Int32 DptID { get; set; }

        /// <summary>专业介绍</summary>
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