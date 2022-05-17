using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace code_test.Models
{
    public class T_CATEGORY
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CID { get; set; }

        [Required]
        [MaxLength(250)]
        public string CATEGORY { get; set; }
        
        [MaxLength(100)]
        public string CREATED_BY { get; set; }
        public DateTime CREATION_DATE { get; set; }

        [MaxLength(50)]
        public string FEE_CODE { get; set; }
        [MaxLength(50)]
        public string SERVICE_TYPE{ get; set; }
    }
}