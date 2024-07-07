using Godot;

public partial class PlayerCamera : Camera3D
{
	private Vector2 rotation = Vector2.Zero;

	[Export]
	public Vector2 Sensitivity = new Vector2(1.0f, 1.0f);

	[Export]
	public bool InvertXAxis = true;

	[Export]
	public bool InvertYAxis = true;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Basis = Basis.Identity;
		RotateObjectLocal(Vector3.Up, rotation.X);
		RotateObjectLocal(Vector3.Right, rotation.Y);
	}

	public override void _Input(InputEvent @event)
	{
		if (@event is InputEventMouseMotion mouseMotion)
		{
			if (InvertXAxis)
			{
				rotation.X += -mouseMotion.Relative.X * (float)GetProcessDeltaTime();
			}
			else
			{
				rotation.X += mouseMotion.Relative.X * (float)GetProcessDeltaTime();
			}
			if (InvertYAxis)
			{
				rotation.Y += -mouseMotion.Relative.Y * (float)GetProcessDeltaTime();
			}
			else
			{
				rotation.Y += mouseMotion.Relative.Y * (float)GetProcessDeltaTime();

			}
		}
	}
}
