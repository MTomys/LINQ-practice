using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice.Models
{
    public class Visit
    {
        public int VisitId { get; set; }
        public string VisitDescription { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
