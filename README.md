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
 
# Version
- OpenGL: **3.3**
- CMake: **3.31.0**
- IDE: **Visual Studio 2022**
- Math Library: **glm-0.9.8.0**
- Others:
  - GLFW: **3.3**
  - Assimp: **5.4.3**

# Points to Consider 
### Assuming the directory containing all projects, along with other directories and files, is located at C:\Users\<username>\Desktop\OpenGL, proceed as follows.
- You need to set the **Include Directories** and **Library Directories** to **the includes folder** and **lib folder** respectively, located in **the directory containing the root directories of the projects**.
  - In **Project Properties → Configuration Properties → VC++ Directories**
    - Include Directories: Enter **"C:\Users\<user_name>\Desktop\OpenGL\includes"**
    - Library Directories: Enter **"C:\Users\<user_name>\Desktop\OpenGL\lib"**
- Additionally, you need to add **glfw3.lib; opengl32.lib; assimp-vc143-mtd.lib;**.
  - In **Project Properties → Configuration Properties → Linker → Input → Additional Dependencies**
- From the Models section onward, the **assimp-vc143-mtd.dll** file (dynamic library) must be copied to the directory **where the application is located** before running it. Note that the Model and Mesh classes are consistently used starting from **project 15**, so keep this in mind. And then starting from project 15, you need to set **the Output Directory**.
  - In **Project Properties → Configuration Properties → General → Output Directory** to **the directory where the corresponding .cpp file is located**
    - Output Directory: Enter **"C:\Users\<user_name>\Desktop\OpenGL\<project_name>\<project_name>"**, if you didn't check the option **"Place solution and project in the same directory"** when creating a new project. (In my case, I configured it this way.)
- The **glad.c** file must also be added to the **'Source Files' section** of the project.
