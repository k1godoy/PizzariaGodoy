using System.ComponentModel.DataAnnotations;

namespace Pizzaria_Godoy.Data
{
    public class Category
{
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor entre com um nome...")]
            public string Name { get; set; }
 }
}
