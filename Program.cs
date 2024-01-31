using System.Collections.Generic;
using System.Net.Http.Headers;

namespace My_Cool_Programs;

class Opp
{
    public string name;
    public string role;
    public string ultimate;
    public float health;

    public Opp(string _name, string _role, string _ultimate)
    {
        name = _name;
        role = _role;
        ultimate = _ultimate;
        health = 500f;
    }
}

class Player
{
    public string name;
    public string role;
    public string ultMove;
    //If you put neither public nor private, it will default to private
    private int ultSlots;
    private float xp;

    //Counts number of players(See line 28 note)
    //Static allows us to access this bit of code from anywhere provided we do (className).(Static function name)
    public static int Count;

//Allows us to assign our characters traits faster. Creates a template.
    public Player(string _name, string _role, string _ultMove)
    {
        name = _name;
        role = _role;
        ultMove = _ultMove;
        ultSlots = 2;
        //will come up as error if 'f' is not put after float #
        xp = 0f;

        //This class is called whever a new player is created. Every time this class is called it adds 1 to the Count. Giving us the total of players.
        Count++;
    }

    public void ultimateAbility()
    {
        if (ultSlots > 0)
        {
            System.Console.WriteLine(name + " used " + ultMove);
            ultSlots--;
            xp += 0.5f;
        }
        else
        {
            System.Console.WriteLine(name + " is out of Ultimates");
        }
        
    }

    public void ReUp()
    {
        System.Console.WriteLine(name + " Slapped himself around a bit to regain Ultimates!");
        ultSlots = 2;
    }
}
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Al Gorythm is trying to kill all GOATS! Its up to you to 4 to stop him!");
        Player player1 = new Player("DanTDM", "Tank", "Shattered Diamond");
        
        Player player2 = new Player("Marky Moo", "Wizard", "Five Nights of Torture");

        Player player3 = new Player("JackSean", "Heals", "Septic Eye");

        Player player4 = new Player("Asbjorn", "Planner", "The Glorius Purpose");
       
        Opp opp1 = new Opp("Al Gorythm", "Villain", "Planetary Devastation");

        System.Console.WriteLine(opp1.name + " says: You losers are no match for me!");
        Thread.Sleep(3000);
        System.Console.WriteLine(player1.name + " says: Don't take the mick out of us! We'll destroy you!");
        Thread.Sleep(3000);
        System.Console.WriteLine(player2.name + " says: Couldn't have said it better myself...");
        Thread.Sleep(3000);
        System.Console.WriteLine(player3.name + " says: Bottom of the morning to you laddy...");
        Thread.Sleep(3000);
        System.Console.WriteLine(player4.name + " says: (Insightful silence)");
        Thread.Sleep(3000);
        System.Console.WriteLine(opp1.name + " says: it seems you are all quite hostile. Let us begin then.");
        Thread.Sleep(1500);
        Console.Write("DanTDM's move! What will you do?");
        DanMove();
    }

    static void DanMove()
    {
        Console.WriteLine("\n1 = Hit\n2 = Ultimate\n3 = Skip");
        int danMove = Convert.ToInt32(Console.ReadLine());
        if (danMove == 1)
        {
            System.Console.WriteLine("DanTDM lunges at Al Gorythm");
            Thread.Sleep(1000);
            Random numGen = new Random();
            int dmg = numGen.Next(10, 30);
            System.Console.WriteLine("DanTDM did " + dmg + " to Al Gorythm");
            
        }
    }
}
