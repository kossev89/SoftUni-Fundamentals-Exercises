using System.Text;

int heroesNumber = int.Parse(Console.ReadLine());
List<Hero> heroes = new List<Hero>();
for (int i = 0; i < heroesNumber; i++)
{
    string[] heroInfo = Console.ReadLine()
        .Split();
    string heroName = heroInfo[0];
    int hP = int.Parse(heroInfo[1]);
    int mP = int.Parse(heroInfo[2]);
    if (heroes.FirstOrDefault(n => n.Name == heroName) == null)
    {
        Hero hero = new Hero(heroName, hP, mP);
        heroes.Add(hero);
    }
    else
    {
        continue;
    }
}
string command = Console.ReadLine();

while (command != "End")
{
    string[] commandTokens = command
        .Split(" - ", StringSplitOptions.RemoveEmptyEntries);
    string action = commandTokens[0];
    string heroeName = commandTokens[1];
    Hero currentHero = heroes.FirstOrDefault(h => h.Name == heroeName);
    if (action == "CastSpell")
    {
        int mPneeded = int.Parse(commandTokens[2]);
        string spellName = commandTokens[3];
        currentHero.CastSpell(heroeName, mPneeded, spellName);
    }
    else if (action == "TakeDamage")
    {
        int damage = int.Parse(commandTokens[2]);
        string attacker = commandTokens[3];
        currentHero.TakeDamage(heroeName, damage, attacker);
        if (currentHero.IsDead())
        {
            heroes.Remove(currentHero);
        }
    }
    else if (action == "Recharge")
    {
        int mPamount = int.Parse(commandTokens[2]);
        currentHero.Recharge(heroeName, mPamount);
    }
    else if (action == "Heal")
    {
        int hPamount = int.Parse(commandTokens[2]);
        currentHero.Heal(heroeName, hPamount);
    }
    command = Console.ReadLine();
}
List<StringBuilder> output = new List<StringBuilder>();
foreach (var hero in heroes)
{
    StringBuilder sb = new StringBuilder();
    sb.AppendLine($"{hero.Name}");
    sb.AppendLine($"  HP: {hero.HP}");
    sb.AppendLine($"  MP: {hero.MP}");
    output.Add(sb);
}
foreach (var sb in output)
{
    Console.Write(sb);
}
public class Hero
{
    public Hero(string name, int hP, int mP)
    {
        Name = name;
        HP = hP;
        MP = mP;
    }
    public string Name { get; set; }
    public int HP { get; set; }
    public int MP { get; set; }
    public void CastSpell(string heroName, int mPneeded, string spellName)
    {
        if (MP >= mPneeded)
        {
            MP -= mPneeded;
            Console.WriteLine($"{Name} has successfully cast {spellName} and now has {MP} MP!");
        }
        else
        {
            Console.WriteLine($"{Name} does not have enough MP to cast {spellName}!");
        }
    }
    public void TakeDamage(string heroName, int damageTaken, string attacker)
    {
        HP -= damageTaken;
        if (HP > 0)
        {
            Console.WriteLine($"{Name} was hit for {damageTaken} HP by {attacker} and now has {HP} HP left!");
        }
        else
        {
            Console.WriteLine($"{Name} has been killed by {attacker}!");
        }
    }
    public void Recharge(string heroName, int amountMp)
    {
        int mpLost = 200 - MP;
        MP += amountMp;
        int recoveredMp = 0;
        if (MP > 200)
        {
            MP = 200;
            recoveredMp = mpLost;
        }
        else
        {
            recoveredMp = amountMp;
        }
        Console.WriteLine($"{heroName} recharged for {recoveredMp} MP!");
    }
    public void Heal(string heroName, int amountHp)
    {
        int hpLost = 100 - HP;
        HP += amountHp;
        int recoveredHp = 0;
        if (HP > 100)
        {
            HP = 100;
            recoveredHp = hpLost;
        }
        else
        {
            recoveredHp = amountHp;
        }
        Console.WriteLine($"{Name} healed for {recoveredHp} HP!");
    }

    public bool IsDead()
    {
        bool isDead = false;
        if (HP <= 0)
        {
            isDead = true;
        }
        return isDead;
    }
}