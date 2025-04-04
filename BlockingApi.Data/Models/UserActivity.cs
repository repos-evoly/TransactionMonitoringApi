using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlockingApi.Data.Models
{
    [Table("UserActivities")]
    public class UserActivity : Auditable
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; } = null!;

        [Required]
        public string Status { get; set; } = "Offline";

        public DateTimeOffset LastActivityTime { get; set; } = DateTimeOffset.Now;
    }
}
