#version 330 core
out vec4 FragColor;

in vec3 Normal;
in vec3 Position;

uniform vec3 cameraPos;
uniform samplerCube skybox;

void main()
{    
    // reflection(¹Ý»ç)
    // vec3 I = normalize(Position - cameraPos);
    // vec3 R = reflect(I, normalize(Normal));
    // FragColor = vec4(texture(skybox, R).rgb, 1.0);

    // refraction(±¼Àý)
    float ratio = 1.00 / 2.42;
    vec3 I = normalize(Position - cameraPos);
    vec3 R = refract(I, normalize(Normal), ratio);
    FragColor = vec4(texture(skybox, R).rgb, 1.0);

    // Material & Refractive index
    // Air              1.00
    // Water            1.33
    // Ice              1.309
    // Glass            1.52
    // Diamond          2.42
}