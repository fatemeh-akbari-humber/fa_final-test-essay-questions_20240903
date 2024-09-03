﻿
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace CareerCloud.Pocos
{
    [Table("Applicant_Educations")]
    public class ApplicantEducationPoco : IPoco
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("Applicant")]
        [ForeignKey("Applicant")]
        public Guid Applicant { get; set; }

        [Column("Major")]
        public string Major { get; set; }

        [Column("Certificate_Diploma")]
        public string CertificateDiploma { get; set; }

        [Column("Start_Date")]
        public DateTime? StartDate { get; set; }

        [Column("Completion_Date")]
        [Timestamp]
        public DateTime? CompletionDate { get; set; }

        [Column("Completion_Percent")]
        public byte? CompletionPercent { get; set; }

        [Column("Time_Stamp")]
        [Timestamp]
        public byte[] TimeStamp { get; set; }

       
        public virtual ApplicantProfilePoco ApplicantProfile { get; set; }


    }
}

