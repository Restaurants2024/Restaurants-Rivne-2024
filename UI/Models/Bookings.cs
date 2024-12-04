namespace UI.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int TableNum { get; set; }
        public DateTime Date { get; set; }
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; } 
        public string PersonId { get; set; }
        public virtual Person Person { get; set; }
    }

}
