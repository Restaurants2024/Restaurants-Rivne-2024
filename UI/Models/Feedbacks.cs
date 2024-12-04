namespace UI.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string PersonId { get; set; }
        public virtual Person Person { get; set; }
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public int TableNum { get; set; }
        public DateTime Date { get; set; }
    }

}
