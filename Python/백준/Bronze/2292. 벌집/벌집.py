a=int(input())
cnt=1
e=1
while(a>e):
    e=6*((cnt)*(cnt+1)//2)+1
    cnt+=1
print(cnt)