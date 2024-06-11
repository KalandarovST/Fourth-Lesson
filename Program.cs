using System;
string ism;
string familiya;
int ball;

Console.WriteLine("Assalmu Aleykum!");
Console.Write("Ism: ");
ism = Console.ReadLine();
Console.Write("Familiya: ");
familiya = Console.ReadLine();
Console.Write("Ball: ");
string inputBall = Console.ReadLine();
ball = Convert.ToInt32(inputBall);
bool overal1 = ball < 56;
bool overal2 = ball == 56;
bool overal3 = ball > 56 && ball < 180;

if(overal1) 
{
    Console.WriteLine($"Kechirasiz, {ism} {familiya} siz talabalikka qabul qilinmadingiz");
}
else if (overal2)
{
    Console.WriteLine($"Siz {ism} {familiya} superkontrakt to`lab o`qishingiz mumkin!");
}
else if (overal3)
{
    Console.WriteLine($"Tabriklaymiz, {ism} {familiya} siz talaba bo`ldingiz!");
}
