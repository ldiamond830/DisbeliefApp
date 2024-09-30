#version 330

in vec3 Color;
uniform int toggle = 0;
uniform vec3 SolidColor = vec3(-1,-1,-1);
vec3 compliment = vec3(1,1,1);
out vec4 Fragment;

void main()
{
	Fragment = vec4(Color,1);
	
	if(SolidColor.r != -1.0 && SolidColor.g != -1.0 && SolidColor.b != -1.0)
		Fragment = vec4(SolidColor, 1);

	if(toggle == 1){
		
		Fragment = vec4(vec3(compliment - SolidColor), 1);
	}

	return;
}