namespace Iinterface
{
    interface IButton
    {
        void Button();
    }

    interface ICheckBox
    {
        void CheckBox();
    }

    interface ITextBox
    {
        void TextBox();
    }

    interface IGuiFactory
    {
        IButton CreateButton();
        ICheckBox CreateCheckBox();
        ITextBox CreateTextBox();
    }
}
