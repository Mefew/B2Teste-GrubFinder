using System.ComponentModel.DataAnnotations.Schema;

namespace GrubFinder.Domain.Entities
{
    public class Product
    {
        public int Id {  get; set; }
        [ForeignKey("RestaurantId")]
        public Restaurant RestaurantId { get; set; }
    }
}
