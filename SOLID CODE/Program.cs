using SOLID_CODE;
using SOLID_CODE.DependencyInversion;
using SOLID_CODE.Interface_Segregation;
using SOLID_CODE.LiskovSubstitution;
using SOLID_CODE.OpenClosed;
using SOLID_CODE.SingleResponsibility;
using System.Drawing;
using System.Reflection.Metadata;

//SİNGLE REPONSİBİLİTY
Console.WriteLine("Single Responsibilityi ihlal eden kod");
User user = new User("İbrahim Koç", "ikoc@example.com");
user.SaveToDatabase();
user.SendEmail("Hello World");
user.DisplayUserInfo();
//


Console.WriteLine("\nSingle Responsibility ye uygun kod");
Userr userr = new Userr("İbrahim Koç", "ikoc@example.com");
UserRepository repository = new UserRepository();
EmailService emailService = new EmailService();
UserDisplayService displayService = new UserDisplayService();

repository.SaveToDatabase(user);
emailService.SendEmail(user.Email, "Welcome!");
displayService.DisplayUserInfo(user);


Console.WriteLine("\nOpen Closed ihlal eden kod");

Shape circle = new Shape { Type = "Daire", Radius = 5 };
Shape rectangle = new Shape { Type = "Dikdortgen", Width = 4, Height = 6 };

Console.WriteLine("Daire Alanı: " + circle.CalculateArea());
Console.WriteLine("Dikdörtgen Alanı: " + rectangle.CalculateArea());

Console.WriteLine("\nOpen Closed prensibine uygun kod");

Shape2 circle2 = new Circle2(5);
Shape2 rectangle2 = new Rectangle2(4, 6);

Console.WriteLine("Daire Alanı: " + circle2.CalculateArea2());
Console.WriteLine("Dikdörtgen Alanı: " + rectangle2.CalculateArea2());

//LISKOV SUBSTITUTION

Console.WriteLine("\nLiskov Substitution ihlal eden kod");

Rectangle3 rect = new Rectangle3 { Width = 4, Height = 5 };
Console.WriteLine("Dikdörtgen Alanı: " + rect.CalculateArea3());

Rectangle3 square = new Square3 { Width = 4 };
Console.WriteLine("Kare Area: " + square.CalculateArea3());


Console.WriteLine("\nLiskov Substitution prensibine uygun kod");
Shape4 rect4 = new Rectangle4(4, 5);
Console.WriteLine("Dikdörtgen Alanı: " + rect4.CalculateArea4());

Shape4 square4 = new Square4(4);
Console.WriteLine("Kare Area: " + square4.CalculateArea4());


//İNTERFACE SEGREGATİON

Console.WriteLine("\nİnterface Segregation ihlal eden kod");

IAnimal dog = new Dog();
dog.Eat();
dog.Bark();
// dog.Fly(); // Bu metot çalıştırıldığında NotImplementedException atar

IAnimal bird = new Bird();
bird.Eat();
bird.Fly();
// bird.Bark(); // Bu metot çalıştırıldığında NotImplementedException atar

Console.WriteLine("\nİnterface Segregation prensibine uygun kod");

IAnimal2 dog2 = new Dog2();
dog.Eat();

IBarkable barkingDog = new Dog2();
barkingDog.Bark();

IAnimal2 bird2 = new Bird2();
bird.Eat();

IFlyable flyingBird = new Bird2();
flyingBird.Fly();

//DEPENDENCY İNVERSİON

Console.WriteLine("\nDependency İnversion ihlal eden kod");
Notification notification = new Notification();
notification.Notify("Hello, Dependency Inversion Principle!");

Console.WriteLine("\nDependency İnversion prensibine uygun kod");

IMessageService emailService3 = new EmailService3();
Notification2 emailNotification = new Notification2(emailService3);
emailNotification.Notify("Hello, Dependency Inversion Principle!");

IMessageService smsService = new SmsService();
Notification2 smsNotification = new Notification2(smsService);
smsNotification.Notify("Hello, Dependency Inversion Principle via SMS!");