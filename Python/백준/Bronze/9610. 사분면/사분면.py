cnt = [0,0,0,0,0] #축+4분면에 있는 좌표 개수
a = int(input())
for i in range(a):
    aa = list(map(int,input().split()))
    if aa[0]==0 or aa[1]==0:
        cnt[0]+=1
    elif aa[0]>0 and aa[1]>0:
        cnt[1]+=1
    elif aa[0]<0 and aa[1]>0:
        cnt[2]+=1
    elif aa[0]<0 and aa[1]<0:
        cnt[3]+=1
    else:
        cnt[4]+=1
for i in range(4):
    print(f"Q{i+1}: {cnt[i+1]}")
print(f"AXIS: {cnt[0]}")