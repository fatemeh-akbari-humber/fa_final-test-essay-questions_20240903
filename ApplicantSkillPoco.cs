using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Skills")]
    public class ApplicantSkillPoco : IPoco
    {
        [Key]
        [Column("Id")]

        public Guid Id { get ; set; }
        

        [Column("Applicant")]
        public Guid Applicant { get; set; }

        [Column("Skill")]
        [MaxLength(100)]
        public string Skill { get; set; }

        [Column("Skill_Level")]
        [MaxLength(10)]
        public string SkillLevel { get; set; }

        [Column("Start_Month")]
        public byte StartMonth { get; set; }

        [Column("Start_Year")]
        public int StartYear { get; set; }

        [Column("End_Month")]
        public byte EndMonth { get; set; }

        [Column("End_Year")]
        public int EndYear { get; set; }

        [Column("Time_Stamp")]
        public byte[] TimeStamp { get; set; }

      //  [ForeignKey("Applicant")]
     //   public virtual ApplicantProfilePoco ApplicantProfilePoco { get; set; }

  
        public virtual ApplicantProfilePoco ApplicantProfile { get; set; }

    }
}
