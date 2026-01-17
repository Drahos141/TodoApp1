# Quick Start Guide

## To Run the Todo App:

### Option 1: Using the batch file (Windows)
Double-click `run.bat` or run it from command prompt:
```
run.bat
```

### Option 2: Using dotnet command
```
dotnet run
```

## After Running:

1. **Wait for startup messages** - You'll see output like:
   ```
   Now listening on: https://localhost:5001
   Now listening on: http://localhost:5000
   ```

2. **Open your browser** (Chrome, Edge, Firefox, etc.)

3. **Navigate to one of these URLs:**
   - `http://localhost:5000` 
   - `https://localhost:5001`

4. **If you see a security warning** (for HTTPS), click "Advanced" and then "Continue" or "Proceed"

5. **You should see the Todo App UI!**

## Troubleshooting:

- **Nothing shows in browser?** 
  - Make sure you're using the EXACT URL from the console (including http:// or https://)
  - Try both ports (5000 and 5001)
  - Press F12 in browser and check Console tab for errors

- **App won't start?**
  - Make sure no other instance is running (close other terminals)
  - Try: `dotnet clean` then `dotnet run`

- **Still having issues?**
  - Check that .NET 8 SDK is installed: `dotnet --version`
  - Make sure you're in the project directory
