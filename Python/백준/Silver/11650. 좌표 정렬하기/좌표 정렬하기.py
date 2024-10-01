a=int(input()); aa=[]
for i in range(a):
    b,c = map(int,input().split())
    aa.append([b,c])
aa.sort(key = lambda x:(x[0],x[1]))
for i in range(a):
    print(*aa[i])