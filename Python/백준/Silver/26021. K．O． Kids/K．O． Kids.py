a,b = map(int,input().split())
remove = 0
s = input()
p=1
for i in range(len(s)):
    if(s[i]=='L'):
        if(p==0):
            remove+=1
        p=0
    else:
        if(p==1):
            remove+=1
        p=1
if remove>b:
    print(0)
else:
    print(b-remove)