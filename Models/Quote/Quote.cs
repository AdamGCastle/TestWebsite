using System.ComponentModel.DataAnnotations;
using TestWebsite.Enums;

namespace TestWebsite.Models.Quote
{
    public class Quote
    {
        [Display(Name = "Title")]
        public Title Title { get; set; }

        [Display(Name = "Contact Name")]
        public string ContactName { get; set; }

        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Total Size (m2)")]
        public double TotalSize { get; set; }

        [Display(Name = "Total Rebuild Cost (£)")]
        public decimal TotalRebuildCost { get; set; }

        // Added as a Boolean
        [Display(Name = "Flat Roof Cover")]
        public bool FlatRoofCoverNeeded { get; set; }
        // Added as a nullable double, as some quotes don't need the roof size, in which case it's okay for it to be null.
        // If this app were deployed in the construction sector, I would have used a double for greater precision, but I thought for insurance purposes a full number would be accurate enough.
        [Display(Name = "Roof Size (m2)")]
        public int? RoofSize { get; set; }
    }
}
