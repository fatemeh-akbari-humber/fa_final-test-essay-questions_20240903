
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace CareerCloud.Pocos
{
    [Table("Applicant_Profiles")]
    public class ApplicantProfilePoco : IPoco
    {

        [Key]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("Login")]
       // [ForeignKey("Login")]
        public Guid Login { get; set; }

        [Column("Current_Salary")]
        public decimal? CurrentSalary { get; set; }

        [Column("Current_Rate")]
        public decimal? CurrentRate { get; set; }

        [Column("Currency")]
        [MaxLength(10)]
        public string Currency { get; set; }

        [Column("Country_Code")]
        [MaxLength(10)]
      //  [ForeignKey("CountryCode")]
        public string Country { get; set; }

        [Column("State_Province_Code")]
        [MaxLength(10)]
        public string Province { get; set; }

        [Column("Street_Address")]
        [MaxLength(100)]
        public string Street { get; set; }

        [Column("City_Town")]
        [MaxLength(100)]
        public string City { get; set; }

        [Column("Zip_Postal_Code")]
        [MaxLength(20)]
        public string PostalCode { get; set; }

        [Column("Time_Stamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public byte[] TimeStamp { get; set; }

         public virtual SecurityLoginPoco SecurityLogin { get; set; }
        public virtual SystemCountryCodePoco SystemCountryCode { get; set; }
        public virtual ICollection<ApplicantEducationPoco> ApplicantEducations { get; set; }
        public virtual ICollection<ApplicantJobApplicationPoco> ApplicantJobApplications { get; set; }
        public virtual ICollection<ApplicantResumePoco> ApplicantResumes { get; set; }
        public virtual ICollection<ApplicantSkillPoco> ApplicantSkills { get; set; }
        public virtual ICollection<ApplicantWorkHistoryPoco> ApplicantWorkHistorys { get; set; }

    }
}
