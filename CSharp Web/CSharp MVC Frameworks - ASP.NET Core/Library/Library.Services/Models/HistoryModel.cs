namespace Library.Services.Models
{
    using System;

    public class HistoryModel
    {
        public string Title { get; set; }

        public string Borrower { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
