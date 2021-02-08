using System.ComponentModel.DataAnnotations;

namespace FirstDotNetCoreApp.Models
{
    public class Product
    {
        [Key]
        public long ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RowStatus { get; set; }
    }
}