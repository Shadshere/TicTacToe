# ?? Advanced Tic-Tac-Toe Game

A modern, feature-rich tic-tac-toe game built with C# and Windows Forms (.NET 8).

Watch here on Youtube how it works : https://youtu.be/3d9T6mwMXOk 

![Game Screenshot](https://img.shields.io/badge/Platform-Windows-blue)
![.NET Version](https://img.shields.io/badge/.NET-8.0-purple)
![License](https://img.shields.io/badge/License-MIT-green)

## ? Features

- **Classic 3x3 tic-tac-toe gameplay** - Traditional rules with modern UI
- **Two-player mode** - Play as X and O with friends
- **Game Statistics** - Track wins, draws, and total games played
- **Game Timer** - See how long each game takes
- **Sound Effects** - Audio feedback for moves and wins
- **Visual Feedback** - Winning combinations are highlighted
- **Reset & New Game** - Easy game management
- **Professional UI** - Clean, modern Windows Forms interface

## ?? How to Play

1. **Launch the game** - Run the executable file
2. **Take turns** - Players alternate clicking empty squares
3. **Player X goes first** - X and O alternate turns
4. **Win condition** - Get three in a row (horizontally, vertically, or diagonally)
5. **Draw condition** - If all squares are filled with no winner
6. **Game resets** - Automatically starts new round after each game

## ??? System Requirements

### Framework-Dependent Version (Recommended)
- **OS**: Windows 10 or later
- **Runtime**: .NET 8.0 Runtime ([Download here](https://dotnet.microsoft.com/download/dotnet/8.0))
- **Size**: ~1-2 MB

### Self-Contained Version
- **OS**: Windows 10 or later  
- **Runtime**: Not required (included)
- **Size**: ~100+ MB

## ?? Installation & Running

### Option 1: Download Release (Easiest)
1. Go to [Releases](../../releases) page
2. Download the latest version
3. Extract the ZIP file
4. Run `tictactoe game.exe`

### Option 2: Build from Source
```bash
# Clone the repository
git clone https://github.com/YOUR_USERNAME/TicTacToe.git
cd TicTacToe

# Build the project
dotnet build

# Run the game
dotnet run --project "tictactoe game"
```

## ??? Development

### Prerequisites
- Visual Studio 2022 or later
- .NET 8.0 SDK
- Windows Forms workload

### Building
```bash
# Restore dependencies
dotnet restore

# Build in Release mode
dotnet build -c Release

# Publish framework-dependent
dotnet publish -c Release -o ./publish/framework-dependent

# Publish self-contained for Windows
dotnet publish -c Release -o ./publish/self-contained --self-contained true -r win-x64
```

## ?? Screenshots

### Main Game Interface
- Clean, modern UI with game board
- Real-time statistics display
- Current player indicator
- Game timer
- Control buttons

### Game Features
- **Winner Highlight**: Winning combinations are highlighted in green
- **Statistics Tracking**: Persistent win/draw counters
- **Sound Effects**: Click and win sound feedback
- **Visual Feedback**: Color-coded X (blue) and O (red) pieces

## ?? Game Controls

| Action | Method |
|--------|--------|
| Make Move | Click on empty square |
| Reset Game | Click "?? Reset" button |
| New Game | Click "?? New Game" button |
| View Stats | Displayed on right side |

## ?? Technical Details

- **Language**: C# 12.0
- **Framework**: .NET 8.0 (Windows)
- **UI Framework**: Windows Forms
- **Architecture**: Single-form application
- **Sound**: System sounds via System.Media
- **Timer**: Windows Forms Timer component

## ?? Project Structure

```
TicTacToe/
??? tictactoe game/
?   ??? Form1.cs              # Main game logic
?   ??? Form1.Designer.cs     # UI design
?   ??? Program.cs            # Entry point
?   ??? tictactoe game.csproj # Project file
??? README.md                 # This file
??? LICENSE                   # MIT License
??? .gitignore               # Git ignore rules
```

## ?? Contributing

Contributions are welcome! Here's how you can help:

1. **Fork** the repository
2. **Create** a feature branch (`git checkout -b feature/AmazingFeature`)
3. **Commit** your changes (`git commit -m 'Add some AmazingFeature'`)
4. **Push** to the branch (`git push origin feature/AmazingFeature`)
5. **Open** a Pull Request

### Ideas for Contributions
- Add AI opponent with different difficulty levels
- Implement different board sizes (4x4, 5x5)
- Add themes and customization options
- Create multiplayer over network
- Add game replay functionality
- Implement tournament mode

## ?? License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## ?? Troubleshooting

**Game won't start?**
- Ensure .NET 8.0 Runtime is installed
- Check Windows compatibility (Windows 10+)

**Security warning?**
- Click "More info" ? "Run anyway" (unsigned application)

**No sound?**
- Check system volume and sound settings
- Game will continue working without sound

## ?? Version History

- **v2.0.0** - Enhanced version with timer, statistics, and sound effects
- **v1.0.0** - Basic tic-tac-toe functionality

## ?? Acknowledgments

- Built with .NET 8.0 and Windows Forms
- Sound effects using System.Media
- UI design inspired by modern game interfaces

---

**Enjoy playing Tic-Tac-Toe!** ??

*If you like this project, please consider giving it a ? on GitHub!*
