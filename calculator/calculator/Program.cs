

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            double flatLaborCost = 75; // Flat labor cost

            Console.WriteLine("Welcome to the Lawncare and Tree Trimming Service Calculator!");

            Console.WriteLine("Enter Client Name:");
            string customerName = Console.ReadLine(); // Customer name

            Console.WriteLine("Enter the Width of the Lawn (in feet):");
            double lawnWidth = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Length of the Lawn (in feet):");
            double lawnLength = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Color of Mulch for the Flowerbed:");
            string mulchColor = Console.ReadLine();

            Console.WriteLine("Enter the Length of Flowerbed (in feet):");
            double flowerLength = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Width of the Flowerbed (in feet):");
            double flowerWidth = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Height of the Mulch layer (in inches):");
            double flowerHeight = double.Parse(Console.ReadLine());

            Console.WriteLine("Trim Your Trees? (1 for YES, 0 for NO):");
            int trimTree = int.Parse(Console.ReadLine());

            // Calculations
            double areaLawn = (lawnLength * lawnWidth) / 9; // in square yards
            double mowingCost = areaLawn * 20;

            double flowerHeightFeet = flowerHeight * 0.08333;
            double flowerArea = flowerLength * flowerWidth;
            double mulchVolumeCubicYards = (flowerArea * flowerHeightFeet) / 27;
            double mulchCost = 0.1 * mulchVolumeCubicYards;

            double trimTreeCost = trimTree == 1 ? 550 : 0;
            double totalCost = mowingCost + mulchCost + trimTreeCost + flatLaborCost;

            // Output
            Console.WriteLine($"Client Name: {customerName}");
            Console.WriteLine($"Area of Lawn: {areaLawn:0.00} sq yds");
            Console.WriteLine($"Lawn Mowing Cost: {mowingCost:c}");
            Console.WriteLine($"Area of Flowerbed: {mulchVolumeCubicYards:0.00} cubic yds");
            Console.WriteLine($"Mulch Color: {mulchColor}");
            Console.WriteLine($"Mulching Cost: {mulchCost:c}");
            Console.WriteLine($"Tree Trimming Cost: {trimTreeCost:c}");
            Console.WriteLine($"The Total Cost of Labor is: {totalCost:c}");

            Console.ReadLine(); // Wait before closing
        }
    }
}
