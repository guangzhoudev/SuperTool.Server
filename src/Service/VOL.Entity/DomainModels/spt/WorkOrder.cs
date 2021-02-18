/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果数据库字段发生变化，请在代码生器重新生成此Model
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VOL.Entity.SystemModels;

namespace VOL.Entity.DomainModels
{
    [Entity(TableCnName = "工单管理",TableName = "WorkOrder")]
    public class WorkOrder:BaseEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Id { get; set; }

       /// <summary>
       ///标题
       /// </summary>
       [Display(Name ="标题")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string Title { get; set; }

       /// <summary>
       ///内容
       /// </summary>
       [Display(Name ="内容")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string Contents { get; set; }

       /// <summary>
       ///类别
       /// </summary>
       [Display(Name ="类别")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string Type { get; set; }

       /// <summary>
       ///提交人账号
       /// </summary>
       [Display(Name ="提交人账号")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string Account { get; set; }

       /// <summary>
       ///状态
       /// </summary>
       [Display(Name ="状态")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string Status { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string Remark { get; set; }

       /// <summary>
       ///创建人ID
       /// </summary>
       [Display(Name ="创建人ID")]
       [Column(TypeName="int")]
       public int? CreateID { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string Creator { get; set; }

       /// <summary>
       ///创建日期
       /// </summary>
       [Display(Name ="创建日期")]
       [Column(TypeName="datetime")]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///编辑人ID
       /// </summary>
       [Display(Name ="编辑人ID")]
       [Column(TypeName="int")]
       public int? ModifyID { get; set; }

       /// <summary>
       ///编辑人
       /// </summary>
       [Display(Name ="编辑人")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string Modifier { get; set; }

       /// <summary>
       ///编辑时间
       /// </summary>
       [Display(Name ="编辑时间")]
       [Column(TypeName="datetime")]
       public DateTime? ModifyDate { get; set; }

       
    }
}