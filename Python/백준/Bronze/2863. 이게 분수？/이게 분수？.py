a,b = map(int,input().split())
c,d = map(int,input().split())
aa = [a/c+b/d,c/d+a/b,d/b+c/a,b/a+d/c]
print(aa.index(max(aa)))