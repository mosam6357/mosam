n,a,b = map(int,input().split())
cnt1 = 0; cnt2 = 0; cnt3 = 0 #각각 피즈,버즈,피즈버즈
for i in range(1,n+1):
    if i%a==0 and i%b==0:
        cnt3+=1
    elif i%a==0:
        cnt1+=1
    elif i%b==0:
        cnt2+=1
print(cnt1,cnt2,cnt3)