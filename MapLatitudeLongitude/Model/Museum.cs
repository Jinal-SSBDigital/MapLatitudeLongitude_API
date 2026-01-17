using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MapLatitudeLongitude.Model
{
    [Table("Museum")]
    public class Museum
    {
        [Key]
        public int Museum_id { get; set; }

        public string Museum_Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Descr { get; set; }
        public string Open_time { get; set; }
        public string Close_time { get; set; }
        public decimal Ticket_price { get; set; }
        public decimal Virtual_price { get; set; }

        public decimal? latitude { get; set; }
        public decimal? longitude { get; set; }

        public bool status { get; set; }
        public int Fk_StateId { get; set; }
        public int Fk_CityId { get; set; }
    }
}
