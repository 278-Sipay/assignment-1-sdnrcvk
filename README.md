# assignment-1

# 📋 Ders Ödevleri

Hafta 1 - Person class içerisindeki validation'lar (Şekil 1) FluentValidation kütüphanesi kullanılarak yeniden düzenlendi. Controller üzerindeki POST methodu attributelar yerinde FluentValidation ile çalışacak şekilde düzenlendi. 

Şekil 1 :
![image](https://github.com/sdnrcvk/sdnrcvk/assets/58807892/b1409059-e02a-4fc9-b03b-b6e2eb561cab) 
  
# 📋 Lesson Homeworks

Week 1 - The validations in the Person class have been rearranged using the FluentValidation library. The POST method on the controller has been adjusted to work with FluentValidation in place of the attributes.

# 🗂️ Klasör ve Dosya Yapısı

📂**`Models`**  
&nbsp;&nbsp;📃[Person.cs]()      
📂**`Controllers`**  
&nbsp;&nbsp;📃[PersonController.cs]()     
📂**`Validators`**  
&nbsp;&nbsp;📃[PersonValidator.cs]()   

# 📎 Ek Bilgiler

## 🔗 RESTful API Nedir?

RESTful API (Representational State Transfer), web servislerin veri iletişimi için kullanılan bir yazılım mimarisidir. RESTful API, bir istemci (client) ile bir sunucu (server) arasında veri alışverişini sağlayan bir yapıdır.

RESTful API'nin temel prensibi, kaynaklara (resources) dayalı bir yapıya sahip olmasıdır. Her bir kaynak, benzersiz bir tanımlayıcıya (URI - Uniform Resource Identifier) sahip olur ve bu tanımlayıcı üzerinden erişilebilir. Örneğin, bir blog yazısı kaynağına erişmek için /blog/yazilar/1 gibi bir URI kullanılabilir.

RESTful API, HTTP protokolü üzerinden çalışır ve genellikle HTTP metotlarını (GET, POST, PUT, DELETE vb.) kullanarak işlem yapar. Her bir metot, belirli bir eylemi gerçekleştirmek için kullanılır. Örneğin, GET metodu bir kaynağı okumak için kullanılırken, POST metodu yeni bir kaynak oluşturmak için kullanılabilir.

API'nin cevapları genellikle JSON (JavaScript Object Notation) veya XML (eXtensible Markup Language) formatında döndürülür. Bu sayede istemci, API ile iletişim kurarak veri alışverişi yapabilir ve bu verileri kullanabilir.

## ✔️ Fluent Validation Nedir?

Fluent Validation, .NET platformunda kullanılan bir doğrulama kütüphanesidir. Bu kütüphane, giriş değerlerini doğrulamak ve hataları işlemek için kullanılır.

Fluent Validation, kodunuzda doğrulama kurallarını açıkça tanımlamanızı sağlar ve bu kuralları nesneler üzerinde doğrudan uygulamanızı kolaylaştırır. Kütüphane, zincirleme yöntemler (fluent interface) kullanarak doğrulama kurallarını tanımlamanıza olanak sağlar.

Örneğin, bir kullanıcının kaydolma formunda gerekli alanları doldurması gerektiğini doğrulamak istediğinizi düşünelim.Kullanıcı adının boş olmaması, e-posta adresinin geçerli bir formatta olması ve parolanın belirli bir uzunlukta olması gibi kuralları tanımlayabilirsiniz. Ayrıca özelleştirilebilirlik özelliği sayesinde ihtiyaçlarınıza göre doğrulama kurallarınızı genişletebilirsiniz.

## Badges

Add badges from somewhere like: [shields.io](https://shields.io/)

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![GPLv3 License](https://img.shields.io/badge/License-GPL%20v3-yellow.svg)](https://opensource.org/licenses/)
[![AGPL License](https://img.shields.io/badge/license-AGPL-blue.svg)](http://www.gnu.org/licenses/agpl-3.0)

