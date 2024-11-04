aa = list(map(int,input().split()))
bb = list(map(int,input().split()))
cnt = 0
for i in range(3):
    if(aa[i]-bb[i]<0):
        cnt += bb[i]-aa[i]
print(cnt)