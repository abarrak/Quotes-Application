using System;

namespace QuotesApp.Application.DTOs
{
    public class QuoteOutputDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public string Source { get; set; }
        public DateTime? Date { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
