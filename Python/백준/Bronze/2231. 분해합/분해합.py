q=input()
a=int(q)
l=len(q)
aa=[]
for i in range(int(10**(l-2)),a):
    ans = i
    s=str(i)
    for j in range(len(s)):
        ans+=int(s[j])
    if(ans==a):
        aa.append(i)
if(len(aa)==0):
    print(0)
else:
    print(min(aa))