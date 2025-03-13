t = int(input())
p1 = [1,2,3,3,4,10]
p2 = [1,2,2,2,3,5,10]
for x in range(t):
    aa = list(map(int,input().split()))
    bb = list(map(int,input().split()))
    n1 = 0
    n2 = 0
    for i in range(len(aa)):
        n1+=aa[i]*p1[i]
    for i in range(len(bb)):
        n2+=bb[i]*p2[i]
    print(f"Battle {x+1}: ",end="")
    if n1>n2:
        print('Good triumphs over Evil')
    elif n1<n2:
        print('Evil eradicates all trace of Good')
    else:
        print('No victor on this battle field')