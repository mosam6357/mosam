t = int(input())
for i in range(t):
    a = int(input())
    total = 0
    for j in range(1,a+2):
        total+=j*(j-1)*(j+1)//2
    print(total)