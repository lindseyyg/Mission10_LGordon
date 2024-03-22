using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission10_API_LGordon.Data
{
    public class BowlerInfo
    {
        [Key]
        [Required]
        public int BowlerID { get; set; }
        public string? BowlerLastName { get; set; }
        public string? BowlerFirstName { get; set; }
        public string? BowlerMiddleInit { get; set; }
        public string? BowlerAddress { get; set; }
        public string? BowlerCity { get; set; }
        public string? BowlerState { get; set; }
        public string? BowlerZip { get; set; }
        public string? BowlerPhoneNumber { get; set; }
        [ForeignKey("TeamInfo")] // Setting up Foreign Key relationship
        public int TeamID { get; set; }
        public TeamInfo? TeamInfo { get; set; }
    }
}
