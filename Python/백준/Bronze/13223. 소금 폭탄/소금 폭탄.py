a,b,c = map(int,input().split(":"))
d,e,f = map(int,input().split(":"))
h1 = a*3600+b*60+c
h2 = d*3600+e*60+f
t = h2-h1
if (t<=0):
    t+=86400
h = t//3600
m = (t%3600)//60
s = t%60
print(f"{format(h,'02')}:{format(m,'02')}:{format(s,'02')}")