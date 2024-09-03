using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Jobs_Descriptions")]
    public class CompanyJobDescriptionPoco : IPoco
    {
        [Key]
        [Column("Id")]
        public Guid Id { get ; set; }
        
            [Column("Job")]
            public Guid Job { get; set; }

            [Column("Job_Name")]
            [MaxLength(100)]
            public string JobName { get; set; }

            [Column("Job_Descriptions")]
            [MaxLength(1000)]
            public string JobDescriptions { get; set; }

            [Column("Time_Stamp")]
             [Timestamp]
        public byte[] TimeStamp { get; set; }
            public virtual CompanyJobPoco CompanyJob { get; set; }

        // [ForeignKey("Job")]
        //  public virtual CompanyJobsPoco CompanyJobsPoco { get; set; }
    }
}
