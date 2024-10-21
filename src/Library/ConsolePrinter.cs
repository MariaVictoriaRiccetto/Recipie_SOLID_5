using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(IRecipieContent recipeContent)
        {
            Console.WriteLine(recipeContent.GetTextToPrint());
        }
    }
}