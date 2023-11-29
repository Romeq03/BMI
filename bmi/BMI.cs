class Program
{

    public static void Bmi()
    {
        Console.WriteLine("Enter your weight in kilograms: ");
        double weight = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter your height in meters: ");
        double hight = Convert.ToDouble(Console.ReadLine());
        double bmi = weight / (hight * hight);
        Console.WriteLine(bmi);

    }
    static void Main(string[] args)
    {
        Bmi();
    }
}