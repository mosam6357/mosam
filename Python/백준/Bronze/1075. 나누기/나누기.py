a=int(input())
b=int(input())
c=(a//100)*100
cnt=0
while(c%b!=0):
    cnt+=1
    c=(a//100)*100+cnt
if(cnt<10):
    print(f'0{cnt}')
else:
    print(cnt)
