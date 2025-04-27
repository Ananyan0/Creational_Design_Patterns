using Iinterface;

namespace Dark
{
    class DarkButton : IButton
    {
        public void Button()
        {
            System.Console.WriteLine("Dark Button");
        }
    }

    class DarkCheckBox : ICheckBox
    {
        public void CheckBox()
        {
            System.Console.WriteLine("Dark Checkbox");
        }
    }

    class DarkTextBox : ITextBox
    {
        public void TextBox()
        {
            System.Console.WriteLine("Dark Textbox");
        }
    }

    class DarkTheme : IGuiFactory
    {
        public IButton CreateButton() => new DarkButton();
        public ICheckBox CreateCheckBox() => new DarkCheckBox();
        public ITextBox CreateTextBox() => new DarkTextBox();
    }
}
