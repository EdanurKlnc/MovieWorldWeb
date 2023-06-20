# MovieWorldWeb
Proje Bahçeşehir Üniversitesi Wissen Akademie bünyesinde öğrendiklerimle geliştirmiş olduğum bir projedir. Projenin genel amacı TMBD sayfasında bulunan filmlerin API ile listelemektir.
Projenin tüm hakları şahsıma aittir. Kodlarını inceleyebilir ve geliştirebilirsiniz.
## Proje İçeriği
- Kullanıcı uygulamaya üye olup giriş sağlayabilir.
- Kayıt olmayan veya giriş sağlamayan kullanıcı projenin anasayfasını görüp filmlere erişim sağlayamamaktadır.
- Giriş yapıldıktan sonra API'den gelen filmler listelenir.
- Film kartı bulunmaktadır. Kartın içeriğinde filmin adı, afişi,puanı,yayın tarihi ve dil bilgisi bulunmaktadır.

## Projenin Teknik Bilgisi
* Proje .NET C# Aspnet MVC CORE alt yapısıyla yazılmıştır.
* Proje Entity Framework CORE - Code-First yaklaşımıyla yazılmıştır.
* Projenin kullanıcı yönetimi Aspnet.Identity CORE ile yazılmıştır.
* Projenin FrontEnd kısmı hazır tema giydirmesi ve yeniden oluşturma olarak 2 şekilde hazırlanmış, HTML, CSS ,JavaScript kullanılmıştır.
* Proje 2 katman (UI,EL) olarak yazıldı.


### SQL Bağlantısı
Projeyi çalıştırdığınızda login sayfası açılmaktadır. Kullanıcı bilgileri local SQL'de tutulmaktadır. Kullanıcı kayıt etmek ve kullanıcı girişi için projenin appsettings.json dosyasından kendi SQL bilgilerinizi ekleyip veritabanı oluşturunuz..

