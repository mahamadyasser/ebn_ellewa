using System.ComponentModel.DataAnnotations;

namespace products.models
{
    public class product
    {
        [Key]
        public int Id { get; set; }
        public int? totalprice { get; set; }
        public int? orderid { get; set; }
        public order? order { get; set; }

    }
}
