using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tourism.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string TextOfOffer { get; set; }
        public DateTime DateOfOfferFrom { get; set; }
        public DateTime DateOfOfferTo { get; set; }
        public DateTime DateOfOffer { get; set; }
        public int Price { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public List<Comment> Comments { get; set; }
        public Offer()
        {
            Comments = new List<Comment>();
        }
    }
}
