limit = int(input())
n = int(input())
used = 0
for i in range(n):
    used += int(input())
print((n+1)*limit-used)