t = int(input())
d31 = [1,3,5,7,8,10,12]
d30 = [4,6,9,11]
for i in range(t):
    a,b = map(int,input().split())
    if a<=23 and b<=59:
        print('Yes ',end="")
        if a<=12:
            if a in d31 and 0<b and b<=31:
                print('Yes')
            elif a in d30 and 0<b and b<=30:
                print('Yes')
            elif a==2 and 0<b and b<=29:
                print('Yes')
            else:
                print('No')
        else:
            print('No')
    else:
        print('No No')