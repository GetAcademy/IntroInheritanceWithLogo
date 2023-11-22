using Logo;

Console.ForegroundColor = ConsoleColor.Black;

var program = new Command[]
{
   new Command{Name = "go"},
   new Command{Name = "go"},
   new Command{Name = "turn", Parameter = "1"},
   new Command{Name = "go"},
};

var turtle = new Turtle();
foreach (var command in program)
{
    if (command.Name == "go") turtle.Go();
    else if (command.Name == "turn") turtle.Turn(Convert.ToInt32(command.Parameter));
}
