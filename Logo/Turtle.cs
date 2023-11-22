namespace Logo
{
    internal class Turtle
    {
        int _x = 1;
        int _y = 1;
        ConsoleColor? _pen = ConsoleColor.Yellow;
        Direction _direction = Direction.Right;

        public void Go()
        {
            // justere posisjon ut fra retning
            if (_direction == Direction.Left) _x--;
            else if (_direction == Direction.Right) _x++;
            else if (_direction == Direction.Down) _y++;
            else if (_direction == Direction.Up) _y--;

            // tegne opp ruten vi kommer til, hvis penn er nede
            Console.SetCursorPosition(_x, _y);
            Console.BackgroundColor = _pen ?? ConsoleColor.Black;
            var c = _direction switch
            {
                Direction.Left => '<',
                Direction.Right => '>',
                Direction.Up => '^',
                Direction.Down => 'v',
            };

            Console.Write(c);
        }

        public void Turn(Direction direction)
        {
            _direction = direction;
        }

        public void SetPen(ConsoleColor? pen)
        {
            _pen = pen;
        }
    }
}
