a,b = map(int,input().split())
c,d = 100-a,100-b
e,f = 100-(c+d),c*d
g,h = f//100,f%100
print(c,d,e,f,g,h)
print(e+g,h)