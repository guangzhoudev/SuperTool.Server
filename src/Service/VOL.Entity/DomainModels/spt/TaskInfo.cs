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
    [Entity(TableCnName = "定时任务",TableName = "TaskInfo")]
    public class TaskInfo:BaseEntity
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
       ///任务编号
       /// </summary>
       [Display(Name ="任务编号")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string TaskNo { get; set; }

       /// <summary>
       ///分组名称
       /// </summary>
       [Display(Name ="分组名称")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string TaskGroupName { get; set; }

       /// <summary>
       ///任务名称
       /// </summary>
       [Display(Name ="任务名称")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string TaskName { get; set; }

       /// <summary>
       ///任务地址
       /// </summary>
       [Display(Name ="任务地址")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string TaskUrl { get; set; }

       /// <summary>
       ///任务表达式
       /// </summary>
       [Display(Name ="任务表达式")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string TaskExpression { get; set; }

       /// <summary>
       ///任务状态
       /// </summary>
       [Display(Name ="任务状态")]
       [Column(TypeName="bit")]
       [Editable(true)]
       public bool? Status { get; set; }

       /// <summary>
       ///授权账号
       /// </summary>
       [Display(Name ="授权账号")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string Account { get; set; }

       /// <summary>
       ///授权密码
       /// </summary>
       [Display(Name ="授权密码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string Password { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       public DateTime? CreateDate { get; set; }

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