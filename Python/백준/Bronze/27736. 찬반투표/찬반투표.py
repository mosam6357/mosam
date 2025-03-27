a = int(input())
aa = list(map(int,input().split()))
if aa.count(0)>a/2:
    print('INVALID')
elif sum(aa)>0:
    print('APPROVED')
else:
    print('REJECTED')