a,b = map(int,input().split()) #가격,무게
c,d = map(int,input().split())
e,f = map(int,input().split())
a*=10; c*=10; e*=10
if a>=5000:
    a-=500
if c>=5000:
    c-=500
if e>=5000:
    e-=500
aa = [b/a,d/c,f/e]
bb = ['S','N','U']
print(bb[aa.index(max(aa))])