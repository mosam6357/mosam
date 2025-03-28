a = int(input())
b = int(input())
n = a
for i in range(b):
    n*=10
    a+=n
print(a)