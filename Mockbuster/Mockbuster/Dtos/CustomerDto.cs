using Mockbuster.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace Mockbuster.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        [Required(ErrorMessage = "Please select membership type")]

        public byte MembershipTypeId { get; set; }

        //[Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }
    }
}