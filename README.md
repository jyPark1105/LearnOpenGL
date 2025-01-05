# **Computer Graphics with LearnOpenGL Tutorial Site**
This repository is based on the official OpenGL tutorial site **[LearnOpenGL]**(https://learnopengl.com) and was created to study computer graphics. Each project focuses on learning key concepts and techniques of OpenGL step by step, with an emphasis on practical implementation and application.

# **Subject**
- Understanding what computer graphics are and their significance
- Learning how to implement computer graphics effectively
- Gaining foundational knowledge and exploring applications in computer graphics:
  - Rendering basic shapes such as triangles
  - Managing memory efficiently using framebuffers
  - Mapping 3D coordinates to 2D screen space
  - Comprehending advanced rendering techniques
  - Exploring additional applications and innovations in the field
  - Understanding the content by actually going through the process of creating a 2D game

# Learning Progress
- Start Date: `2024/11/03`
- End Date: `2025/01/05`
- Number of iterations: `1`

# Version
- OpenGL & GLFW: **3.3**
- CMake: **3.31.0**
- IDE: **Visual Studio 2022**
- Math Library: **glm-0.9.8.0**
- Others:
  - Assimp: **5.4.3**
  - FreeType: **2.13.3**
  - irrKlang: **1.6.0**
    
# Points to Consider 
Assuming the directory containing all projects, along with other directories and files, is located at:
`C:\Users\<username>\Desktop\OpenGL`

Follow the steps below for proper configuration:
--------------------------------------------------
### 1. Include and Library Directories
Set the **Include Directories** and **Library Directories** to the `includes` and `lib` folders, respectively:
- **Location**:
  - **Include Directories**:
    `C:\Users\<user_name>\Desktop\OpenGL\includes`
  - **Library Directories**:
    `C:\Users\<user_name>\Desktop\OpenGL\lib`
- **Configuration Path**:
`Project Properties → Configuration Properties → VC++ Directories`
--------------------------------------------------
### 2. Adding Dependencies
Add the following libraries to **Additional Dependencies**:
- **Dependencies**:
  `glfw3.lib; opengl32.lib; assimp-vc143-mtd.lib;freetype.lib;irrKlang.lib;`
- **Configuration Path**:
`Project Properties → Configuration Properties → Linker → Input → Additional Dependencies`

####**The include folder and library folder are uploaded in compressed ZIP format**.
--------------------------------------------------
### 3. Dynamic Library (DLL) Setup
From the **each section onward**:
- Copy the file `assimp-vc143-mtd.dll`, `freetype.dll`, `irrKlang.dll`, `ikpMP3.dll` (dynamic library) to the directory where the application (`.exe`) is located **before running it**.
- Note:
  - `assimp-vc143-mtd.dll` file: The **Model** and **Mesh** chapters start to use it consistently from **Project 15, in 4-3 parts**
  - `freetype.dll` file: The **Text Rendering** chapters starts to us consistently from **Project 39, in 8-2-1 & 8-2-2 parts**.
  - `irrKlang.dll`, `ikpMP3.dll` files: The **Audio** chapters starts to us consistently from **Project 46, in 8-2-9 parts**.
  - Adjust the **Output Directory** as needed.
    
**Setting the Output Directory**:
- Navigate to:
   `Project Properties → Configuration Properties → General → Output Directory`
- Set the path to the directory containing the corresponding .cpp file:
   `C:\Users\<username>\Desktop\OpenGL\<project_name>\<project_name>`
- If the option **"Place solution and project in the same directory"** was not checked during project creation, this adjustment is required. (In my case, I configured it this way.)
--------------------------------------------------
### 4. Adding `glad.c` to Source Files
Make sure to include `glad.c` in the Source Files section of your project.
