a = int(input())
b = list(map(int,input().split()))
h = 8*(a-1)
for i in b:
    h+=i
print(h//24,h%24)