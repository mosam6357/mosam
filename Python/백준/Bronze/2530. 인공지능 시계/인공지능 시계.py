a,b,c = map(int,input().split())
s=int(input())
if(c+s>59):
    b+=(c+s)//60
    c=(c+s)%60
    if(b>59):
        a+=b//60
        b=b%60
        if(a>23):
            a=a%24
else:
    c+=s
print(f'{a} {b} {c}')