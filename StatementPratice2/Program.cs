Console.WriteLine("Rüya Manavına Hoş Geldiniz!");
Console.WriteLine("Elma = 2 TL");
Console.WriteLine("Armut = 3 TL");
Console.WriteLine("Çilek = 2 TL");
Console.WriteLine("Muz = 3 TL");
Console.WriteLine("Diğer bütün meyveler = 4 TL\n");

Console.Write("Hangi meyveyi satın almak istersiniz ? (Elma/Armut/Çilek/Muz/Diğer): ");
string choice = Console.ReadLine();
string fruit = choice.ToLower();

//if (fruit == "elma")
//{
//    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
//}
//else if (fruit == "armut")
//{
//    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
//}
//else if(fruit =="çilek")
//{
//    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
//}
//else if (fruit == "muz")
//{
//    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
//}
//else if (fruit =="diğer")
//{
//    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL");
//}
//else
//{
//    Console.WriteLine("Yanlış seçim yaptınız. Uygulama sona erdi!!!");
//}

// Bu problemi kod yapısını verimli kullanmak ve anlaşılabilir kılmak için switch yöntemi tercih edilmelidir.
//Anlaşılır ve adım adım incelemek için if yapısı ile işlem alınmalıdır.

switch (fruit)
{
    case "elma":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
        break;
    case "armut":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
        break;
    case "çilek":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
        break;
    case "muz":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
        break;
    case "diğer":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL");
        break;
    default:
        Console.WriteLine("Yanlış seçim yaptınız. Uygulama sona erdi!!!");
        break; 
}