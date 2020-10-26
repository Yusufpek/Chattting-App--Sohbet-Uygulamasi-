# Chatttin-App-Sohbet-Uygulamas-
C# dilinde FireSharp kütüphanesi ile kodladığım sohbet uygulaması

Firebase veri tabanı ve C# dili ile geliştirilmiştir (FireSharp kütüphanesi kullanarak).
-Anlık kullanıcıları veri tabanına kaydeder.
-Her mesajı veri tabanına kaydeder.
-Eğer aktif kullanıcılardan herhangi biri çıkış yaparsa veri tabanı kişinin verisini siler ancak mesajlarına dokunmaz.
-Sadece ortak chat vardır özel mesaj yoktur.

Veri tabanının yapısı:

    -Kullanıcılar, mesajlar, sayac olarak 3 ana başlığa ayrılır.
   
    -Sayac başlığında kullanıcı sayısını ve mesaj sayını görüntüleyerek yeni mesajların ve kullanıcıların id'sini belirler. (deger ve mesaj sayısı olarak 2 değişkeni vardır.)
   
    -Kullanıcılar ve Mesajlar id'lerine göre alt başlıklara ayrılır ve gerekli bilgileri bu id'başlığı altında tutar.

# Not: NuGet paketlerinden FireSharp'ı indirmeyi unutmayınız !!!
