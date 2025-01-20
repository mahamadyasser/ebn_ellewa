using System.ComponentModel.DataAnnotations;

namespace products.models
{
    public class order
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string contact { get; set; }
        public string email { get; set; }
        public int customerid { get; set; }
        public customer customer { get; set; }
        public List<product> products { get; set; }
        
    }
}
