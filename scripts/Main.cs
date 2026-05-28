using Godot;

namespace BubbleFlow;

public partial class Main : Node2D
{
    private const float Speed = 10f;
    private static readonly Vector2 Size = new(10, 10);
    private static readonly Vector2 Screen = new(640, 480);
    private Vector2 _pos;

    public override void _Ready()
    {
        _pos = (Screen - Size) * 0.5f;
        Position = _pos;
    }

    public override void _Process(double delta)
    {
        var dir = Input.GetVector("move_left", "move_right", "move_up", "move_down");
        _pos += dir * Speed * (float)delta;
        _pos = _pos.Clamp(Vector2.Zero, Screen - Size);
        Position = _pos;
    }

    public override void _Draw()
    {
        DrawRect(new Rect2(Vector2.Zero, Size), Colors.White);
    }
}
