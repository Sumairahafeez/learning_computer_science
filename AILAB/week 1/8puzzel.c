#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

#define N 3
#define MAX_MOVES 100

int goal[3][3] = { {1, 2, 3}, {4, 5, 6}, {7, 8, 0} }; // Goal state

typedef struct {
    int board[3][3];
    int x, y; // Empty space position
    int cost; // Number of moves so far
    int level; // Depth of the node
} State;

// Directions for moving the blank tile
int row[] = {-1, 1, 0, 0};
int col[] = {0, 0, -1, 1};

// Function to print the board
void printBoard(int board[3][3]) {
    for (int i = 0; i < N; i++) {
        for (int j = 0; j < N; j++) {
            printf("%d ", board[i][j]);
        }
        printf("\n");
    }
}

// Check if the state is the goal state
bool isGoal(State* state) {
    for (int i = 0; i < N; i++) {
        for (int j = 0; j < N; j++) {
            if (state->board[i][j] != goal[i][j]) {
                return false;
            }
        }
    }
    return true;
}

// Function to check if a position is valid for movement
bool isSafe(int x, int y) {
    return (x >= 0 && x < N && y >= 0 && y < N);
}

// Swap two tiles in the board
void swap(int* x, int* y) {
    int temp = *x;
    *x = *y;
    *y = temp;
}

// Function to perform the BFS
void solvePuzzle(State start) {
    State queue[MAX_MOVES];
    int front = -1, rear = -1;

    queue[++rear] = start;
    
    while (front != rear) {
        State curr = queue[++front];

        // Check if we have reached the goal state
        if (isGoal(&curr)) {
            printf("Goal state reached!\n");
            printBoard(curr.board);
            return;
        }

        // Explore all possible moves
        for (int i = 0; i < 4; i++) {
            int newX = curr.x + row[i];
            int newY = curr.y + col[i];

            // Check if the new position is valid
            if (isSafe(newX, newY)) {
                // Make a new state
                State next = curr;
                next.x = newX;
                next.y = newY;
                next.board[curr.x][curr.y] = curr.board[newX][newY];
                next.board[newX][newY] = 0;

                // Enqueue the new state
                queue[++rear] = next;
            }
        }
    }

    printf("Solution does not exist.\n");
}

int main() {
    State start;
    start.board[0][0] = 1;
    start.board[0][1] = 2;
    start.board[0][2] = 3;
    start.board[1][0] = 4;
    start.board[1][1] = 0;
    start.board[1][2] = 5;
    start.board[2][0] = 7;
    start.board[2][1] = 8;
    start.board[2][2] = 6;

    start.x = 1;
    start.y = 1;
    start.cost = 0;
    start.level = 0;

    printf("Initial State:\n");
    printBoard(start.board);

    solvePuzzle(start);
    return 0;
}
