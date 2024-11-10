aa = list(map(int,input().split()))
if(max(aa)==min(aa)):
    print(sum(aa))
else:
    print(2*min(aa)+1)