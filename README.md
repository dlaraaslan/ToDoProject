# TODO Project

## Hakkında
Kullanıcıların yapacağı işleri planladığı küçük bir web uygulamasının backend kısmıdır. 
ASP.Net Core 5.0 kullanılarak yazılmıştır. Bu projede nesneye dayalı tasarım kullanılmış ve SOLID prensiplerine bağlı clean code bir proje olması amaçlanmıştır. N-Tier Architecture kullanılarak Core, DataAccess, Entities, Business ve Api katmanlarına ayrılmıştır. Çok katmanlı mimari yapısıyla proje yönetimin kolaylaştırılması, ölçeklenebilirlik, esneklik, yeniden kullanılabilirlik ve güvenlik gibi problemlerin çözümlerinde basit ve yalın bir yol izlenmeye çalışılmıştır.

#### Business Layer
Sunum katmanından (Api katmanı) gelen isteklerin ve verilerin işlendiği veya kontrol edildiği, uygulamada mantık işlemlerinin ve veri manipülasyonlarının işlendiği katmandır.

#### Core Layer
Proje mimarisinin temel yapısını oluşturan kısımlarının yer aldığı, proje bağımlı olmayan bir katmandır. Uygulama genelinde kullanılacak yapıların(IoC gibi) sistemden soyutlanıp enkapsüle edilerek istenen katmanda kullanılabilmesini sağlamaktadır. Veri erişimi için Entity framework repository soyutlamaları ve generic yapıda bu katmanda yer almaktadır. Ayrıca katman içindeki utilities (araçlar) içinde bulunan Results klasörü API kullanılırken doğru yönlenmek için kullanılır.

#### Data Access Layer
Veri tabanı işlemlerinin yapıldığı katmandır, bu katmanda temel görevi veriye erişmek ve ekleme, silme, güncelleme gibi temel işlemler yerine getirilir. Ayrıca projede Entity Framework kullanıldığı için data context, migrations ve entityler arasındaki mapping (db üzerindeki mappingler), annotations ve relations gibi operasyonlar yer almaktadır.

#### Entity Layer
Veri tabanı tabloları için oluşturulmuş nesnelerin bulunduğu katmandır. Bu katmanda yer alan DTOs klasöründe farklı nesneleri bir arada kullanılması gerektiği ve veri tabanı tablolarındaki belli sütunların kullanılacağı durumlarda yarar sağlamaktadır. 

#### API(Presentation) Layer
Projede kullanıcı veya arayüzle iletişimde olan kısımların tümünü içeren katmandır. TODO projesinin backend tarafı web api olup çeşitli platformlarda arayüz geliştirilebilmesine olanak sağlamaktadır, api katmanı temel olarak gelen ve giden verilerin mantıklarının sağlandığı ve controllers üzerinden belli ihtiyaçlar ve işlevler için oluşturulmuş metodlardan oluşmaktadır. 

## Tech Stack (Kullanılan Teknolojiler)
- Asp.Net Core 5.0
- Microsoft.EntityFrameworkCore 5.0.10
- Microsoft.EntityFrameworkCore.SqlServer 5.0.10
- Swashbuckle (Swagger)	
