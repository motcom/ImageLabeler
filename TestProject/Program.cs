// See https://aka.ms/new-console-template for more information

using System;
using System.Drawing;
using System.Drawing.Text;

class Program
{
    static void Main()
    {
        InstalledFontCollection fontsCollection = new InstalledFontCollection();
        FontFamily[] fontFamilies = fontsCollection.Families;

        foreach (FontFamily font in fontFamilies)
        {
            Console.WriteLine(font.Name);
        }
    }
}
