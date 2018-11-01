using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDataConsole.Entities
{
    //Населені Пункти
    [Table("tblSettlements")]

    public class ESettlement
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(maximumLength: 250)]
        public string Name { get; set; }
        [ForeignKey("Code")]
        public int SettlementCodeId { get; set; }
        public virtual ESettlementTypeCode Code { get; set; }
    }
}
