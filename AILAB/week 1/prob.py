import tkinter as tk
from random import shuffle


class EightPuzzle:
    def __init__(self, root):
        self.root = root
        self.root.title("8-Puzzle Game")
        self.root.geometry("400x450")
        self.root.configure(bg="#f0f8ff")  # Light blue background
        self.tiles = list(range(1, 9)) + [0]  # Numbers 1-8 + blank (0)
        shuffle(self.tiles)
        while not self.is_solvable():
            shuffle(self.tiles)  # Ensure the puzzle is solvable

        self.create_header()
        self.create_board()

    def create_header(self):
        # Add a title header at the top
        header = tk.Label(
            self.root,
            text="8-Puzzle Game",
            font=("Arial", 24, "bold"),
            bg="#f0f8ff",
            fg="#4682b4",  # Steel blue color
        )
        header.pack(pady=10)

    def create_board(self):
        # Create the 3x3 puzzle board
        self.board_frame = tk.Frame(self.root, bg="#f0f8ff")
        self.board_frame.pack(pady=20)
        self.buttons = []
        for i in range(3):
            row = []
            for j in range(3):
                num = self.tiles[i * 3 + j]
                btn = tk.Button(
                    self.board_frame,
                    text=str(num) if num != 0 else "",
                    font=("Arial", 18, "bold"),
                    width=5,
                    height=2,
                    bg="#add8e6",  # Light blue button color
                    fg="#00008b",  # Dark blue text
                    relief="groove",
                    bd=2,
                    command=lambda x=i, y=j: self.move_tile(x, y),
                )
                btn.grid(row=i, column=j, padx=5, pady=5)
                row.append(btn)
            self.buttons.append(row)

    def move_tile(self, x, y):
        # Find the blank (0)
        blank_x, blank_y = self.find_blank()
        # Check if the clicked tile is adjacent to the blank
        if abs(blank_x - x) + abs(blank_y - y) == 1:
            # Swap tiles
            self.tiles[blank_x * 3 + blank_y], self.tiles[x * 3 + y] = (
                self.tiles[x * 3 + y],
                self.tiles[blank_x * 3 + blank_y],
            )
            # Update the GUI
            self.update_board()
            # Check if the puzzle is solved
            if self.is_solved():
                self.show_winning_message()

    def find_blank(self):
        blank_index = self.tiles.index(0)
        return divmod(blank_index, 3)

    def update_board(self):
        for i in range(3):
            for j in range(3):
                num = self.tiles[i * 3 + j]
                self.buttons[i][j].config(text=str(num) if num != 0 else "")

    def is_solvable(self):
        # Check if the puzzle is solvable
        inversions = 0
        for i in range(len(self.tiles)):
            for j in range(i + 1, len(self.tiles)):
                if self.tiles[i] > self.tiles[j] != 0:
                    inversions += 1
        return inversions % 2 == 0

    def is_solved(self):
        # Check if the tiles are in order
        return self.tiles == list(range(1, 9)) + [0]

    def show_winning_message(self):
        # Display a message when the puzzle is solved
        for row in self.buttons:
            for btn in row:
                btn.config(state="disabled", bg="#90ee90")  # Light green when solved
        win_label = tk.Label(
            self.root,
            text="🎉 Congratulations! You solved it! 🎉",
            font=("Arial", 16, "bold"),
            fg="green",
            bg="#f0f8ff",
        )
        win_label.pack(pady=10)


# Run the application
if __name__ == "__main__":
    root = tk.Tk()
    game = EightPuzzle(root)
    root.mainloop()
