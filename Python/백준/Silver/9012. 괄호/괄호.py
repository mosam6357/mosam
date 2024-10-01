a=int(input())
for i in range(a):
    b=input(); ck=0
    if(b[0]==')' or b[len(b)-1]=='('):
        ck=1
    else:
        for i in range(1,len(b)-1):
            if(b[i]==')'):
                if(b[:i].count('(') == b[:i].count(')')):
                    ck=1
                    break
        if(b.count('(')!=b.count(')')):
            ck=1
    if(ck==0):
        print("YES")
    else:
        print("NO")