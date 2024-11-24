n=int(input())
aa = [1,0,1,0,1] #SK win -> 1 / CY win -> 0
for i in range(5,n+1):
    if(aa[i-1]==1 and aa[i-3]==1 and aa[i-4]==1):
        aa.append(0)
    else:
        aa.append(1)
if(aa[n]==1):
    print('SK')
else:
    print('CY')