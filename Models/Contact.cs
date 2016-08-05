using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InvontoDevTest.Models
{
    public class Contact
    {
        //General Information
        //Make first three non id feilds non-nullable
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Profile { get; set; }

        //List of Groups
        //Which group(s) does contact belong to
        public bool? Family { get; set; }
        public bool? Friend { get; set; }
        public bool? Colleague { get; set; }
        public bool? Associate { get; set; }

        //Additional Comments 2000 character max
        [StringLength(2000)]
        public string Comments { get; set; }
    }
}