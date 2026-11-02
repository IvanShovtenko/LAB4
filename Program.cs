using System;

void ShowMessage(string text)
{
    Console.WriteLine(text);
}

int AddGold(int gold, int reward)
{
    return gold + reward;
}

bool HasEnoughGold(int gold, int price) => gold >= price;

void ShowStatus(string name, int health, int maxHealth, int gold){
    Console.WriteLine($"Name: {name},\nHealth: {health},\nmaxHealth: {maxHealth},\nGold: {gold}");
}
void ShowMenu(){
    Console.WriteLine($"1. Atak treningowy\n2. Odpoczynek\n3. Koniec gry\nWybór: ");
}
int CalculateDamage(int strength, int weaponDamage)=>strength+weaponDamage;

int Heal(int health, int amount, int maxHealth){
    if(health+amount<=maxHealth){
        return health+amount;
    }
    else {
        return maxHealth;
    }
}
bool IsGameOver(int health)=>health<=0;

string ReadCommand()
{
    while (true)
    {
        Console.Write("Wybierz 1,2 lub 3: ");
        string? command = Console.ReadLine();

        if (command == "1" || command == "2" || command == "3")
        {
            return command;
        }

        Console.WriteLine("Nieznana komenda.");
    }
}

bool CanAfford(int gold, int price){
    if (gold !=price || gold<=price){
        return false;
    }
    else{
        return true;
    }
}
int BuyItem(int gold, int price) => price-gold;



string heroName = "Ada";
int health = 70;
int maxHealth = 100;
int gold = 15;
int strength = 6;
int weaponDamage = 3;
bool isRunning = true;
List<string> inventory = new List<string> { "miecz", "mikstura", "łuk" };
List<string> longNames = inventory.FindAll(item => item.Length > 5);
bool hasPotion = inventory.Exists(item => item == "miecz");


while (isRunning)
{
    Console.WriteLine("====================");
    ShowStatus(heroName,health,maxHealth,gold);
    ShowMenu();
    string? command = Console.ReadLine();

    if (command == "1")
    {
        int damage = CalculateDamage(strength,weaponDamage);
        Console.WriteLine($"Zadajesz {damage} obrażeń manekinowi.");
    }
    else if (command == "2")
    {
        health = Heal(health,10,maxHealth);
        Console.WriteLine($"Odpoczywasz. Masz teraz {health} HP.");
    }
    else if (command == "3")
    {
        if(IsGameOver(health)){
            Console.WriteLine("Koniec gry.");
        }
        else{
            continue;
        }
    }
    else
    {
        Console.WriteLine("Nieznana komenda.");
        isRunning = false;
    }
}

