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
    [Entity(TableCnName = "分销商管理",TableName = "Extend")]
    public class Extend:BaseEntity
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
       ///推广人ID
       /// </summary>
       [Display(Name ="推广人ID")]
       [Column(TypeName="int")]
       public int? PromotersID { get; set; }

       /// <summary>
       ///推广人
       /// </summary>
       [Display(Name ="推广人")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string Promoters { get; set; }

       /// <summary>
       ///被推广人ID
       /// </summary>
       [Display(Name ="被推广人ID")]
       [Column(TypeName="int")]
       public int? PromoteesID { get; set; }

       /// <summary>
       ///被推广人
       /// </summary>
       [Display(Name ="被推广人")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string Promotees { get; set; }

       /// <summary>
       ///推荐码
       /// </summary>
       [Display(Name ="推荐码")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ReferralCode { get; set; }

       /// <summary>
       ///推广时间
       /// </summary>
       [Display(Name ="推广时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ExtendDate { get; set; }

       /// <summary>
       ///推广奖励金
       /// </summary>
       [Display(Name ="推广奖励金")]
       [DisplayFormat(DataFormatString="18,2")]
       [Column(TypeName="decimal")]
       [Editable(true)]
       public decimal? Price { get; set; }

       /// <summary>
       ///创建人ID
       /// </summary>
       [Display(Name ="创建人ID")]
       [Column(TypeName="int")]
       public int? CreateID { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string Creator { get; set; }

       /// <summary>
       ///编辑时间
       /// </summary>
       [Display(Name ="编辑时间")]
       [Column(TypeName="datetime")]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///编辑人
       /// </summary>
       [Display(Name ="编辑人")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       public string Modifier { get; set; }

       /// <summary>
       ///编辑人ID
       /// </summary>
       [Display(Name ="编辑人ID")]
       [Column(TypeName="int")]
       public int? ModifyID { get; set; }

       
    }
}