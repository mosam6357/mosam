a=int(input())
aa=[]
for i in range(a):
    a,b = map(int,input().split())
    aa.append([a,b])
aa.sort(key = lambda x:x[1])
print(*aa[0])