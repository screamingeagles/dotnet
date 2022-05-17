using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace code_test.Models
{
    public class T_DESIGNATION
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DESIGNATION_ID { get; set; }

        [Required]
        [MaxLength(250)]
        public string DESIGNATION { get; set; }

        [Required]
        public int CATEGORY_ID { get; set; }

        [MaxLength(150)]
        public string CREATED_BY { get; set; }
        public DateTime CREATION_DATE { get; set; }

        [MaxLength(150)]
        public string MODIFIED_BY { get; set; }
        public DateTime? MODIFIED_DATE { get; set; }

    }
}