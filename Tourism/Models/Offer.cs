using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tourism.Models
{
    public class Offer
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Не указан город")]
        [DisplayName("Город")]
        public string City { get; set; }
        [Required(ErrorMessage = "Не указано описание")]
        [DisplayName("Описание")]
        public string TextOfOffer { get; set; }
        [Required(ErrorMessage = "Не указана дата начала")]
        [DisplayName("Дата начала")]
        public DateTime DateOfOfferFrom { get; set; }
        [Required(ErrorMessage = "Не указана дата окончания")]
        [DisplayName("Дата окончания")]
        public DateTime DateOfOfferTo { get; set; }
        [DisplayName("Дата создания")]
        public DateTime DateOfOffer { get; set; }
        [Required(ErrorMessage = "Не указана стоимость")]
        [DisplayName("Стоимость (руб)")]
        public int Price { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public List<Comment> Comments { get; set; }
        public int? TypeOfferId { get; set; }
        public TypeOffer TypeOffer { get; set; }
        public Offer()
        {
            Comments = new List<Comment>();
        }
    }
}
