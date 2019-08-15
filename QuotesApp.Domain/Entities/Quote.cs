using System;
namespace QuotesApp.Domain.Entities
{
    public class Quote : BaseEntity
    {

        public string Text { get; set; }
        public string Author { get; set; }

        public int ReferenceNumber { get; set; }
        public string Source { get; set; }
        public DateTime? Date { get; set; }
    }
}
