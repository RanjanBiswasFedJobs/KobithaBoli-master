using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KobithaBoli.Model
{
    public class Poem
    {
        public int PoemId { get; set; }
        public string Title { get; set; }

        public string Author { get; set; }

        public DateTime CreateDate { get; set; }

        [Column(TypeName = "ntext")]
        [MaxLength]
        public string Contennt { get; set; } 



    }
}
