# EnocaCaseStudy

Konu
Firma Sipariş Yönetim servisi oluşturun. 
Bu Servis, Firma, Firma Ürünleri ve Sipariş sistemlerini içermelidir.

Talimatlar

Proje tamamlandıktan sonra veritabanı script’i ile birlikte Github’a yükleyebilirsiniz. Zip olarak göndermeyiniz.

Tablo Açıklamaları
-Firma: Id, Firma Adı, Onay Durumu, Sipariş İzin başlangıç saati, Sipariş İzin bitiş saati
-Ürünler: Id, FirmaId, Ürün Adı, Stok, Fiyatı
-Sipariş: Id, FirmaId, UrunId, Siparişi veren kişinin adı, Sipariş Tarihi

Yapılması Beklenen Servisler

-Firma Ekleme
1. Tabloya tüm bilgiler eklenebilmelidir.

-Firma Güncelleme
1. Sipariş İzin Saati Güncelleme
2. Onay Durumu Güncelleme

-Firma Listeleme
1. Tüm firmalar ve sütunları getirilmelidir.

-Ürün Ekleme
1. Tabloya tüm bilgiler eklenebilmelidir.

-Sipariş Oluşturma
1. İlgili Firma onaylı ise sipariş oluşturulabilir

2. Sipariş oluştur dediğimizdeki saat, firma izin saatleri arasında ise sipariş oluşturulabilir
  a. Test edilebilmesi için Şuanki saati istek içerisinde gönderebilirsiniz.
  b. Örneğin Firma Sipariş İzin Saatleri: 08:30-11:00 olsun

            i. Saat 08:29’da sipariş alınamaz
            ii. Saat 08:30’da sipariş alınabilir
            iii. Saat 09:55’te sipariş alınabilir
            iv. Saat 11:00’da sipariş alınabilir
            v. Saat 16:47’de sipariş alınamaz

3. Sipariş Sonucuna göre bilgilendirici bir text dönüş yapılmalıdır
  a. Örneğin: Firma Onaylı Değil, Firma şuan sipariş almıyor


Teknolojiler

.NET Core 6 API*, MSSQL*, Swagger UI*, Entity Framework Code First*, Repository Design Pattern*, Tercihen CQRS
Design Pattern - Mediatr, Tercihen Onion Architecture

Önemli Not:

Projenizi geliştirirken SOLID prensiplerine uyumlu temiz ve anlaşılabilir kod yazmanız önemlidir. N Katmanlı Mimari
stilinde bir proje hazırlamanız istenilmektedir. Id, Date gibi alanlar için BaseEntity classı kullanabilirsiniz.
