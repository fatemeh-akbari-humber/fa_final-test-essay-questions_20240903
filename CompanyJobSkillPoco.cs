using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Job_Skills")]
    public class CompanyJobSkillPoco : IPoco
    {
        [Key]
        [Column("Id")]
        public Guid Id { get ; set; }
    
        
        [Column("Job")]
        public Guid Job { get; set; }

        [Column("Skill")]
        [MaxLength(100)]
        public string Skill { get; set; }

        [Column("Skill_Level")]
        [MaxLength(10)]
        public string SkillLevel { get; set; }

        [Column("Importance")]
        public int Importance { get; set; }

        [Column("Time_Stamp")]
        [Timestamp]
        public byte[] TimeStamp { get; set; }
        public virtual CompanyJobPoco CompanyJob { get; set; }
    }
}
