#version 330 core
out vec4 FragColor;

in vec2 TexCoords;

uniform sampler2D screenTexture;

const float offset = 1.0 / 30.0;  

void main()
{
    vec2 offsets[9] = vec2[](
        vec2(-offset,  offset), // ÁÂÃø »ó´Ü
        vec2( 0.0f,    offset), // Áß¾Ó »ó´Ü
        vec2( offset,  offset), // ¿ìÃø »ó´Ü
        vec2(-offset,  0.0f),   // ÁÂÃø Áß¾Ó
        vec2( 0.0f,    0.0f),   // Á¤Áß¾Ó
        vec2( offset,  0.0f),   // ¿ìÃø Áß¾Ó
        vec2(-offset, -offset), // ÁÂÃø ÇÏ´Ü
        vec2( 0.0f,   -offset), // Áß¾Ó ÇÏ´Ü
        vec2( offset, -offset)  // ¿ìÃø ÇÏ´Ü   
    );

    float kernel[9] = float[](
        -1, -1, -1,
        -1,  9, -1,
        -1, -1, -1
    );

    float highPassKernel[9] = float[](
         0, -1,  0,
        -1,  4, -1,
         0, -1,  0
    );

    float horizontalEdgeKernel[9] = float[](
        -1, -2, -1,
         0,  0,  0,
         1,  2,  1
    );

    float verticalEdgeKernel[9] = float[](
        -1, 0, 1,
        -2, 0, 2,
        -1, 0, 1
    );

    float horizontalSobelEdgeKernel[9] = float[](
        -1 / 4, -2 / 4, -1 / 4,
         0 / 4,  0 / 4,  0 / 4,
         1 / 4,  2 / 4,  1 / 4
    );

    float verticalSobelEdgeKernel[9] = float[](
        -1 / 2, 0 / 2, 1 / 2,
        -2 / 2, 0 / 2, 2 / 2,
        -1 / 2, 0 / 2, 1 / 2
    );

    // 3x3 Smoothing Kernel(Filter)
    float blurKernel[9] = float[](
    1.0 / 25, 3.0 / 25, 1.0 / 25,
    3.0 / 25, 9.0 / 25, 3.0 / 25,
    1.0 / 25, 3.0 / 25, 1.0 / 25  
    );

    vec3 sampleTex[9];
    for(int i = 0; i < 9; i++)
    {
        sampleTex[i] = vec3(texture(screenTexture, TexCoords.st + offsets[i]));
    }
    vec3 col = vec3(0.0);
    for(int i = 0; i < 9; i++)
        col += sampleTex[i] * blurKernel[i];
    
    FragColor = vec4(col, 1.0);
}  