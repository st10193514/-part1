using System;

class Recipe
{
    private string[] ingredients;
    private double[] quantities;
    private string[] units;
    private string[] steps;

    public Recipe()
    {
        Console.Write("Enter the number of ingredients: ");
        int numIngredients = Convert.ToInt32(Console.ReadLine());

        ingredients = new string[numIngredients];
        quantities = new double[numIngredients];
        units = new string[numIngredients];

        for (int i = 0; i < numIngredients; i++)
        {
            Console.Write("Enter the name of ingredient {0}: ", i + 1);
            ingredients[i] = Console.ReadLine();

            Console.Write("Enter the quantity of {0} in {1}: ", ingredients[i], units[i]);
            quantities[i] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the unit of measurement for {0}: ", ingredients[i]);
            units[i] = Console.ReadLine();
        }

        Console.Write("Enter the number of steps: ");
        int numSteps = Convert.ToInt32(Console.ReadLine());

        steps = new string[numSteps];

        for (int i = 0; i < numSteps; i++)
        {
            Console.Write("Enter step {0}: ", i + 1);
            steps[i] = Console.ReadLine();
        }
    }

    public void Display()
    {
        Console.WriteLine("\nRecipe:\n");

        for (int i = 0; i < ingredients.Length; i++)
        {
            Console.WriteLine("{0} {1} {2}", quantities[i], units[i], ingredients[i]);
        }

        Console.WriteLine("\nInstructions:\n");

        for (int i = 0; i < steps.Length; i++)
        {
            Console.WriteLine("{0}. {1}", i + 1, steps[i]);
        }
    }

    public void Scale(double factor)
    {
        for (int i = 0; i < quantities.Length; i++)
        {
            quantities[i] *= factor;
        }
    }

    public void Reset()
    {
        Console.WriteLine("Resetting quantities to original values.");
        // TODO: Reset quantities to original values
    }
}

class Program
{
    static void Main(string[] args)
    {
        Recipe recipe = new Recipe();

        recipe.Display();

        Console.Write("\nEnter scale factor (0.5, 2, or 3): ");
        double factor = Convert.ToDouble(Console.ReadLine());

        recipe.Scale(factor);
        recipe.Display();

        Console.WriteLine("\nEnter 'reset' to reset quantities to original values.");
        Console.WriteLine("Enter 'new' to enter a new recipe.");
        Console.WriteLine("Enter 'exit' to exit the program.");

        string input = Console.ReadLine();

        while (input != "exit")
        {
            if (input == "reset")
            {
                recipe.Reset();
                recipe.Display();
            }
            else if (input == "new")
            {
                recipe = new Recipe();
                recipe.Display();
            }

            Console.Write("\nEnter scale factor (0.5, 2, or 3): ");
            factor = Convert.ToDouble(Console.ReadLine());

            recipe.Scale(factor);
            recipe.Display();

            Console.WriteLine("\nEnter 'reset' to reset quantities to original values.");
            Console.WriteLine("Enter 'new' to enter a new recipe.");
            Console.WriteLine("Enter 'exit' to exit the program.");

            input = Console.ReadLine();
        }
    }
}
