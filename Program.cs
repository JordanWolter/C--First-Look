namespace HelloWorld
{

       
    class Program
    {
        string artist = "NGHTMARE";

        static void Main(string[] args)
        {

            Program playing = new Program();

            Console.WriteLine(playing.artist);

            Console.WriteLine("Hello World!");

            String name = "Jordan Wolter";
            Console.WriteLine(name);

            int year = 2022;
            Console.WriteLine(year);

            double pi = 3.14159;
            Console.WriteLine(pi);

            bool truth = false; //true;
            Console.WriteLine(truth);
            
            if(!truth){
                Console.WriteLine(name + " " + year);
            }else if(truth)
            {
            Console.WriteLine(pi);
            };

            string[] games = {"CyberPunk", "MW2", "Darktide", "Dark and Darker"};

            foreach (var item in games)
            {
                Console.WriteLine(item);
            };

            for (int i = 0; i < pi; i++)
            {
                Console.WriteLine(pi);
            };

            List<int> coolNumbers = new List<int>();
            coolNumbers.Add(13);
            coolNumbers.Add(9);
            coolNumbers.Add(40);
            coolNumbers.Add(9834);

            coolNumbers.ForEach(item => Console.WriteLine(item));

            
            
        }

        
    }

public class LoveDetector
{
    public static bool Odd(int value)
    {
        return value % 2 != 0;
    }
  
    public static bool Even(int value)
    {
        return value % 2 == 0;
    }
  
    public static bool lovefunc(int flower1, int flower2)
    { 
        //Moment of truth...
      if(Odd(flower1) && Even(flower2) || Even(flower1) && Odd(flower2))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  
}


public class Kata
{
  public static bool Check(object[] a, object x)
  {
    
    foreach(var item in a)
    {
      if(item.Equals(x))
      {
        return true;
      }
    }
      return false;
  }
    
}


public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    int sum = 0;

     foreach(var item in arr)
    {
      if(item > 0)
      {
        sum += item;
      }
    }
      return sum;
  }
}
    
}