shader_type canvas_item;

uniform sampler2D screen_texture : hint_screen_texture, repeat_disable, filter_nearest;

void fragment() {
	vec4 color = texture(screen_texture, SCREEN_UV);
	float mcolor = max(color.r, max(color.g, color.b));
	COLOR = vec4(mcolor, mcolor, mcolor, 1.0f);
}
