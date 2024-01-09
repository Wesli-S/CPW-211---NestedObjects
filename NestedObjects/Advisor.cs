using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents a college advisor
    /// </summary>
    public class Advisor
    {
        /// <summary>
        /// First and Last legal name
        /// </summary>
        public string? FullName { get; set; }

        /// <summary>
        /// Advisor's contact email
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// The building/room number where the advisor works on the college campus
        /// </summary>
        public string? OfficeLocation { get; set; }
        
        public Advisor? AssignedAdvisor { get; set; }

    }
}
