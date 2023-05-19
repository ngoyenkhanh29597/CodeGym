namespace BMICalculation;
class Program
{
    static void Main(string[] args)
    {
        //Enter height and weight
        Console.Write("Enter your height (m): ");
        double height = double.Parse(Console.ReadLine());
        Console.Write("Enter your weight (kg): ");
        double weight = double.Parse(Console.ReadLine());
        double bmi = weight/Math.Pow(height,2);
        Console.WriteLine("BMI value: " +bmi);

        //Define your body's condition
        if (bmi < 18.5)
            Console.WriteLine("Underweight");
        else if (bmi < 25.0)
            Console.WriteLine("Normal");
        else if (bmi < 30.0)
            Console.WriteLine("Overweight");
        else
            Console.WriteLine("Obese");
    }
}

