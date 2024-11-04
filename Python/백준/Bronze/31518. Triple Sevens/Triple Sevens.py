a=int(input())
triple = 0
for i in range(3):
    aa = list(map(int,input().split()))
    if 7 not in aa:
        print(0)
        break
    if i==2:
        print(777)