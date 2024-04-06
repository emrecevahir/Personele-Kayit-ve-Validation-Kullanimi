using System.ComponentModel.DataAnnotations;


namespace Validation.Models
{
    public class AddUser
    {

        //girilecek bilgiler ve validation kısıtlarını belirledik

        [Required(ErrorMessage ="Tc Kimlik numarası boş bırakılamaz.")]
        [Display(Name = "T.C. Kimlik No")]
        [StringLength(11, ErrorMessage = "T.C. Kimlik No 11 haneli olmalıdır.")]
        [RegularExpression("^[1-9]{1}[0-9]{9}[02468]{1}$", ErrorMessage = "Geçerli bir T.C. Kimlik No giriniz.")]
        public string IdentityNo { get; set; }

        [Display(Name = "İsim")]
        [StringLength(20,MinimumLength = 3, ErrorMessage ="Ad alanı belirlenen kurallar dahilinde değil.")]
        [Required(ErrorMessage = "Ad alanı boş bırakılamaz.")]
        public string Name { get; set; }

        [Display(Name = "Soyisim")]
        [StringLength(60,MinimumLength = 2, ErrorMessage ="Soy ad alanı belirlenen kurallar dahilinde değil.")]
        [Required(ErrorMessage = "Soy ad alanı boş bırakılamaz.")]
        public string LastName { get; set; }

        [Display(Name = "E-posta")]
        [Required(ErrorMessage = "E-posta alanı boş bırakılamaz.")]
        [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$", ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string Email { get; set; }

        [Display(Name = "Yaş")]
        [Required(ErrorMessage = "Yaş alanı boş bırakılamaz.")]
        [Range(18, 65, ErrorMessage = "Yaş aralığı 18-65 olmalıdır.")]
        public int Age { get; set; }

    }
}
