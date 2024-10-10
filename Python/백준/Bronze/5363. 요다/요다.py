a=int(input())
for i in range(a):
    aa = input().split()
    b=aa[0]; c=aa[1]
    del aa[0]
    del aa[0]
    print(*aa,b,c)