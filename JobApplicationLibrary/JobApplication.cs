using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplicationLibrary
{
    public class JobApplication
    {
        public Applicant Applicant { get; set; }
        public int YearsOfExperince { get; set; }
        public List<string> TechStackList { get; set; }
    }
}
