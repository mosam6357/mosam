a,b,c = map(int,input().split(" : "))
d,e,f = map(int,input().split(" : "))
t1 = a*3600+b*60+c
t2 = d*3600+e*60+f
t = t2-t1
if(t<0):
    t+=86400
print(t)