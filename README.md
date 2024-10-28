# WASM Environment Selector
Easily Configure Environment Selection in a WASM Static App

This project demonstrates how to configure environment selection in a Blazor WebAssembly (WASM) static application. It includes an intuitive UI for changing environments, and the app dynamically adjusts visual elements based on the selected environment.

## Features

- **Environment Switching**: Quickly switch between Development, Staging, and Production environments.
- **Visual Indicators**: Color-coded UI to help you identify the current environment at a glance.
- **Local Storage**: Selected environment settings persist across sessions using local storage.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) installed
- A compatible code editor, such as [Visual Studio Code](https://code.visualstudio.com/)

### Installation

1. Clone the repository:

   ```bash
   git clone git@github.com:ndsantos/wasm-env-selector.git
   cd wasm-env-selector
   ```

2. Build and tun the project
    ```bash
   dotnet run
   ```

3. Open your browser and navigate to:
    ```
    http://localhost:5263/config
    ```

## Usage

1. **Select an Environment**: On the configuration page, choose from Development, Staging, or Production.
2. **Visual Feedback**: The app’s color scheme updates immediately to reflect the selected environment:
   - **Green** for Development
   - **Red** for Staging
   - **Default** for Production

## Additional Information

For further details on the implementation, see our [blog post](https://medium.com/@n.d.santos/configuring-environment-selection-in-a-wasm-static-app-2cc8fbddf4a4) for code examples and an explanation of the environment handling strategy in WASM static applications.