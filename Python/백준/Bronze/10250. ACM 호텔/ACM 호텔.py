q=int(input())
for i in range(q):
    a,b,c = map(int,input().split()); f=0; j=1 
    for i in range(c):
        if(f==a):
            j+=1
            f=1
        else:
            f+=1
    if(j<10):
        print(f"{f}0{j}")
    else:
        print(f"{f}{j}")