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



// //Armiya uchun
// int Army;
// Console.Write("Yoshingizni kiriting: ");
// string inputAge = Console.ReadLine();
// Army = Convert.ToInt32(inputAge);
// bool isMiner = Army < 17;
// bool isOld = Army > 28;
// bool isPossible = Army is 17 or 28;

// if(isMiner)
// {
//     Console.WriteLine("You can not go to Army!");
// }
// else if(isOld)
// {
//     Console.WriteLine("You are too old!");
// } 
// else if(isPossible)
// {
//     Console.WriteLine("You can go with application!");
// }
// else
// {
//     Console.WriteLine("You can go to Army!");
// }