using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UI.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public double PointX { get; set; }
        public double PointY { get; set; }

        public string Title { get; set; }
        public byte[] Photo { get; set; }
        public int Stars { get; set; }
        public string WorkSchedule { get; set; }

        [MaxLength(2000)]
        public string ShortDescription { get; set; }
		public string DescriptionRating { get; set; }
		public string Description { get; set; }
		public string LinksRating { get; set; }
		public string FavoriteLinks { get; set; }
        public string TelNum { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
        public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
    }

}
