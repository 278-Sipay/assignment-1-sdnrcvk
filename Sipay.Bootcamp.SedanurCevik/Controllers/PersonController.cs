using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Sipay.Bootcamp.SedanurCevik.Models;
using Sipay.Bootcamp.SedanurCevik.Validators;

namespace Sipay.Bootcamp.SedanurCevik.Controllers
{
    [Route("sipy/api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        //parametresiz bir yapıcı metod tanımlandı, şu anda herhangi bir işlem yapılmıyor
        public PersonController()
        {
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            //Person modelinin doğrulamasını gerçekleştirmek için oluşturulan PersonValidator sınıfından bir nesne oluşturulur
            var personValidator =new PersonValidator();
            //Person nesnesi PersonValidator kullanılarak doğrulanır, doğrulama sonucu validationResult değişkenine atanır
            var validationResult =personValidator.Validate(person);
            //doğrulamanın başarılı olup olmadığı kontrol edilir, buna göre yanıt döndürülür
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            return Ok(person);
        }
    }
}
