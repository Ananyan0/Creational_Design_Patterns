using Creators;
using Iinterface;


class Program
{
    static void Main(string[] args)
    {
        Creator creator = new InkCreator();

        IDraw brush = creator.Method();

        brush.Draw();
    }
}