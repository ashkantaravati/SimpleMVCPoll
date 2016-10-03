using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleMVCPoll.Models
{
    public class Poll
    {
        public Guid PollID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Question { get; set; }
        public DateTime CreationTime { get; set; }
        public Guid SubmissionID { get; set; }
        public virtual ICollection<Submission> Submissions { get; set; }
        public Poll()
        {
            Submissions = new List<Submission>();
        }
    }
}