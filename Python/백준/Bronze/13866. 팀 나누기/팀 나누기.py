aa = list(map(int,input().split()))
a = 2*max(aa)+2*min(aa)-sum(aa)
if(a<0):
    a*=-1
print(a)