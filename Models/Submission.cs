using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleMVCPoll.Models
{
    public class Submission
    {
        public int SubmissionID { get; set; }
        public string Name { get;  set;}
        public string Answer { get; set; }
        public DateTime SubmitTime { get; set; }
        public virtual Poll Poll { get;  set; }
        public Guid PollID { get; set; }


    }
}