extends Camera3D

var localRotation: Vector2 = Vector2.ZERO

@export var Sensitivity: Vector2 = Vector2(1.0, 1.0)
@export var InvertXAxis: bool = true
@export var InvertYAxis: bool = true

# Called when the node enters the scene tree for the first time.
func _ready():
	pass

# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(_delta):
	get_parent().rotate_object_local(Vector3.UP, localRotation.x)
	rotate_object_local(Vector3.RIGHT, localRotation.y)
	localRotation = Vector2.ZERO

func _input(event):
	if event is InputEventMouseMotion:
		if InvertXAxis:
			localRotation.x = -event.relative.x * get_process_delta_time()
		else:
			localRotation.x = event.relative.x * get_process_delta_time()
		
		if InvertYAxis:
			localRotation.y = -event.relative.y * get_process_delta_time()
		else:
			localRotation.y = event.relative.y * get_process_delta_time()
