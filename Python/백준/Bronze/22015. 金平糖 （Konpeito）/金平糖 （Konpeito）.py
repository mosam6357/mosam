aa=list(map(int,input().split()))
cnt=0
for i in range(3):
    cnt+=max(aa)-aa[i]
print(cnt)