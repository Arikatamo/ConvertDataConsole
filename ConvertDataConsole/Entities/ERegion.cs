using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDataConsole.Entities
{
    //Район
    [Table("tblRegions")]
    public class ERegion
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(maximumLength:250)]
        public string Name { get; set; }
        [ForeignKey("Area")]
        //ІД області
        public int AreaId { get; set; }
        //Область
        public virtual EArea  Area { get; set; }
    }
}
