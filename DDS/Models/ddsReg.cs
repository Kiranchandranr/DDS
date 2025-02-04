using System.ComponentModel.DataAnnotations;

namespace DDS.Models
{
    public class ddsReg
    {
        public int RegId { get; set; }

        [Required(ErrorMessage = "Enter the name")]
        [DataType(DataType.Text)]
        public string RegName { get; set; }

        [Required(ErrorMessage = "Enter the mobile number")]
        [DataType(DataType.PhoneNumber)]
        public string RegMobile { get; set; }


        [Required(ErrorMessage = "Enter the email")]
        [DataType(DataType.EmailAddress)]
        public string RegEmail { get; set; }

    }
}
