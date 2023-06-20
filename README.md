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
Projeyi çalıştırdığınızda login sayfası açılmaktadır. Kullanıcı bilgileri local SQL'de tutulmaktadır. Kullanıcı kayıt etmek ve kullanıcı girişi için projenin appsettings.json dosyasından kendi SQL bilgilerinizi ekleyip veritabanı oluşturunuz.
SQL bağlantısı olmadan filmlere erişmek için projeyiğ çalıştırdıktan sonra https://localhost:7163/home/homeuser bağlantısını kullanabilirsiniz.

## Proje Frontend Çıktıları

![Anasayfa](https://github.com/EdanurKlnc/MovieWorldWeb/assets/77683001/590c3380-9b8c-42fb-83c4-602ce6ff0aa8)

![Ödüller](https://github.com/EdanurKlnc/MovieWorldWeb/assets/77683001/3d576e6b-588c-4642-9637-691682d84421)

![iletisim](https://github.com/EdanurKlnc/MovieWorldWeb/assets/77683001/b81b1715-e265-4043-bedf-1e1894ac4a5f)

![Giriş](https://github.com/EdanurKlnc/MovieWorldWeb/assets/77683001/cb3f6798-cdbc-48fe-b95f-16cbe8b994a5)

![Kayıt](https://github.com/EdanurKlnc/MovieWorldWeb/assets/77683001/61ee763a-d44e-4bc5-971c-5d2101d64c95)

![liste](https://github.com/EdanurKlnc/MovieWorldWeb/assets/77683001/8470a49a-e8f4-4792-8c35-a3c411051a85)

![filmler](https://github.com/EdanurKlnc/MovieWorldWeb/assets/77683001/1363f976-a0b4-4c6a-a092-5348a5412a4f)

## Proje Backend
![Solution](https://github.com/EdanurKlnc/MovieWorldWeb/assets/77683001/490235f0-c852-4016-a81b-3eb06ec2df28)

![solution2](https://github.com/EdanurKlnc/MovieWorldWeb/assets/77683001/bfacbc55-f5a2-48bb-85c6-e72c1bbdd32a)

![model](https://github.com/EdanurKlnc/MovieWorldWeb/assets/77683001/14ab32e4-255c-451a-920d-ba6f68558fe6)

![registerkod](https://github.com/EdanurKlnc/MovieWorldWeb/assets/77683001/7f9a98ba-94ab-4d61-84f5-55bc93e874b7)

![loginkod](https://github.com/EdanurKlnc/MovieWorldWeb/assets/77683001/2e9c2a8f-4c49-45ce-9622-cf92d97cd078)

![html](https://github.com/EdanurKlnc/MovieWorldWeb/assets/77683001/5678d65f-70b6-4d97-bbef-2c9c44dbb9e6)







