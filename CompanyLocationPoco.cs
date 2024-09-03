
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CareerCloud.Pocos
{
    [Table("Company_Locations")]
    public class CompanyLocationPoco : IPoco
    {

        [Key]
        [Column("Id")]
        public Guid Id { get; set ; }
      
        [Column("Company")]
      //  [ForeignKey("Company")]
        public Guid Company { get; set; }

        [Column("Country_Code")]
        [MaxLength(10)]
        public string CountryCode { get; set; }

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
        [Timestamp]
        public byte[] TimeStamp { get; set; }
        //[ForeignKey(nameof(Company))]
        //[InverseProperty("CompanyProfile")]
        //[InverseProperty(nameof(CompanyProfilePoco.Id))]
        public virtual CompanyProfilePoco CompanyProfile { get; set; }
        public virtual SystemCountryCodePoco SystemCountryCode { get; set; }


    }
}
