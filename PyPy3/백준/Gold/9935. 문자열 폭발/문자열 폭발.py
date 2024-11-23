import sys

input = sys.stdin.read
a, b = input().splitlines()
b_length = len(b)

stack = []
for char in a:
    stack.append(char)
    if len(stack) >= b_length and ''.join(stack[-b_length:]) == b:
        del stack[-b_length:]

result = ''.join(stack)
if result:
    sys.stdout.write(result)
else:
    sys.stdout.write("FRULA")