a = int(input())
for i in range(a):
    n = int(input())
    total = 0
    for j in range(1,n+1):
        total+=j*j
    print(total)