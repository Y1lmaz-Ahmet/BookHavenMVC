using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookHavenMVCUI.Models
{
	[Table("Order")]
	public class Order
	{
        public int Id { get; set; }
        [Required]
		public string UserId { get; set; }
		[Required]
		public DateTime CreateDate { get; set; } = DateTime.UtcNow;
		[Required]
		public int OderStatusId { get; set; }
		public bool IsDeleted { get; set; } = false;
        public OrderStatus OrderStatus { get; set; }
        public List<OrderDetail> OrderDetail { get; set; }

    }
}
