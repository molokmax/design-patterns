namespace Prototype;

internal class Program
{
    static void Main(string[] args)
    {
        var widgets = new List<IComponent>();
        var button1 = new Button { Id = "1", Text = "Ok" };
        widgets.Add(button1);
        var input1 = new Input { Id = "2", Value = "placeholder" };
        widgets.Add(input1);

        var widgetCopies = widgets.Select(x => x.Clone()).ToList();

        foreach (var widget in widgetCopies)
        {
            Console.WriteLine(widget.GetInfo());
        }
    }
}
