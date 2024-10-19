// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");


Personel p = new Personel();


// Properties  kısa ismi proptur.
// personel nesnesi içerisindeki Id isimli properties'e erişerek değer atatık
// Id id isimli properties'de nesne içerisindeki private olan id değerindeki değişkene değeri kontrollü bir biçimde atadı

// Prop'lar üzerinden get ve set yapabilmek kolaydır bir önceki konu gibi
// iki ayrı metot yazılmadığı için karışıklık olmaz, hem set hem get'i prop üzerinden yapabilirz


Console.WriteLine("Id alanının değeri : {0} ",p.Id);


// değer ataması yapalım
// Prop üzerinden Set yapalım
p.Name="Kazım";
// Prop Üzerinden Get yapalım
Console.WriteLine("Ad : {0}",p.Name);



