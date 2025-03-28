a = int(input())
n = 1
for i in range(1,a):
    if i>a-4:
        n*=i
n//=6
print(n)