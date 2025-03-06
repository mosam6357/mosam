a = int(input())
total = 0
for i in range(a):
    b,c = map(int,input().split())
    total+=c%b
print(c%b)