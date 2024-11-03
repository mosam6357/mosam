q = int(input())
check = -1
fast = 1000
for i in range(q):
    a,b = map(int,input().split())
    if(a<=b):
        check=1
        if(b<fast):
            fast = b
if check==1:
    print(fast)
else:
    print(check)
    