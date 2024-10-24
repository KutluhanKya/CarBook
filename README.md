# CarBook

## Proje Hakkında

**CarBook**, bir araç kayıt ve yönetim sistemidir. Projede JWT tabanlı kimlik doğrulama, CQRS tasarım deseni ve MediatR kütüphanesi ile katmanlı mimari kullanılmıştır. Bu yapı sayesinde proje ölçeklenebilir ve sürdürülebilir bir hale getirilmiştir.

### Kullanılan Teknolojiler

- **ASP.NET Core Web API**
- **Entity Framework Core**: Veritabanı işlemleri için.
- **JWT (JSON Web Token)**: Kimlik doğrulama için.
- **MediatR**: Uygulama içi mesajlaşmayı yönetmek ve bağımlılıkları azaltmak için.
- **CQRS Pattern**: Sorgular (query) ve komutları (command) birbirinden ayırmak için.
- **Katmanlı Mimari**: Core, Infrastructure, ve Presentation katmanlarıyla yapılandırılmıştır.
  
## Katmanlar ve Yapı

### Core
- **CarBook.Application**: İş mantığını barındıran servisler ve işlevler burada bulunur. CQRS tasarım deseni kullanılarak komutlar ve sorgular ayrılmıştır. MediatR, komutların ve sorguların yönetiminde kullanılır.
- **CarBook.Domain**: Domain modelleri ve iş kuralları burada yer alır.

### Infrastructure
- **CarBook.Persistence**: Veritabanı işlemleri ve kalıcılık yönetimi burada yapılır. Entity Framework Core ile ilişkisel bir veritabanı yönetimi sağlanır.

### Presentation
- **CarBook.WebApi**: API son noktaları burada yer alır ve JWT ile kimlik doğrulama yapılır. Kullanıcılar, JWT token kullanarak API'ye istek yapabilir.

## JWT ile Kimlik Doğrulama

Proje, JWT kullanarak güvenli bir kimlik doğrulama sistemi sunar. Kullanıcı, başarılı bir giriş yapıldığında bir JWT token alır ve bu token ile API'ye yetkili isteklerde bulunabilir.


