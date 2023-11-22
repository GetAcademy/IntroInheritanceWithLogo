using Logo;

Console.ForegroundColor = ConsoleColor.Black;

var program = new Command[]
{
    new Command{Name = "pen", Parameter = "green"},
   new Command{Name = "go"},
   new Command{Name = "go"},
   new Command{Name = "go"},
   new Command{Name = "turn", Parameter = "right"},
   new Command{Name = "go"},
   new Command{Name = "turn", Parameter = "right"},
   new Command{Name = "go"},
   new Command{Name = "go"},
   new Command{Name = "pen", Parameter = "blue"},
   new Command{Name = "turn", Parameter = "left"},
   new Command{Name = "go"},
   //new Command{Name = "go"},
   //new Command{Name = "pen", Parameter = "blue"},
   //new Command{Name = "go"},
   //new Command{Name = "go"},
   //new Command{Name = "go"},
};

var turtle = new Turtle();
foreach (var command in program)
{
    if (command.Name == "go")
    {
        turtle.Go();
    }
    else if (command.Name == "turn")
    {
        var direction = Direction.Parse(command.Parameter, true);
        turtle.Turn(direction);
    }
    else if (command.Name == "pen")
    {
        var isSuccess = Enum.TryParse(command.Parameter, true, out ConsoleColor pen);
        turtle.SetPen(isSuccess ? pen : null);
    }
    Thread.Sleep(200);
}

Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Black;
Console.CursorTop = 20;
