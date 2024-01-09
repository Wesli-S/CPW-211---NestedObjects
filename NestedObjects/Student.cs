using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents an individual college student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// legal first name
        /// </summary>
        public string? FirstName { get; set; }

        /// <summary>
        /// legal last name
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// The assigned school email address
        /// </summary>
        public string? SchoolEmail { get; set; }

        /// <summary>
        /// Students official date of birth(month, day, year)
        /// </summary>
        public DateOnly DateOfBirth { get; set; }

        /// <summary>
        /// Students preferred phone contact number
        /// </summary>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// The advisor assigned to the current student
        /// </summary>
        public Advisor? StudentAdvisor { get; set; }
}
}
