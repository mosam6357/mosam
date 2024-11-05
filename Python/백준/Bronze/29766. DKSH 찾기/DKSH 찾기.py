a=input()
cnt=0
for i in range(len(a)-3):
    s=a[i]+a[i+1]+a[i+2]+a[i+3]
    if(s=='DKSH'):
        cnt+=1
print(cnt)