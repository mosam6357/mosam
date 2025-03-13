a,b,c = map(int,input().split(":"))
d,e,f = map(int,input().split(":"))
h1 = a*3600+b*60+c
h2 = d*3600+e*60+f
time = h2-h1
if time<=0:
    time+=86400
h = time//3600
m = (time%3600)//60
s = time%60
if h<10:
    h='0'+str(h)
if m<10:
    m='0'+str(m)
if s<10:
    s='0'+str(s)
print(f"{h}:{m}:{s}")