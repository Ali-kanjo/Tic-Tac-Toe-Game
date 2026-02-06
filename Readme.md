
# ❌ Tic-Tac-Toe Game (WinForms) ⭕

A sleek, interactive, and highly organized **Tic-Tac-Toe** game built using **C#** and **Windows Forms**. This project demonstrates strong software engineering principles, focusing on code readability, maintainability, and a modern UI experience.


---

## 🚀 Key Features

* **Dynamic Visual Feedback:** Modern dark-themed UI with red glow effects and smooth color transitions.
* **Intelligent Game Logic:** Automatically detects wins, losses, and draws.
* **Interactive Cells:** Winning cells are highlighted in `GreenYellow`, with hover effects (White on hover) for a polished feel.
* **State Management:** Clear tracking of current player turn and game progress (In Progress, Player 1 Won, Player 2 Won, or Draw).
* **Error Handling:** Built-in validation to prevent overwriting used cells or playing after the game is over.

---

## 🛠️ Software Engineering & Code Quality

This project was developed with a "Maintenance-First" mindset, utilizing several architectural best practices:

### 1. Separation of Concerns (Divide and Conquer)

The code is split into small, focused private methods. Each method performs a single task:

* `CheckIfWinner()`: Dedicated purely to logical verification of the board.
* `RestartGame()`: Resets data structures and UI states independently.
* `MakePicturesBoxOriginalState()`: Manages visual resetting only.

### 2. Clean & Readable Code

* **Enum Usage:** Instead of using confusing integers or strings, the game uses `enCurrentPlayer` and `enWinner` enums to make the logic self-documenting.
* **Structured Data:** Used a `struct` called `stGameResults` to group all relevant game metadata (Winner, GameOver status, PlayCount) into a single, logical entity.

### 3. Maintainability & Scalability

* The use of a `List<PictureBox> winningsCells` allows for easy extensions, such as adding animations or different highlight styles without breaking the core logic.
* Centralized UI updates through methods like `PreparingInitialSituation()` ensure that changes to the game's starting state only need to be made in one place.

### 4. Event-Driven Architecture

Efficiently handles user interactions through specialized events:

* `MouseDown`: Processes the game move.
* `MouseEnter / MouseLeave`: Manages dynamic styling for winning cells.
* `Paint`: Custom GDI+ drawing for the game grid lines.

---

## 📋 Technical Specifications

* **Language:** C#
* **Framework:** .NET (Windows Forms)
* **Design Pattern:** Logical separation within the Partial Class.
* **UI Components:** Custom PictureBoxes, GDI+ Graphics, and WinForms Controls.

---

## 🎮 How to Play

1. **Player 1** starts as **X**.
2. Click on any cell marked with a **"?"**.
3. The game switches turns automatically to **Player 2 (O)**.
4. The first to get 3 in a row (horizontal, vertical, or diagonal) wins!
5. Click **Restart Game** to play again at any time.

---

### 👨‍💻 Developed with passion for Clean Code.

