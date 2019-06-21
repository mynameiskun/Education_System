using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;
using NewLife;
using NewLife.Data;
using NewLife.Log;
using NewLife.Model;
using NewLife.Reflection;
using NewLife.Threading;
using NewLife.Web;
using XCode;
using XCode.Cache;
using XCode.Configuration;
using XCode.DataAccessLayer;
using XCode.Membership;

namespace NewLife.School.Enity
{
    /// <summary>选课表</summary>
    public partial class SelectCourse : Entity<SelectCourse>
    {
        #region 对象操作
        static SelectCourse()
        {
            // 累加字段
            //Meta.Factory.AdditionalFields.Add(__.Logins);

            // 过滤器 UserModule、TimeModule、IPModule
        }

        /// <summary>验证数据，通过抛出异常的方式提示验证失败。</summary>
        /// <param name="isNew">是否插入</param>
        public override void Valid(Boolean isNew)
        {
            // 如果没有脏数据，则不需要进行任何处理
            if (!HasDirty) return;

            // 在新插入数据或者修改了指定字段时进行修正
        }

        ///// <summary>首次连接数据库时初始化数据，仅用于实体类重载，用户不应该调用该方法</summary>
        //[EditorBrowsable(EditorBrowsableState.Never)]
        //protected override void InitData()
        //{
        //    // InitData一般用于当数据表没有数据时添加一些默认数据，该实体类的任何第一次数据库操作都会触发该方法，默认异步调用
        //    if (Meta.Session.Count > 0) return;

        //    if (XTrace.Debug) XTrace.WriteLine("开始初始化SelectCourse[选课表]数据……");

        //    var entity = new SelectCourse();
        //    entity.ID = 0;
        //    entity.CourseID = "abc";
        //    entity.StudentID = 0;
        //    entity.DptID = 0;
        //    entity.MajorID = 0;
        //    entity.ClassID = 0;
        //    entity.CourseTime = 0;
        //    entity.TeacherID = 0;
        //    entity.Insert();

        //    if (XTrace.Debug) XTrace.WriteLine("完成初始化SelectCourse[选课表]数据！");
        //}

        ///// <summary>已重载。基类先调用Valid(true)验证数据，然后在事务保护内调用OnInsert</summary>
        ///// <returns></returns>
        //public override Int32 Insert()
        //{
        //    return base.Insert();
        //}

        ///// <summary>已重载。在事务保护范围内处理业务，位于Valid之后</summary>
        ///// <returns></returns>
        //protected override Int32 OnDelete()
        //{
        //    return base.OnDelete();
        //}
        #endregion

        #region 扩展属性
        /// <summary>必修_选修</summary>

        /// <summary>系部</summary>
        [XmlIgnore]
        //[ScriptIgnore]
        public Dpt Dpt { get { return Extends.Get(nameof(Dpt), k => Dpt.FindByID(DptID)); } }

        /// <summary>系部</summary>
        [XmlIgnore]
        //[ScriptIgnore]
        [DisplayName("系部")]
        [Map(__.DptID, typeof(Dpt), "ID")]
        public String DptName { get { return Dpt?.Name; } }
        /// <summary>专业</summary>
        [XmlIgnore]
        //[ScriptIgnore]
        public Major Major { get { return Extends.Get(nameof(Major), k => Major.FindByID(MajorID)); } }

        /// <summary>专业</summary>
        [XmlIgnore]
        //[ScriptIgnore]
        [DisplayName("专业")]
        [Map(__.MajorID, typeof(Major), "ID")]
        public String MajorName { get { return Major?.Name; } }
        /// <summary>班级</summary>
        [XmlIgnore]
        //[ScriptIgnore]
        public Class Class { get { return Extends.Get(nameof(Class), k => Class.FindByID(ClassID)); } }

        /// <summary>班级</summary>
        [XmlIgnore]
        //[ScriptIgnore]
        [DisplayName("班级")]
        [Map(__.ClassID, typeof(Class), "ID")]
        public String ClassName { get { return Class?.Name; } }
        /// <summary>开课教师ID</summary>
        [XmlIgnore]
        //[ScriptIgnore]
        public Teacher Teacher { get { return Extends.Get(nameof(Teacher), k => Teacher.FindByID(TeacherID)); } }

        /// <summary>开课教师ID</summary>
        [XmlIgnore]
        //[ScriptIgnore]
        [DisplayName("开课教师ID")]
        [Map(__.TeacherID, typeof(Teacher), "ID")]
        public String TeacherName { get { return Teacher?.Name; } }
        #endregion

        #region 扩展查询
        /// <summary>根据编号查找</summary>
        /// <param name="id">编号</param>
        /// <returns>实体对象</returns>
        public static SelectCourse FindByID(Int32 id)
        {
            if (id <= 0) return null;

            // 实体缓存
            if (Meta.Session.Count < 1000) return Meta.Cache.Find(e => e.ID == id);

            // 单对象缓存
            //return Meta.SingleCache[id];

            return Find(_.ID == id);
        }
        #endregion

        #region 高级查询
        #endregion

        #region 业务操作
        #endregion
    }
}