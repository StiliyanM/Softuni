﻿namespace Library.Models
{
    using System;

    public class MoviesBorrower
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int BorrowerId { get; set; }
        public Borrower Borrower { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

    }
}
