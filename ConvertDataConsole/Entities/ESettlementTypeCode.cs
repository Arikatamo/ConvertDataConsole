using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDataConsole.Entities
{
    //Тип населенного пункту
    [Table("tblSettlementTypeCodes")]
    public class ESettlementTypeCode
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(maximumLength: 255)]
        public string Name { get; set; }
        public virtual ICollection<ESettlement> Settlements { get; set; }
    }
}
