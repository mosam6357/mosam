a=int(input())
b=list(map(int,input().split()))
y=0; m=0
for i in range(a):
    y+=((b[i]//30)+1)*10
    m+=((b[i]//60)+1)*15
if(y==m):
    print(f"Y M {y}")
elif(y<m):
    print(f"Y {y}")
else:
    print(f"M {m}")