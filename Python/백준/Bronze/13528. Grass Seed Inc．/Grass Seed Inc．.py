a = float(input())
b = int(input())
e = 0
for i in range(b):
    c,d = map(float,input().split())
    e+=c*d
print(e*a)