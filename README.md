# ChatbotLLMApp

A professional, asynchronous .NET 8 Windows Forms chatbot application integrated with Large Language Models (LLMs). This project is designed with strict adherence to Object-Oriented Programming (OOP) principles and clean architecture design patterns.

## 🏗️ Architecture & Software Design

The codebase enforces **Separation of Concerns (SoC)** and **Loose Coupling** by avoiding spaghetti code and organizing functionalities into distinct layers:

- **`Interfaces/` (Abstraction)**: Defines the system contracts (`IChatService`, `IHistoryService`). The entire UI interacts solely with abstractions, allowing seamless provider hot-swapping without modifying visual components.
- **`Models/` (Data Structures)**: Contains lightweight Data Transfer Objects (DTOs) like `ChatMessage`. Utilizes **Encapsulation** principles (e.g., `private set` on timestamps) to guarantee data immutability.
- **`Services/` (Business Logic)**: Implements concrete operations. Features a production-ready `OpenAIChatService` using asynchronous task routing, alongside a `MockChatService` utilized for testing decoupled environments.
- **`UI/` (Presentation)**: An event-driven interface implementing manual **Dependency Injection (DI)** through form constructors at the application's composition root (`Program.cs`).

## 🚀 Key Features

- **Asynchronous Processing**: Non-blocking UI operations utilizing C# `async/await` patterns during remote API handshakes.
- **Polymorphic Architecture**: Swap between mock testing engines and live production models with a single-line structural change.
- **Robust Exception Handling**: Gracefully intercepts network anomalies and API failures without disrupting application state lifecycle.
- **In-Memory Session Lifespans**: Encapsulated collection structures preserving secure, read-only session histories.

## 🛠️ Tech Stack & Prerequisites

- **Framework**: .NET 8.0 (Long-Term Support)
- **Language**: C# 12
- **UI Platform**: Windows Forms (.NET)
- **SDK Wrapper**: Betalgo.OpenAI

## 🔧 Installation & Setup

1. Clone the repository:
   ```bash
   git clone [https://github.com/YOUR_USERNAME/ChatbotLLMApp.git](https://github.com/YOUR_USERNAME/ChatbotLLMApp.git)
   `
2. Set up your environment variable for production:

```Bash
# On Windows (CMD)
setx OPENAI_API_KEY "your-actual-api-key"
```
3. Open ChatbotLLMApp.sln in Visual Studio, restore NuGet packages, and press F5 to run.
