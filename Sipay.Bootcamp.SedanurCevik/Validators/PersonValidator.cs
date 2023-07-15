using FluentValidation;
using Sipay.Bootcamp.SedanurCevik.Models;

namespace Sipay.Bootcamp.SedanurCevik.Validators
{
    public class PersonValidator : AbstractValidator<Person>
        {

            //Person sınıfının doğrulama kurallarını tanımlar
            public PersonValidator()
            {
                RuleFor(p => p.Name).NotEmpty().Length(5, 100).WithName("Staff person name");

                RuleFor(p => p.Lastname).NotEmpty().Length(5, 100).WithName("Staff person lastname");

                //Phone özelliğinin "05XX XXX XX XX" formatına uygun olması sağlanır
                RuleFor(p => p.Phone).NotEmpty().Matches(@"^(05\d{2})\s(\d{3})\s(\d{2})\s(\d{2})$").WithMessage("Please enter a valid phone number").WithName("Staff person phone number");

                RuleFor(p => p.AccessLevel).NotEmpty().InclusiveBetween(1, 5).WithName("Staff person access level to system");

                // IsValidSalary adlı özel bir doğrulama metodu çağrılır
                RuleFor(p => p.Salary)
                    .NotEmpty()
                    .InclusiveBetween(5000, 50000)
                    .WithMessage("Salary must be between 5000 and 50000")
                    .Must((person, salary) => IsValidSalary(person.AccessLevel, salary))
                    .WithMessage("Invalid salary for the given access level");
            }

            //her bir seviye için farklı bir maaş sınırlaması verilmiştir, seviyeye göre maaşın geçerli olup olmadığı kontrol edilir
            private bool IsValidSalary(int accessLevel, decimal salary)
            {
                switch (accessLevel)
                {
                    case 1:
                        return salary <= 10000;
                    case 2:
                        return salary <= 20000;
                    case 3:
                        return salary <= 30000;
                    case 4:
                        return salary <= 40000;
                    default:
                        return false;
                }
            }
        }
}
