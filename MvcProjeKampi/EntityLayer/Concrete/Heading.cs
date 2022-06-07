using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }

        [StringLength(50)]
        public string HeadingName { get; set; }


        public DateTime HeadingDate { get; set; }

        public bool HeadingStatus { get; set; }

        //Category ile ilişkili
        public int CategoryID { get; set; } //Kurduğumuz ilişki tablosu ile aynı isimde olması gerekiyor. (Primary Key ile aynı)
        public virtual Category Category { get; set; }

        //Writer ile ilişkili
        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }

        public ICollection<Content> Contents { get; set; }



    }
}
