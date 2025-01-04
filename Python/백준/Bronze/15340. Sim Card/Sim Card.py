while(True):
    a,b = map(int,input().split())
    if a==b and a==0:
        break
    aa = []
    aa.append(a*30+b*40)
    aa.append(a*35+b*30)
    aa.append(a*40+b*20)
    print(min(aa))