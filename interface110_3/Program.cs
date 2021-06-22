using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {

        {
            ITilfældighedsGenerator m = new TilfældighedsGeneratorMock(1);
            Console.WriteLine($"direct mockup terning {m.FindTalTilTerning()}");
            ITilfældighedsGenerator f = new TilfældighedsGeneratorFramework();
            Console.WriteLine($"direct Framework terning {f.FindTalTilTerning()}");
        }

        {
            TilfældighedsGeneratorMock m = new TilfældighedsGeneratorMock(1);
            Terning t1 = new Terning(m);
            Console.WriteLine($"mockup terning using terning {t1.Værdi}");

            TilfældighedsGeneratorFramework f = new TilfældighedsGeneratorFramework();
            Terning t2 = new Terning(f);
            Console.WriteLine($"mockup terning using terning  {t2.Værdi}");

            TilfældighedsGeneratorHttp t = new TilfældighedsGeneratorHttp();
            Terning t3 = new Terning(t);
            Console.WriteLine($"http terning using terning {t3.Værdi}");


        }

        // Hold console åben ved debug (kun nødvendigt ved .NET Framework - ikke .NET Core)
        if (System.Diagnostics.Debugger.IsAttached)
        {
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();
        }

    }
}

public interface ITilfældighedsGenerator
{
    int FindTalTilTerning();
}

public class TilfældighedsGeneratorFramework : ITilfældighedsGenerator
{
    private static System.Random rnd = new System.Random();

    public int FindTalTilTerning()
    {
        return rnd.Next(1, 7);
    }
}

public class TilfældighedsGeneratorMock : ITilfældighedsGenerator
{
    private int tal;
    public TilfældighedsGeneratorMock(int tal)
    {
        this.tal = tal;
    }
    public int FindTalTilTerning()
    {
        return this.tal;
    }
}

public class TilfældighedsGeneratorHttp : ITilfældighedsGenerator
{
   
public int FindTalTilTerning()
{
  using(WebClient w = new WebClient())
  {
            string response = w.DownloadString("https://www.random.org/integers/?num=1&min=1&max=6&col=1&base=10&format=plain&rnd=new");
            return System.Convert.ToInt32(response);
        }
        
  }
}

class Terning
{
    private ITilfældighedsGenerator generator;

    public int Værdi { get; set; }

    public Terning(ITilfældighedsGenerator rnd)
    {
        generator = rnd;
        Ryst();
    }

    public void Ryst()
    {
        this.Værdi = generator.FindTalTilTerning();
    }
}