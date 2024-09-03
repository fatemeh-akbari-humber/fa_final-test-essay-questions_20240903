﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Profiles")]
    public class CompanyProfilePoco : IPoco
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }
    
        [Column("Registration_Date")]
        public DateTime RegistrationDate { get; set; }

        [Column("Company_Website")]
        [MaxLength(100)]
        public string CompanyWebsite { get; set; }

        [Column("Contact_Phone")]
        [MaxLength(20)]
        public string ContactPhone { get; set; }

        [Column("Contact_Name")]
        [MaxLength(50)]
        public string ContactName { get; set; }

        [Column("Company_Logo")]
        public byte[] CompanyLogo { get; set; }

        [Column("Time_Stamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]

        public byte[] TimeStamp { get; set; }

        public virtual ICollection<CompanyDescriptionPoco> CompanyDescriptions { get; set; }
       
        public virtual ICollection<CompanyJobPoco> CompanyJobs { get; set; }

        public virtual ICollection<CompanyLocationPoco> CompanyLocations { get; set; }
     

    }
}