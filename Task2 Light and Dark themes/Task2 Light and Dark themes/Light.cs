using Iinterface;

namespace Light
{
    class LightButton : IButton
    {
        public void Button()
        {
            System.Console.WriteLine("Light Button");
        }
    }

    class LightCheckBox : ICheckBox
    {
        public void CheckBox()
        {
            System.Console.WriteLine("Light Checkbox");
        }
    }

    class LightTextBox : ITextBox
    {
        public void TextBox()
        {
            System.Console.WriteLine("Light Textbox");
        }
    }





    class LightTheme : IGuiFactory
    {
        public IButton CreateButton() => new LightButton();
        public ICheckBox CreateCheckBox() => new LightCheckBox();
        public ITextBox CreateTextBox() => new LightTextBox();
    }

}
