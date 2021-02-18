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
    [Entity(TableCnName = "支付记录",TableName = "PayLogs")]
    public class PayLogs:BaseEntity
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
       ///账号
       /// </summary>
       [Display(Name ="账号")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Account { get; set; }

       /// <summary>
       ///电话
       /// </summary>
       [Display(Name ="电话")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Tel { get; set; }

       /// <summary>
       ///金额
       /// </summary>
       [Display(Name ="金额")]
       [Column(TypeName="float")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public float Money { get; set; }

       /// <summary>
       ///代理商
       /// </summary>
       [Display(Name ="代理商")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Agent { get; set; }

       /// <summary>
       ///交易方式
       /// </summary>
       [Display(Name ="交易方式")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string PayWay { get; set; }

       /// <summary>
       ///交易时间
       /// </summary>
       [Display(Name ="交易时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public DateTime PayTime { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Remark { get; set; }

       /// <summary>
       ///交易状态
       /// </summary>
       [Display(Name ="交易状态")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string PayStatus { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateID")]
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
       ///
       /// </summary>
       [Display(Name ="ModifyDate")]
       [Column(TypeName="datetime")]
       public DateTime? ModifyDate { get; set; }

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
       [Display(Name ="ModifyID")]
       [Column(TypeName="int")]
       public int? ModifyID { get; set; }

       
    }
}