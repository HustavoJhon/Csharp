<div align="center">

# C sharp

<span>
Este repositorio documenta mi aprendizaje en programación con C# y .NET. Incluye proyectos, recursos, y ejemplos prácticos, desde los fundamentos hasta la creación de APIs REST con .NET 8
<span>

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)

---

![Visual Studio Code](https://img.shields.io/badge/Visual%20Studio%20Code-0078d7.svg?style=for-the-badge&logo=visual-studio-code&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)
![Geany](https://img.shields.io/badge/Geany-FFA500.svg?style=for-the-badge&logo=geany&logoColor=black)

[![YouTube](https://img.shields.io/badge/YouTube-%23FF0000.svg?style=for-the-badge&logo=YouTube&logoColor=white)](https://youtube.com/playlist?list=PL0bfr51v6JJEvSoAnCNYHM9b-75JQSoad&si=UoUExWHMjem6l9AK)
[![Microsoft Learn](https://img.shields.io/badge/Microsoft_Learn-258ffa?style=for-the-badge&logo=microsoft&logoColor=white)](https://learn.microsoft.com/es-mx/dotnet/csharp/)
[![Google Drive](https://img.shields.io/badge/Google%20Drive-4285F4?style=for-the-badge&logo=googledrive&logoColor=white)](https://drive.google.com/drive/folders/1TkyWBSrCXgh270gM50cHswZut5G7WTEG?usp=sharing)
[![Freecodecamp](https://img.shields.io/badge/Google%20Drive-0A0A23?style=for-the-badge&logo=freecodecamp&logoColor=white)](https://www.freecodecamp.org/espanol/learn/foundational-c-sharp-with-microsoft/)

</div>

### Run

<details>
<summary> New Project </summary>

```bash
dotnet new console --name .

dotnet build

dotnet run
```

</details>

<details>
<summary> Clone Project </summary>

```bash
dotnet restore

dotnet build

dotnet run
```

</details>

<details>
<summary> Ignore `.cs` files when compiling </summary>

Los archivos `.cs` ubicados en la carpeta ignored están excluidos del proceso de compilación. Esto se logra mediante la configuración en el archivo `.csproj`:

```xml
<ItemGroup>
  <Compile Remove="ignoredDirectory\**\*.cs" />
</ItemGroup>
```
</details>

#### 📃 Documentation

1. [Microsoft](https://learn.microsoft.com/dotnet/csharp)

#### 📚 Book

1. [Fundamentals of Computer Programming With C#](https://ivanpop.azurewebsites.net/Resources/CSResources/Fundamentals-of-Computer-Programming-with-CSharp-EN.pdf)
2. [Comenzando con el lenguaje C#](https://manual-informatica.com/download-file.html)
3. [My Google Drive](https://drive.google.com/drive/folders/1TkyWBSrCXgh270gM50cHswZut5G7WTEG?usp=sharing)


#### 🔨 IDE

1. [Visual Studio](https://visualstudio.microsoft.com/)
2. [Geany - The Flyweaght IDE](https://www.geany.org/)
3. [Visual Stuido Code](https://code.visualstudio.com/)

    - **Extensions**

        - [Codeium](https://codeium.com/vscode_tutorial)
        - [Better Comments](https://marketplace.visualstudio.com/items?itemName=aaron-bond.better-comments)

