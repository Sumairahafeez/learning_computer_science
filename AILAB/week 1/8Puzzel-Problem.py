import heapq
import copy

def is_solvable(puzzle):
    """Check if the puzzle is solvable by counting inversions."""
    flat_list = [num for row in puzzle for num in row if num != 0]
    inversions = 0
    for i in range(len(flat_list)):
        for j in range(i + 1, len(flat_list)):
            if flat_list[i] > flat_list[j]:
                inversions += 1
    return inversions % 2 == 0

def find_blank_position(puzzle):
    """Find the position of the blank (zero) in the puzzle."""
    for i, row in enumerate(puzzle):
        for j, val in enumerate(row):
            if val == 0:
                return (i, j)

def generate_neighbors(state):
    """Generate all possible neighbor states by moving the blank tile."""
    puzzle, (x, y) = state
    moves = [(-1, 0), (1, 0), (0, -1), (0, 1)]  # Up, Down, Left, Right
    neighbors = []

    for dx, dy in moves:
        nx, ny = x + dx, y + dy
        if 0 <= nx < 3 and 0 <= ny < 3:
            new_puzzle = copy.deepcopy(puzzle)
            new_puzzle[x][y], new_puzzle[nx][ny] = new_puzzle[nx][ny], new_puzzle[x][y]
            neighbors.append((new_puzzle, (nx, ny)))

    return neighbors

def calculate_manhattan_distance(puzzle, goal):
    """Calculate the Manhattan distance heuristic."""
    distance = 0
    for i in range(3):
        for j in range(3):
            if puzzle[i][j] != 0:
                x, y = divmod(goal.index(puzzle[i][j]), 3)
                distance += abs(i - x) + abs(j - y)
    return distance

def solve_8_puzzle(start, goal):
    """Solve the 8-puzzle problem using the A* algorithm."""
    if not is_solvable(start):
        return "This puzzle is not solvable."

    goal_flat = [num for row in goal for num in row]
    start_flat = [num for row in start for num in row]
    goal_index = {val: i for i, val in enumerate(goal_flat)}

    initial_state = (start, find_blank_position(start))
    frontier = []
    heapq.heappush(frontier, (0, initial_state))

    came_from = {}
    cost_so_far = {tuple(start_flat): 0}

    while frontier:
        _, current = heapq.heappop(frontier)
        current_puzzle, _ = current
        current_flat = tuple([num for row in current_puzzle for num in row])

        if current_flat == tuple(goal_flat):
            path = []
            while current:
                path.append(current[0])
                current = came_from.get(tuple([num for row in current[0] for num in row]))
            return path[::-1]

        for neighbor in generate_neighbors(current):
            neighbor_puzzle, _ = neighbor
            neighbor_flat = tuple([num for row in neighbor_puzzle for num in row])

            new_cost = cost_so_far[current_flat] + 1
            if neighbor_flat not in cost_so_far or new_cost < cost_so_far[neighbor_flat]:
                cost_so_far[neighbor_flat] = new_cost
                priority = new_cost + calculate_manhattan_distance(neighbor_puzzle, goal_flat)
                heapq.heappush(frontier, (priority, neighbor))
                came_from[neighbor_flat] = current

    return "No solution found."

# Example usage
start_state = [
    [1, 3, 6],
    [4, 5, 2],
    [7, 0, 8]
]

goal_state = [
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 0]
]

solution = solve_8_puzzle(start_state, goal_state)
if isinstance(solution, str):
    print(solution)
else:
    for step, state in enumerate(solution):
        print(f"Step {step}:")
        for row in state:
            print(row)
        print()
