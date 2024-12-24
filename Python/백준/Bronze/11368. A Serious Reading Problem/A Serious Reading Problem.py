while(True):
    a,b,c,d = map(int,input().split())
    if a==b and b==c and c==d and a==0:
        break
    print(((a**b)**c)**d)