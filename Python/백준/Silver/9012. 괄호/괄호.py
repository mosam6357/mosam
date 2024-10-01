a=int(input())
for i in range(a):
    b=input(); ck=0
    for j in range(len(b)):
        if(b[j]=='('):
            ck+=1
        else:
            ck-=1
            if(ck==-1):
                break
    if(ck==0):
        print("YES")
    else:
        print("NO")