using System.ComponentModel.DataAnnotations;

namespace products.models
{
    public class customer
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? stityockqwant { get; set; }
        public List<order>? orders { get; set; }
        public int? shopingcartid { get; set; }
        public shpoingcart? shpoingcart { get; set; }


    }
}
