def check(q):
    cnt = 0
    for i in range(len(q)):
        if q[i]==' ':
            cnt+=1
        else:
            break
    return cnt

while(True):
    a=int(input())
    if(a==0):
        break
    for i in range(a):
        if(i==0):
            b=input()
            cnt = check(b)
            c=b.split()
            d = cnt+len(c[0])+1
        else:
            e=input()
            if(len(e)<=d):
                pass
            for i in range(d-1,len(e)):
                if e[i]==' ':
                    break
                else:
                    d+=1
    print(d)