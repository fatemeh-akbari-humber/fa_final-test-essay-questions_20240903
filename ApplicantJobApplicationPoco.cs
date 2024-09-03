using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Job_Applications")]
    public class ApplicantJobApplicationPoco : IPoco
    {
        [Key]
        [Column("Id")]
        public Guid Id { get ; set; }

        [Column("Applicant")]
       // [ForeignKey("Applicant")]
        public Guid Applicant { get; set; }

        [Column("Job")]
        public Guid Job { get; set; }

        [Column("Application_Date")]
        public DateTime ApplicationDate { get; set; }

        [Column("Time_Stamp")]
        [Timestamp]
        public byte[] TimeStamp { get; set; }

         //[ForeignKey("Applicant")]
         //public virtual ApplicantProfilePoco ApplicantProfilePoco { get; set; }
      //  public virtual ICollection<ApplicantProfilePoco> ApplicantProfiles { get; set; }

      /// <summary>
       public virtual ApplicantProfilePoco ApplicantProfile { get; set; }
      /// </summary>
        public virtual CompanyJobPoco CompanyJob { get; set; }

    }
}
