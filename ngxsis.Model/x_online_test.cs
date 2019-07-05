using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngxsis.Model
{
    [Table("x_online_test")]
    public class x_online_test
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public long online_test_id { get; set; }


        [Required(AllowEmptyStrings = false)]
        public long created_by { get; set; }


        [Column(TypeName = "DateTime")]
        [Required(AllowEmptyStrings = false)]
        public DateTime created_on { get; set; }


        [Required(AllowEmptyStrings = true)]
        public long modified_by { get; set; }


        [Column(TypeName = "DateTime")]
        [Required(AllowEmptyStrings = true)]
        public DateTime modified_on { get; set; }


        [Required(AllowEmptyStrings = true)]
        public long deleted_by { get; set; }


        [Column(TypeName = "DateTime")]
        [Required(AllowEmptyStrings = true)]
        public DateTime deleted_on { get; set; }


        public Boolean is_delete { get; set; }

        public long biodata_id { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Required(AllowEmptyStrings = true)]
        public string period_code { get; set; }


        [Required(AllowEmptyStrings = true)]
        public int period { get; set; }


        [Column(TypeName = "Date")]
        [Required(AllowEmptyStrings = true)]
        public DateTime test_date { get; set; }


        [Column(TypeName = "Date")]
        [Required(AllowEmptyStrings = true)]
        public DateTime expired_test { get; set; }


        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        [Required(AllowEmptyStrings = true)]
        public string user_access { get; set; }


        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Required(AllowEmptyStrings = true)]
        public string status { get; set; }
    }
}
