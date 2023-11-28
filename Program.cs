using System.Drawing;
using System.Collections.Generic;

Console.WriteLine("GenericCollection !");
List<int> valuelist = new List<int>();
valuelist.Add(23);//Listeye eleman ekleme
valuelist.Add(5);
valuelist.Add(12);
valuelist.Add(18);
valuelist.Add(1);

List<string> colours = new List<string>();
colours.Add("Red");
colours.Add("Blue");
colours.Add("Yellow");
colours.Add("black");

Console.WriteLine(colours.Count);
Console.WriteLine(valuelist.Count);

foreach (var color in colours)
{
    Console.WriteLine(color);
}


foreach (var value in valuelist)
{
    Console.WriteLine(value);
}

valuelist.ForEach(value=> Console.WriteLine(value));


//Listeden eleman çıkarma
valuelist.Remove(1);
colours.Remove("Red");

valuelist.ForEach(value=> Console.WriteLine(value));//Foreach kısa hali
colours.ForEach(color=> Console.WriteLine(color));


//Liste içersinde arama
if(valuelist.Contains(1))
 Console.WriteLine("1 Liste içinde bulundu.");
else
Console.WriteLine("1 bulunamadı");

//Eleman ile index' erişme
Console.WriteLine(colours.BinarySearch("Black"));

//Liste nasıl temizlenir ?
colours.Clear();


 




