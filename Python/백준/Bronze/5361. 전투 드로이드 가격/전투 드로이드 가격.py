n = int(input())
cost = [350.34,230.90,190.55,125.30,180.90]
for i in range(n):
    aa = list(map(int,input().split()))
    total = 0
    for i in range(len(aa)):
        total+=aa[i]*cost[i]
    print(f"${total:.2f}")