using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsAndModelBinding.Models
{
    /// <summary>
    /// Represents an individual clover park student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// The unique identifier for the student
        /// </summary>
        public int StudentID { get; set; }
        
        [Display(Name = "Full Name")]
        /// <summary>
        /// Uses the students legal first and last name.
        /// </summary>
        public string FullName { get; set; }

        [Display(Name = "DOB")]
        [DataType(DataType.Date)]
        /// <summary>
        /// Only stores day and year not the time.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        /// <summary>
        /// The students email (ends with @student.cptc.edu)
        /// </summary>
        public string EmailAddress { get; set; }

        [Display(Name = "Home Phone")]
        /// <summary>
        /// The home phone number of the students
        /// </summary>
        public string PhoneNumber { get; set; }

    }
}
