q,w,e = map(int,input().split())
a,s,d = map(int,input().split())
if(q==a and w==s and e==d):
    print('A')
elif(w==s and e==d):
    if(a>=(q+1)//2):
        print('B')
    else:
        print('C')
else:
    if(s>=(w+1)//2):
        print('D')
    else:
        print('E')