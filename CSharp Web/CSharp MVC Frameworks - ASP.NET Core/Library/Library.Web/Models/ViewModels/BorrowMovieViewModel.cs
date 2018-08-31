namespace Library.Web.Models.ViewModels
{
    using Attributes;
    using System;
    using System.ComponentModel.DataAnnotations;
    using Services.Models.Borrowers;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc.ModelBinding;

    public class BorrowMovieViewModel
    {
        [BindNever]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [DateIsIn21Century]
        public DateTime StartDate { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        [AfterDate(nameof(StartDate))]
        public DateTime? EndDate { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        [Display(Name = "Borrower")]
        public string Borrower { get; set; }

        [BindNever]
        public IEnumerable<AllBorrowersModel> Borrowers { get; set; }

    }
}
