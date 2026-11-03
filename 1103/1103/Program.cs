#region Game

Coins();

static void Coins()
{
    int stake;
    int goal;
    int times = 10000;
    int wins = 0, losses = 0;
    long total = 0;

    Random rnd = new Random();

    for (int i = 1; i <= times; i++)
    {
        stake = 10;
        goal = 100;
        int cnt = 0;
        while (!(stake == 0 || goal == stake))
        {
            cnt++;
            if (rnd.Next(2) == 0)
                stake++;
            else
                stake--;
        }
        Console.Write($"{cnt} ");
        total += cnt;
        if (stake == 0)
            losses++;
        else if (stake == goal)
            wins++;
    }
    Console.WriteLine($"Average number of trials: {total / (double)times}");

    Console.WriteLine($"Wins: {wins}, Losses: {losses}");
}
#endregion


#region DateTime
DateTime azi = DateTime.Now;
DateTime maine = azi.AddDays(1);
Console.WriteLine(azi);
Console.WriteLine(azi.Hour);
Console.WriteLine(azi.AddHours(42));
Console.WriteLine(azi.ToShortDateString());
Console.WriteLine(azi.ToShortTimeString());
Console.WriteLine(maine.Subtract(azi).TotalHours);
Console.WriteLine(maine.Subtract(azi).TotalMinutes);




int a1 = 2026, l1 = 11, z1 = 3;
int a2 = 2006, l2 = 2, z2 = 25;

Console.WriteLine($"Numarul de zile dintre cele doua date este {DaysDiff((a1, l1, z1), (a2, l2, z2))}");

int DaysDiff((int a, int l, int z) date1, (int a, int l, int z) date2)
{
    int result = 0;

    while (!(date1.a == date2.a && date1.l == date2.l && date1.z == date2.z))
    {
        result++;
        // scad o zi din date1
        if (date1.z > 1)
            date1.z--;
        else
        {
            switch (date1.l)
            {
                case 2:
                case 4:
                case 6:
                case 8:
                case 9:
                case 11:
                    date1.z = 31;
                    date1.l--;
                    break;
                case 1:
                    date1.z = 31;
                    date1.l = 12;
                    date1.a--;
                    break;
                case 3:
                    date1.z = 28;
                    if (bisect(date1.a))
                        date1.z++;
                    date1.l--;
                    break;
                case 5:
                case 7:
                case 10:
                case 12:
                    date1.z = 30;
                    date1.l--;
                    break;
            }
        }
    }


    return result;
}

bool bisect(int a)
{
    return (a % 4 == 0 && a % 100 != 0) || (a % 400 == 0);
}
#endregion