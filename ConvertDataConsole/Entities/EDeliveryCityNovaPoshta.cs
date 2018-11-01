using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDataConsole.Entities
{
    //Населені Пункти пункт Призначення Нова Почта
    [Table("tblDeliveryCityNovaPoshtas")]
    public  class EDeliveryCityNovaPoshta
    {
        [Key,ForeignKey("Settlement")]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        public virtual ESettlement Settlement { get; set; }
    }
}
