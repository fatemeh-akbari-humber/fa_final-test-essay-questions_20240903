
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace CareerCloud.Pocos
{
    [Table("Applicant_Resumes")]
    public class ApplicantResumePoco : IPoco
    {
        [Key]
        [Column("Id")]
        public Guid Id { get ; set ; }
             

        [Column("Applicant")]
        //[ForeignKey("Applicant")]
        public Guid Applicant { get; set; }

        [Column("Resume")]
        public string Resume { get; set; }

        [Column("Last_Updated")]
        public DateTime? LastUpdated { get; set; }

        //  [ForeignKey("Applicant")]
        //  public virtual ApplicantProfilePoco ApplicantProfilePoco { get; set; }
        // public virtual ApplicantProfilePoco ApplicantProfile { get; set; }
        //[ForeignKey("Applicant")]
        public virtual ApplicantProfilePoco ApplicantProfile { get; set; }
    }
}
