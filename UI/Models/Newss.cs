using System.ComponentModel.DataAnnotations;

namespace UI.Models
{
    public class News
    {
        public int Id { get; set; }
        public byte[] Photo { get; set; }
		
		[DataType(DataType.MultilineText)] [MaxLength(5000)] public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
		
		public string TitleBox { get; set; }
        [MaxLength(2000)] public string ShortDescription { get; set; }
        public bool ShowPhoto { get; set; }

    }

}
