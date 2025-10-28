# ♟️ PotterChess

A complete **chess game built in C# and WPF**, featuring a custom-built chess engine (`ChessLogic`) and a modern graphical interface (`ChessUI1`).  
PotterChess supports all standard chess rules, including **castling**, **en passant**, **pawn promotion**, and **checkmate detection**.  


## 🧠 Overview

PotterChess is a standalone Windows application that recreates a full chess-playing experience.  
The project is divided into two layers:
- **`ChessLogic`** — core game engine (rules, moves, validation, state tracking).  
- **`ChessUI1`** — WPF-based user interface with styled menus, piece rendering, and mouse-based interactions.  


## 🚀 Features  

### ♞ Gameplay  
- Full implementation of chess rules:
  - ✅ Normal moves, **Castling**, **En Passant**, **Pawn Promotion**  
  - ✅ Check, Checkmate, Stalemate, Draw conditions  
  - ✅ 50-move rule, threefold repetition, insufficient material detection  
- Board updates in real-time  
- Turn-based system for White and Black  
- Dynamic highlighting for possible moves  
- Automatic end-game detection and restart options  

### 🖥️ User Interface (WPF)  
- Clean, dark-themed layout built with **custom styles and brushes**  
- Interactive menus:
  - ⏸️ Pause menu  
  - 🏁 Game over screen  
  - 👑 Promotion menu  
- Custom cursors for each player (white/black)  
- Smoothly scaled, high-quality chess pieces  
- Hand-crafted visual assets (PNGs and ICOs in `Assets/`)  

### ⚙️ Engine  
- Modular, extensible `ChessLogic` library with:
  - Abstract `Move` and `Piece` base classes  
  - Per-piece movement logic (`King`, `Queen`, `Bishop`, etc.)  
  - Legal move validation and deep copy checks for simulated outcomes  
  - Board evaluation for special draw conditions  
- Easily embeddable in other .NET applications


## 🧩 Project Structure  

```
PotterChess/
│
├── ChessLogic/
│   ├── Board.cs
│   ├── Counting.cs
│   ├── Direction.cs
│   ├── EndReason.cs
│   ├── GameState.cs
│   ├── MoveType.cs
│   ├── Player.cs
│   ├── PieceType.cs
│   ├── Position.cs
│   ├── Result.cs
│   ├── StateString.cs
│   │
│   ├── Moves/
|   │   ├── Move.cs
│   │   ├── NormalMove.cs
│   │   ├── Castle.cs
│   │   ├── DoublePawn.cs
│   │   ├── EnPassant.cs
│   │   └── PawnPromotion.cs
│   │
│   ├── Pieces/
│       ├── Bishop.cs
│       ├── King.cs
│       ├── Knight.cs
│       ├── Pawn.cs
|       ├── Piece.cs
│       ├── Queen.cs
│       └── Rook.cs
│
├── ChessUI1/
│   ├── App.xaml/
│   |   └── App.xaml.cs
│   ├── AssemblyInfo.cs
│   ├── ChessCursors.cs
│   ├── Images.cs
│   ├── Option.cs
│   ├── MainWindow.xaml/
│   |   └── MainWindow.xaml.cs
│   │
│   ├── GameOverMenu.xaml/
│   |   └── GameOverMenu.xaml.cs
│   ├── PauseMenu.xaml/
│   |   └── PauseMenu.xaml.cs
│   ├── PromotionMenu.xaml/
│   |   └── PromotionMenu.xaml.cs
│   │
│   └── Assets/
│       ├── Board.png
│       ├── CursorW.cur
│       ├── CursorB.cur
│       ├── *.png (pieces)
│       └── icon.ico
│
└── PotterChess.sln
```


## ⚙️ Technologies Used  

| Category | Technology |
|-----------|-------------|
| **Language** | C# (.NET 8 / .NET Core) |
| **Framework** | WPF (Windows Presentation Foundation) |
| **Architecture** | MVC-inspired separation (`ChessLogic` + `ChessUI1`) |
| **Rendering** | XAML + high-quality PNG sprites |
| **Data Structures** | Object-oriented model of pieces, moves, and board |
| **IDE** | Visual Studio / Rider |


## 🧠 How It Works  

1. **Game Initialization**  
   - The board is created via `Board.Initial()`.  
   - A `GameState` object manages turn order and move legality.

2. **User Interaction**  
   - Players click squares on the WPF board.  
   - Possible moves are highlighted via overlay rectangles.

3. **Move Validation**  
   - `GameState` filters legal moves through simulation (check prevention).  
   - Special moves (promotion, en passant, castling) handled by dedicated classes.

4. **Game Progression**  
   - Each move updates the board and toggles the active player.  
   - When no legal moves remain, `Result` determines the outcome.

5. **Menus & State Control**  
   - Menus communicate via event-based `Option` enums.  
   - Pause and Game Over states handled inside `MainWindow`.


## 🧰 Setup Instructions  

### 1. Clone the repository
```bash
git clone https://github.com/kanstantsin-malinouski/ChessGame.git
cd PotterChess
```
### 2. Run the Project
```bash
dotnet run
```


## 🧾 License  

This project is released for **educational and non-commercial use**.

## 🌟 Author  

**Kanstantsin Malinouski**  
🔗 [GitHub Profile](https://github.com/kanstantsin-malinouski)  
