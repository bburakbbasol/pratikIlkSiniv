using pratikIlkSınıv; // Person sınıfını içeren özel namespace
using System;

class program
{
	static void Main()
	{
		// Bir öğrenci nesnesi oluşturuluyor ve değerler atanıyor
		Person ogrenci = new Person();
		ogrenci.Name = "Burak";
		ogrenci.Surname = "Başol";
		ogrenci.Date = 1999;
		string title = "öğrenci";
		ogrenci.Create(title);

		// Bir öğretmen nesnesi oluşturuluyor ve değerler atanıyor
		Person ogretmen = new Person();
		ogretmen.Name = "Mehmet";
		ogretmen.Surname = "Turgut";
		ogretmen.Date = 1978;
		title = "öğretmen";
		ogretmen.Create(title);
	}
}