a = int(input())
total = 0
for i in range(a):
    total+=sum(list(map(int,input().split())))
print(total)