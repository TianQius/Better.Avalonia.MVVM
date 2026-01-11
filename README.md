# Better.Avalonia.MVVM

A personal Avalonia MVVM project template.

This template is based on the official `avalonia.mvvm` template,  
but uses a **DI-first startup structure** that I personally prefer for real projects.

---

## Why this template exists

When using the official **Avalonia .NET MVVM App** template, I often need to rewrite `App.axaml.cs` immediately:

- Replace `new MainViewModel()` with DI
- Add a `ServiceCollection`
- Centralize View / ViewModel registration
- Use a custom `ViewLocator`

This template simply **starts with that structure already in place**.

---

## Main differences from the official template

### Official `avalonia.mvvm`
- Creates `MainWindow` directly
- Assigns `DataContext` using `new ViewModel()`
- Very simple and beginner-friendly

### Better.Avalonia.MVVM
- Uses `Microsoft.Extensions.DependencyInjection`
- Central `ConfigureViews` and `ConfigureServices`
- Views and ViewModels are created via DI
- Includes a simple `ViewLocator`
- Handles both Desktop and SingleView lifetimes

Nothing fancy — just a cleaner starting point (for me).

---

## What this template is / is not

**This template is:**
- A small personal template
- Opinionated, but minimal
- Easy to extend for real applications

**This template is not:**
- A beginner tutorial
- A full-featured starter kit
- An official replacement for Avalonia templates

---

## Usage
Download this project and ues dotnet to install（you can change it）:
```bash
dotnet new install Better.Avalonia.MVVM.Templates
