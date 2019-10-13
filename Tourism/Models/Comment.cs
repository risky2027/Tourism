using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tourism.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int Mark { get; set; }
        public string TextComment { get; set; }
        public DateTime DateOfComment { get; set; }
        public int? OfferId { get; set; }
        public Offer Offer { get; set; }
    }
}
