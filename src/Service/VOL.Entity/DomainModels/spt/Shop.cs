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
    [Entity(TableCnName = "店铺管理",TableName = "Shop")]
    public class Shop:BaseEntity
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
       ///公司名称
       /// </summary>
       [Display(Name ="公司名称")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string CustomerName { get; set; }

       /// <summary>
       ///店铺名称
       /// </summary>
       [Display(Name ="店铺名称")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Editable(true)]
       public string ShopName { get; set; }

       /// <summary>
       ///联系人
       /// </summary>
       [Display(Name ="联系人")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       public string Contact { get; set; }

       /// <summary>
       ///店铺类型
       /// </summary>
       [Display(Name ="店铺类型")]
       [MaxLength(40)]
       [Column(TypeName="nvarchar(40)")]
       [Editable(true)]
       public string Type { get; set; }

       /// <summary>
       ///绑定时间
       /// </summary>
       [Display(Name ="绑定时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? BindTime { get; set; }

       /// <summary>
       ///店铺地址
       /// </summary>
       [Display(Name ="店铺地址")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Editable(true)]
       public string Address { get; set; }

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