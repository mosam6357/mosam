def check(num):
    cnt=0
    for i in range(1,num+1):
        if(num%i==0):
            cnt+=1
    return cnt

a = int(input())+1
ck=0
b=0
c=0
while(ck==0):
    for i in range(2,a):
        if(a%i==0):
            b=i
            c=a//i
            break
    if(b==c or b==a):
        pass
    cnt1 = check(b)
    cnt2 = check(c)
    if(cnt1==2 and cnt1==cnt2):
        for i in range(c-b):
            cnt3 = check(b+1+i)
            if(cnt3==2):
                if(b+1+i==c):
                    ck=1
                break
    if(ck==0):
        a+=1
print(a)