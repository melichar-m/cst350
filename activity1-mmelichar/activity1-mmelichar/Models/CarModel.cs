using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace activity1_mmelichar.Models
{
    public class CarModel
    {
        [DisplayName("Id number")]
        public int Id { get; set; }
        [DisplayName("Car Name")]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        [DisplayName("Cost to customer")]
        public decimal Price { get; set; }
        [DisplayName("What you get...")]
        public string Description { get; set; }

        public CarModel(int id, string name, decimal price, string description)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
        }
        public CarModel()
        {

        }
    }
}