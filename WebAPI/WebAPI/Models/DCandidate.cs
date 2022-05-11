using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebAPI.Models
{
    [Table("DCandidate")]
    public class DCandidate
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        [StringLength(10)]
        public string Mobile { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public int Age { get; set; }

       [StringLength(3)]
        public string BloodGroup { get; set; }

        [StringLength(100)]
        public string Address { get; set; }
    }}
