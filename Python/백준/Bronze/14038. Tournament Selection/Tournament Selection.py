cnt = 0
for i in range(6):
    if(input()=='W'):
        cnt+=1
if(cnt==0):
    print(-1)
else:
    print((8-cnt)//2)