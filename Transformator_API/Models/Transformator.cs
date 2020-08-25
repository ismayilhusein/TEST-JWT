using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Transformator_API.Models
{
    public class Transformator
    {
        [Key]
        public int ID_SEQ { get; set; }
        [MaxLength(50)]
        public string NAME { get; set; }
        [MaxLength(50)]
        public string TM_NO { get; set; }
        public int INVENTAR_CODE { get; set; }
        public int KWA { get; set; }
        public int SALES_DIVISIONID { get; set; }
        [MaxLength(100)]
        public string ADDRESS { get; set; }
        [Column(TypeName = "Date")]
        [DataType(DataType.Date)]
        public DateTime DATE_PRODUCED { get; set; }
        [MaxLength(1)]
        public string STATUS { get; set; }
        public int COPPER_LOSS { get; set; }
        [MaxLength(1)]
        public string IS_PUBLIC { get; set; }
        public int FEEDER_NO { get; set; }
        [MaxLength(100)]
        public string ISTISMAR_MUDDETI { get; set; }
        [MaxLength(50)]
        public string X { get; set; }
        [MaxLength(50)]
        public string Y { get; set; }
        public int MIQDARI { get; set; }
        public int ESAS_VESAITIN_ILKIN_DEYERI { get; set; }
        public int QALIQ_DEYERI { get; set; }
        [MaxLength(100)]
        public string RAYON { get; set; }
        public int YS_TM_NOMRESI { get; set; }
    }
}
