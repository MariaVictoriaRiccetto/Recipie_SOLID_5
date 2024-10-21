using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IRecipieContent recipieContent)
        {
            File.WriteAllText("Recipe.txt", recipieContent.GetTextToPrint());
        }
    }
}