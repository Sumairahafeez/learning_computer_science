# Function to perform counting sort based on a specific digit
def counting_sort(arr, exp):
    n = len(arr)
    output = [0] * n  # Output array to store sorted values
    count = [0] * 10  # Count array to store the count of digits (0-9)

    # Count occurrences of each digit in the given digit's place (exp)
    for i in range(n):
        index = (arr[i] // exp) % 10
        count[index] += 1

    # Update count array to have the actual positions
    for i in range(1, 10):
        count[i] += count[i - 1]

    # Build the output array by placing the elements in the correct order
    i = n - 1
    while i >= 0:
        index = (arr[i] // exp) % 10
        output[count[index] - 1] = arr[i]
        count[index] -= 1
        i -= 1

    # Copy the sorted elements back into the original array
    for i in range(n):
        arr[i] = output[i]

# Radix Sort function
def radix_sort(arr):
    # Find the maximum number to figure out the number of digits
    max_num = max(arr)

    # Perform counting sort for every digit (from least significant to most)
    exp = 1
    while max_num // exp > 0:
        counting_sort(arr, exp)
        exp *= 10

# Example usage
arr = [170, 45, 75, 90, 802, 24, 2, 66]
print("Original array:", arr)
radix_sort(arr)
print("Sorted array:", arr)
