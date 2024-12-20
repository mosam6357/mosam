aa = input().strip()
cnt = 0
ck=0
for i in range(len(aa)-1,-1,-1):
    if aa[i]!='0' and ck==0:
        ck = 1
    if ck==1 and aa[i]=='0':
        cnt +=1
print(cnt)