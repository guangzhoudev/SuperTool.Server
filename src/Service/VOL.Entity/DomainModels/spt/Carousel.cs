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
    [Entity(TableCnName = "轮播设置",TableName = "Carousel")]
    public class Carousel:BaseEntity
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
       ///名称
       /// </summary>
       [Display(Name ="名称")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string Name { get; set; }

       /// <summary>
       ///图片地址
       /// </summary>
       [Display(Name ="图片地址")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ImgPath { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string Remark { get; set; }

       /// <summary>
       ///跳转链接
       /// </summary>
       [Display(Name ="跳转链接")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string Url { get; set; }

       /// <summary>
       ///禁用状态
       /// </summary>
       [Display(Name ="禁用状态")]
       [Column(TypeName="bit")]
       [Editable(true)]
       public bool? Disable { get; set; }

       /// <summary>
       ///发生时间
       /// </summary>
       [Display(Name ="发生时间")]
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