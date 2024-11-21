//1.Operations on strings - String ustida amallar
Console.Write("Enter the Line: ");
string str = Console.ReadLine();
Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
str = number > str.Length ? str.ToUpper() : str.ToLower();
Console.WriteLine("Output: " + str);

//2.Express the value represented by the ternary operator below using if-else. -
//- Quyida ternary operator bilan ifodalandan qiymatni if-else yordamida ifodalang.
int x = 15;
int y = 10;
string result;
if (x > y)
    result = "x is greater then y";
else if (x < y)
    result = "x is less then y";
else if (x == y)
    result = "x is equal to y";
else
    result = "x and y are not comparable";
Console.WriteLine(result);

//3.Create a program that takes a day of the week entered in Uzbek in the Console, translates 
//it into English, and displays the result on the screen. Use the Switch expression! -
//- Consoleda o’zbek tilida kiritilgan hafta kunini ingliz tiliga o’girib,
//natijani ekranga chiqaradigan dastur tuzing. Switch expression dan foydalaning!
Console.Write("Enter a day of the week(in uzbek): ");
string weekInUzbek = Console.ReadLine();
weekInUzbek = weekInUzbek.ToLower();
string weekInEnglish = weekInUzbek switch
{
    "dushanba" => "Monday",
    "seshanba" => "Tuesday",
    "chorshanba" => "Wednesday",
    "payshanba" => "Thursday",
    "juma" => "Friday",
    "shanba" => "Saturday",
    "yakshanba" => "Sunday",
    _ => "The day was entered incorrectly !!!"
};
Console.WriteLine("The day is: "+weekInEnglish);




