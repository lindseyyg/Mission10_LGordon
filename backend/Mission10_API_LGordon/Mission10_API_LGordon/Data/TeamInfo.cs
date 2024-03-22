using System.ComponentModel.DataAnnotations;

namespace Mission10_API_LGordon.Data
{
    public class TeamInfo
    {
        [Key]
        [Required]
        public int TeamID { get; set; }
        [Required]
        public string TeamName { get; set; }
        public int CaptainID { get; set; }
    }
}
