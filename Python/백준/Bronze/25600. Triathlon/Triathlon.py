q = int(input())
aa=[]
for i in range(q):
    a,b,c = map(int,input().split())
    score=a*(b+c)
    if(a==b+c):
        score*=2
    aa.append(score)
print(max(aa))