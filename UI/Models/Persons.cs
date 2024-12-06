using Microsoft.AspNetCore.Identity;

namespace UI.Models
{
    public class Person : IdentityUser
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string ThirdName { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
        public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
    }


}
