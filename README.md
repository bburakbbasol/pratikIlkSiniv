# Kışi Bilgi Sistemi Projesi

Bu proje, bir kişi nesnesi oluşturarak kişi bilgilerini ekrana yazdıran basit bir C# uygulamasıdır.

## Dosya Yapısı

- **Program.cs**: Ana program dosyasıdır. Main metodu burada bulunur ve kişi nesneleri oluşturulup kullanılır.
- **Person.cs**: Kişi bilgilerini tutan ve işleyen `Person` sınıfını tanımlar.

## Kullanım

### Person Nesnesi Oluşturma

`Person` sınıfı kullanılarak bir kişi nesnesi oluşturulur ve ad, soyad, doğum tarihi gibi bilgiler atanır.

### Create Metodu

Kişi tipi (öğrenci veya öğretmen) belirlenir ve kişi bilgileri ekrana yazdırılır.

## Örnek Kullanım

```csharp
Person ogrenci = new Person();
ogrenci.Name = "Burak";
ogrenci.Surname = "Başol";
ogrenci.Date = 1999;
ogrenci.Create("öğrenci");

Person ogretmen = new Person();
ogretmen.Name = "Mehmet";
ogretmen.Surname = "Turgut";
ogretmen.Date = 1978;
ogretmen.Create("öğretmen");
