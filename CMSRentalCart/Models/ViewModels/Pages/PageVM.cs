/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// These 3 added
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CMSRentalCart.Models.Data;

namespace CMSRentalCart.Models.ViewModels.Pages
{
    public class PageVM
    {
        
        public PageVM()
        {

        }
        public PageVM(PageDTO row)
        {
            Id = row.Id;
            Title = row.Title;
            Slug = row.Slug;
            Body = row.Body;
            Sorting = row.Sorting;
            HasSidebar = row.HasSidebar;
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength =3)]
        public string Title { get; set; }
        public string Slug { get; set; }
        [Required]
        [StringLength(int.MaxValue, MinimumLength = 3)]
        public string Body { get; set; }
        public int Sorting { get; set; }
        public bool HasSidebar { get; set; }
    }
}
*/