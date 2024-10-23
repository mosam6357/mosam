q=input()
a=int(q)
l=len(q)
ck=1
for i in range(int(10**(l-2)),a):
    ans = i
    s=str(i)
    for j in range(len(s)):
        ans+=int(s[j])
    if(ans==a):
        print(i)
        ck=0
        break
if(ck==1):
    print(0)