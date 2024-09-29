q=int(input())
for i in range(q):
    a,b,c = map(int,input().split())
    f = c%a
    if(f==0):
        f=a
    h = (c-1)//a+1
    if(h<10):
        print(f"{f}0{h}")
    else:
        print(f"{f}{h}")