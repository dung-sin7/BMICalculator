namespace BMICalculator;
class Program
{
    static void Main(string[] args)
    {
        float height;
        float weight;

        Console.Write("Please enter a height: ");
        height = float.Parse(Console.ReadLine());
        Console.Write("Please enter your weight: ");
        weight = float.Parse(Console.ReadLine());
        float bmi = weight / (float)Math.Pow(height, 2);
        bmi = (float)Math.Round(bmi, 2);
        Console.WriteLine($"{BMICalculator(bmi)}!");
    }

    public static string BMICalculator(float bmi)
    {
        if (bmi < 18.5) return "Underweight";
        else if (bmi >= 18.5 && bmi <= 25) return "Normal";
        else if (bmi >= 25 && bmi <= 30) return "Overweight";
        else return "Obese";
    }
}
