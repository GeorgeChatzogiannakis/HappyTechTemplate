using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTechTemplate
{
    class Feedback
    {
        public int Id { get; set; }

        public User User { get; set; }

        public Applicant Applicant { get; set; }
        
        public Template Template { get; set; }
    }
}
