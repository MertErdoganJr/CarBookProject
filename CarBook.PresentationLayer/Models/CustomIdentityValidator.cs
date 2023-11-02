using Microsoft.AspNetCore.Identity;

namespace CarBook.PresentationLayer.Models
{
    public class CustomIdentityValidator : IdentityErrorDescriber
    {
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Code = "PasswordRequiredLower",
                Description = "Lütfen en az bir tane küçük harf girişi yapınız"
            };
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresUpper",
                Description = "Lütfen en az bir tane büyük harf girişi yapınız"
            };
        }

        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresDigit",
                Description = "Lütfen en az bir tane rakam girişi yapınız"
            };
        }

        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Code = "PasswordTooShort",
                Description = $"Lütfen en az {length} karakter girişi yapınız"
            };
        }

        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Lütfen en az 1 tane sembol girişi yapınız"
            };
        }
    }
}
