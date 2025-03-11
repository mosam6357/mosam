while(True):
    a,b,c,d = map(int,input().split())
    if a==b and b==c and c==d and d==0:
        break
    t = c*60+d-(a*60+b)
    if t<0:
        t+=1440
    print(t)