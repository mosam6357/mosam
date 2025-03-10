a = int(input())
total = 0
for i in range(a):
    s = input()
    n = int(s[:-1])
    p = int(s[-1])
    total+= n**p
print(total)