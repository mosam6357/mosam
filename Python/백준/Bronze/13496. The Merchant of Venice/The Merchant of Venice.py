q=int(input())
for i in range(q):
    a,b,c = map(int,input().split())
    s=0
    for j in range(a):
        d,e = map(int,input().split())
        if(d/b<=c):
            s+=e
    print(f'Data Set {i+1}:\n{s}\n')