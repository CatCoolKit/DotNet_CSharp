namespace Bmi
{
    /// <summary>
    /// This class provides a function to calculate the BMI of any individual, based on body parameters: height, weight.
    /// </summary>
    public class BmiCalculator
    {

        /// <summary>
        /// Calculates the BMI of an individual based on their weight and height.
        /// </summary>
        /// <param name="weight">The weight of the individual in kilograms.</param>
        /// <param name="height">The height of the individual in meters.</param>
        /// <returns>The BMI of the individual.</returns>
        public static double GetBmi(double weight, double height)
        {
            return weight / (height * height);
        }

        public static void PrintBmiMessage()
        {
            Console.WriteLine("This program calculates the Body Mass Index (BMI) of an individual based on their weight and height.");
        }
    }
}
