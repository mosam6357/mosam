a=int(input()); aa=[]; cost=0
for i in range(a):
    aa.append(int(input()))
b=int(input())
for i in range(b):
    cost+=aa[int(input())-1]
print(cost)