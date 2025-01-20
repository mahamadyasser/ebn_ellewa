using System.ComponentModel.DataAnnotations;

namespace products.models
{
    public class shpoingcart  
    {
        [Key]
        public int id { get; set; }
        public int? nemberofproducts { get; set; }
        public int? customerid {  get; set; }
        public customer customer { get; set; }
    }
}
