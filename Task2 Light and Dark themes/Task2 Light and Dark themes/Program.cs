using Dark;
using Iinterface;
using Light;

class Program 
{
    public static void Main(string[] args)
    {
		System.Console.WriteLine("Choose a theme: light or dark");
		string themeChoice = Console.ReadLine()?.ToLower();

		IGuiFactory themeFactory;

		if(themeChoice == "light")
		{
			themeFactory = new LightTheme();
		}
		else if(themeChoice == "dark")
		{
			themeFactory = new DarkTheme();
		}
		else
		{
			System.Console.WriteLine("Invalid theme choice");
			return;
		}
		
		IButton button = themeFactory.CreateButton();
		ICheckBox checkBox = themeFactory.CreateCheckBox();
		ITextBox textBox = themeFactory.CreateTextBox();

		button.Button();
		checkBox.CheckBox();
		textBox.TextBox();
	}
}