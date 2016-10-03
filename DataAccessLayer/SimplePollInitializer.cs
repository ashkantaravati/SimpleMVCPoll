using System;
using System.Collections.Generic;
using SimpleMVCPoll.Models;
using System.Linq;
using System.Web;

namespace SimpleMVCPoll.DataAccessLayer
{
    public class SimplePollInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<SimplePollContext>
    {
        protected override void Seed(SimplePollContext context)
        {
            var polls = new List<Poll>
            {
            new Poll{PollID=Guid.Parse("38D2B9BF-5788-4442-9065-C03A6B3AA036"),UserName="Meredith",Question="Who was Alonso?",Email="xyz@abc.info",CreationTime=DateTime.Now},
            new Poll{PollID=Guid.Parse("BDB1A279-6116-494E-B62F-126FEA79FA35"),UserName="Arturo",Question="Who was Anand?",Email="xyz@abc.info",CreationTime=DateTime.Now},
            new Poll{PollID=Guid.Parse("65AF3D3C-8876-430D-9E0C-95E58CCB424D"),UserName="Carson",Question="Who was Alexander?",Email="xyz@abc.info",CreationTime=DateTime.Now},
            
            };

            polls.ForEach(s => context.Polls.Add(s));
            context.SaveChanges();
            var submissions = new List<Submission>
            {
            new Submission {SubmissionID=1050,Answer="Chemistry",Name="asqar",PollID=Guid.Parse("65AF3D3C-8876-430D-9E0C-95E58CCB424D")},
            new Submission {SubmissionID=4022,Answer="Microeconomics",Name="asqar",PollID=Guid.Parse("BDB1A279-6116-494E-B62F-126FEA79FA35")},
            new Submission {SubmissionID=4041,Answer="Macroeconomics",Name="asqar",PollID=Guid.Parse("BDB1A279-6116-494E-B62F-126FEA79FA35")},
            new Submission {SubmissionID=1045,Answer="Calculus",Name="asqar",PollID=Guid.Parse("65AF3D3C-8876-430D-9E0C-95E58CCB424D")},
            new Submission {SubmissionID=3141,Answer="Trigonometry",Name="asqar",PollID=Guid.Parse("BDB1A279-6116-494E-B62F-126FEA79FA35")},
            new Submission {SubmissionID=2021,Answer="Composition",Name="asqar",PollID=Guid.Parse("38D2B9BF-5788-4442-9065-C03A6B3AA036")},
            new Submission {SubmissionID=2042,Answer="Literature",Name="asqar",PollID=Guid.Parse("65AF3D3C-8876-430D-9E0C-95E58CCB424D")}
            };
            submissions.ForEach(s => context.Submissions.Add(s));
            context.SaveChanges();
            
            
        }
    }
}