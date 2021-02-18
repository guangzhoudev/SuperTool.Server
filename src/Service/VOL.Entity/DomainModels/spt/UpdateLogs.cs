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
    [Entity(TableCnName = "版本更新",TableName = "UpdateLogs")]
    public class UpdateLogs:BaseEntity
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
       ///代码
       /// </summary>
       [Display(Name ="代码")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string ProductCode { get; set; }

       /// <summary>
       ///名称
       /// </summary>
       [Display(Name ="名称")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string ProductName { get; set; }

       /// <summary>
       ///版本
       /// </summary>
       [Display(Name ="版本")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Version { get; set; }

       /// <summary>
       ///路径
       /// </summary>
       [Display(Name ="路径")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string FilePath { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [Column(TypeName="nvarchar(max)")]
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
       [Required(AllowEmptyStrings=false)]
       public string Creator { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       [Required(AllowEmptyStrings=false)]
       public DateTime CreateDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyID")]
       [Column(TypeName="int")]
       public int? ModifyID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Modifier")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string Modifier { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyDate")]
       [Column(TypeName="datetime")]
       public DateTime? ModifyDate { get; set; }

       
    }
}