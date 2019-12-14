using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tourism.Models
{
    public class TypeOffer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Не указан тип предложения")]
        [DisplayName("Предложение")]
        public string Name { get; set; }
        public List<Offer> Offers { get; set; }
        public TypeOffer()
        {
            Offers = new List<Offer>();
        }
    }
}
