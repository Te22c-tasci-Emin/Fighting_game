using System.CodeDom.Compiler;
using System;

int kazuyaHp = 100;

int heihatchiHp = 100;

int weaponedmg = 100;

string weaponsdmg = "WDamgage";

String kazuyaName = "kazuya";
String heihatchiName = "heihatchi";

int kazuyaAccuracy = 100;
int kazuyaWeaponDamage = 30;


int heihatchiAccuracy = 100;
int heihatchiWeaponDamage = 30;

Random generator = new Random();
start();

void start()
{
    Console.WriteLine("Choose your Weapons");

    Console.WriteLine("A) = Heihatchi hairline, B) = KAzuya outfit, C) HaDOKEN");

    // läs in val

    // Om man valt a, accuracy = 45
    // Om man valt b, accuracy = 60
    // Om man inte valt, accuracy = 80


weaponsdmg = weaponsdmg.ToLower();

    if (weaponsdmg == "a)")
    {

      kazuyaWeaponDamage = 45;
      kazuyaAccuracy = 70;

    }

      else if (weaponsdmg == "b)")
     {
         kazuyaWeaponDamage = 30;
        kazuyaAccuracy = 15;

     }

     else if (weaponsdmg == "c)")
     {
     kazuyaAccuracy = 20;
     kazuyaWeaponDamage = 90;

    }
    Console.ReadLine();
}


while (kazuyaHp > 0 && heihatchiHp > 0)
{
    Console.WriteLine("--------------- Ny Runda ----------------------");
    Console.WriteLine($"Demonen {kazuyaName} har nu {kazuyaHp} hp");

    int doesheyahit = generator.Next(100);
    if (doesheyahit < kazuyaAccuracy)
    {
        int heihatchidamage = generator.Next(kazuyaWeaponDamage);
        kazuyaHp -= heihatchidamage;
        kazuyaHp = Math.Max(0, kazuyaHp);
        Console.WriteLine($"{heihatchiName} Slår och gör {heihatchidamage} damage gjord, nya hp = {kazuyaHp}");
    }
    else
    {
        Console.WriteLine($"{heihatchiName} Slår och gör Missed AHHAHAHAHAHAH");
    }
    int doesKuzuaHit = generator.Next(100);
    if (doesKuzuaHit < kazuyaAccuracy)
    {
        int kazuyadamage = generator.Next(kazuyaWeaponDamage);
        heihatchiHp -= kazuyadamage;
        heihatchiHp = Math.Max(0, heihatchiHp);
        Console.WriteLine($"{kazuyaName} Slår och gör {kazuyadamage} damage gjord, nya hp = {heihatchiHp}");

        Console.WriteLine("Press buttonis för att fortsätta.");
        Console.ReadKey();
    }
    else
    {
        Console.WriteLine($"{kazuyaName} Slår och gör Missed AHHAHAHAHAHAH");
    }
}

Console.WriteLine("Game over");

if (heihatchiHp <= 0 && kazuyaHp <= 0)
{
    Console.WriteLine("TIED");
}

else if (heihatchiHp <= 0)

{
    Console.WriteLine("Kazuya Wins");
}
else
{
    Console.WriteLine("Heihatchi Wins");

}






Console.ReadLine();








