using System.ComponentModel.DataAnnotations.Schema;

namespace DevOpsLyntale.Models
{
    [Table("public.items")]
    public class Item
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("value")]
        public string Value { get; set; }
    }
}
