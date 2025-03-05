aa = [list(map(int,input().split()))]
t = int(input())
for i in range(t):
    aa.append(list(map(int,input().split())))
cost = []
for i in aa:
    cost.append(i[0]/i[1]*1000)
print(f"{min(cost):.2f}")