using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngxsis.Model
{
    [Table("x_menu_access")]
    public class x_menu_access
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long menu_access_id { get; set; }

        public long role_id { get; set; }

        public long created_by { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime created_on { get; set; }

        public long modified_by { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime modified_on { get; set; }

        public long deleted_by { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime deleted_on { get; set; }

        public Boolean is_delete { get; set; }
    }
}
