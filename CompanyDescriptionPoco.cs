using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Descriptions")]
    public class CompanyDescriptionPoco : IPoco
    {
        [Key]
        [Column("Id")]
        public Guid Id { get ; set ; }
        

        [Column("Company")]
        public Guid Company { get; set; }

        // [Column("LanguageID")]
        [ForeignKey("LanguageID")]
        [MaxLength(10)]
        public string LanguageId { get; set; }  


        [Column("Company_Name")]
        [MaxLength(50)]
        public string CompanyName { get; set; }

        [Column("Company_Description")]
        [MaxLength(1000)]
        public string CompanyDescription { get; set; }

        [Column("Time_Stamp")]
        [Timestamp]

        public byte[] TimeStamp { get; set; }
     
      
        [ForeignKey("Company")]
        public virtual CompanyProfilePoco CompanyProfile { get; set; }

      //  [ForeignKey("LanguageID")]
        public virtual SystemLanguageCodePoco SystemLanguageCode { get; set; }




    }
}
