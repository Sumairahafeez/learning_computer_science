# plc.py

# Function to check if a character is an operator
def is_operator(c):
    return c in ['+', '-', '*', '/', '(', ')']

# Function to get the precedence of an operator
def precedence(op):
    if op == '+' or op == '-':
        return 1
    if op == '*' or op == '/':
        return 2
    return 0

# Function to convert infix expression to postfix expression
def infix_to_postfix(expression):
    stack = []
    postfix = ''
    for char in expression:
        if not is_operator(char):
            postfix += char
        elif char == '(':
            stack.append(char)
        elif char == ')':
            while stack and stack[-1] != '(':
                postfix += stack.pop()
            stack.pop()
        else:
            while stack and precedence(stack[-1]) >= precedence(char):
                postfix += stack.pop()
            stack.append(char)
    while stack:
        postfix += stack.pop()
    return postfix

# Example usage
if __name__ == "__main__":
    infix_expression = input("Enter infix expression: ")
    postfix_expression = infix_to_postfix(infix_expression)
    print("Postfix expression:", postfix_expression)