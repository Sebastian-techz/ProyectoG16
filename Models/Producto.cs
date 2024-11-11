using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace G16.Models
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Indica que el Id es autoincrementable
        public int Id {  get; set; }
        public required string Nombre { get; set; }
        public required string Descripcion {  get; set; }
        public decimal Precio {  get; set; }


    }
}
