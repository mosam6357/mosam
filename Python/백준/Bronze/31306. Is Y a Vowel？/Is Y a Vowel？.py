a=input()
cnt1=0
for i in a:
    if(i=='a' or i=='e' or i=='i' or i=='o' or i=='u'):
        cnt1+=1
cnt2=a.count('y')
print(cnt1,cnt1+cnt2)