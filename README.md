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
![Anasayfa](https://github.com/EdanurKlnc/MovieWorldWeb/assets/77683001/c87d4bdc-9278-4f57-82d8-c64d5d6bd5e9)

![Ödüller](https://github.com/EdanurKlnc/MovieWorldWeb/assets/77683001/ffa0a35b-8ad1-4d4b-9aae-ecaf9d45e0b5)

![iletisim](https://github.com/EdanurKlnc/MovieWorldWeb/assets/77683001/d1e071c9-eb6f-4372-a9b7-e7c5356b170a)

![Giriş](https://github.com/EdanurKlnc/MovieWorldWeb/assets/77683001/89177684-ab2a-46ee-88f5-69b412de5a8f)

![Kayıt](https://github.com/EdanurKlnc/MovieWorldWeb/assets/77683001/7726a135-d85f-4d6a-a0b2-d9c55677df79)

![liste](https://github.com/EdanurKlnc/MovieWorldWeb/assets/77683001/6fbceed9-1b9c-4c81-9db4-22ca69430e26)

![filmler](https://github.com/EdanurKlnc/MovieWorldWeb/assets/77683001/c9486918-6ca5-412a-b023-deb6a3f8b924)

## Proje Backend
![Solution](https://github.com/EdanurKlnc/MovieWorldWeb/assets/77683001/69315882-0c0e-407e-9339-51a69a9f617c)

![solution2](https://github.com/EdanurKlnc/MovieWorldWeb/assets/77683001/e978cfaa-34d8-4fc2-85ae-ce6b4f6a9563)

![model](https://github.com/EdanurKlnc/MovieWorldWeb/assets/77683001/55cd2a95-0a54-4db4-b3e7-3e37190c4ff2)

![registerkod](https://github.com/EdanurKlnc/MovieWorldWeb/assets/77683001/754da011-516c-4894-80fd-682c073a58c9)

![loginkod](https://github.com/EdanurKlnc/MovieWorldWeb/assets/77683001/4eaf4798-7508-4586-9e22-edc12b95e778)

![html](https://github.com/EdanurKlnc/MovieWorldWeb/assets/77683001/cbd0aea2-70e3-4145-ad1c-48cff95eb919)

