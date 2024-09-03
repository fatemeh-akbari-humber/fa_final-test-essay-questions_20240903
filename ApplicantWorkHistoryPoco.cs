using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Work_History")]
    public class ApplicantWorkHistoryPoco : IPoco
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }
    
        [Column("Applicant")]
        public Guid Applicant { get; set; }

        [Column("Company_Name")]
        [MaxLength(150)]
        public string CompanyName { get; set; }

        [Column("Country_Code")]
        [MaxLength(10)]
        public string CountryCode { get; set; }

        [Column("Location")]
        [MaxLength(50)]
        public string Location { get; set; }

        [Column("Job_Title")]
        [MaxLength(50)]
        public string JobTitle { get; set; }

        [Column("Job_Description")]
        [MaxLength(500)]
        public string JobDescription { get; set; }

        [Column("Start_Month")]
        public short StartMonth { get; set; }

        [Column("Start_Year")]
        public int StartYear { get; set; }

        [Column("End_Month")]
        public short EndMonth { get; set; }

        [Column("End_Year")]
        public int EndYear { get; set; }

        [Column("Time_Stamp")]
        public byte[] TimeStamp { get; set; }

        [ForeignKey("Applicant")]
        public virtual ApplicantProfilePoco ApplicantProfile { get; set; }

        [ForeignKey("CountryCode")]
        public virtual SystemCountryCodePoco SystemCountryCode { get; set; }

       public virtual CompanyLocationPoco CompanyLocation { get; set; }

    }
}
