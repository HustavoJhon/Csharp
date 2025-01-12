# **RPA con Selenium para Automatización de Portales Web**

Este proyecto utiliza **Selenium** con C# para automatizar la extracción de información de portales web, específicamente simulando acciones de usuario en el portal de la **SUNAT**.

![SCRAPY](https://img.shields.io/badge/Scrapy-60A839.svg?style=for-the-badge&logo=Scrapy&logoColor=white)
![SELENIUM](https://img.shields.io/badge/Selenium-43B02A.svg?style=for-the-badge&logo=Selenium&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4.svg?style=for-the-badge&logo=dotnet&logoColor=white)

<details>
<summary> Resources </summary>

[¿Qué es Web Scraping y cómo hacerlo con C# y .NET Core?](https://www.youtube.com/watch?v=HpoDd75t_-I)

[Automatización de pruebas utilizando Selenium desde C#](https://www.youtube.com/watch?v=8XbKIYCHO3k)

[Web Scraping en .NET con Selenium](https://www.youtube.com/watch?v=TpNDSyDnUwc)
</details>

## Ejercicios

<details>
<summary> HackerNewsTitleExtractor </summary>

```cs
dotnet --list-sdks

dotnet new console -n HackerNewsTitleExtractor --framework net8.0
cd HackerNewsTitleExtractor

dotnet new globaljson --skd-version 8.0.404

dotnet add package Selenium.WebDriver
dotnet add package Selenium.WebDriver.ChromeDriver

// problem solution
sudo apt-get install -y chromium-driver
```

</details>

## **Definición de Selenium**

**Selenium** es una herramienta de código abierto para la automatización de pruebas que simula la interacción de un usuario con un navegador web. Es ampliamente utilizado tanto para pruebas de software como para web scraping.  

**Componentes clave:**

1. **Selenium WebDriver**: Interactúa directamente con el navegador, permitiendo una automatización rápida y eficiente.
2. **Selenium IDE**: Extensión de navegador para grabar y reproducir pruebas.
3. **Selenium Grid**: Ejecuta pruebas en paralelo en múltiples navegadores y sistemas operativos.

---

## **Objetivo**

Automatizar la extracción de datos del portal SUNAT al portal SGE, simulando las acciones de un usuario para acceder, buscar notificaciones y extraer información relevante.  

- En el portal SUNAT:
  1. Acceder al portal de operaciones en línea (SOL).
  2. Navegar a **Mis trámites y consultas**.
  3. Extraer datos del **buzón electrónico**.
  4. Extraer información como:
   - Texto **"Buzón de notificaciones"**.
   - Datos como **"Buzón Mensajes (-1)"**.

---

## **Pasos para Usar Selenium en C#**

### **Requisitos previos**
1. Instalar el paquete NuGet: `Selenium.WebDriver`.
2. Descargar el WebDriver correspondiente al navegador que usarás (ej.: ChromeDriver).
