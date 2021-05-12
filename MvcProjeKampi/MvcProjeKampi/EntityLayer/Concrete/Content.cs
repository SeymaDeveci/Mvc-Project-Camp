using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    {
        [Key]
        public int ContentID { get; set; }

        [StringLength(1000)]
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }
        //ContentYazar
        //ContentBaşlık

        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; } //Content ile Heading ilişkili oldu

        public int? WriterID { get; set; } //int sonuna ? ekleyince nullable type olur.İçerik kısmında yazar id null değeri de alabilir.
        public virtual Writer Writer { get; set; } //Yazar ile Content ilişkili oldu
    }
}
