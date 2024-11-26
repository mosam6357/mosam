h,l,a,b = map(int,input().split())
aa=[a,b]
if(h*2>=l):
    if max(aa)/2>h or min(aa)>l:
        print('NO')
    else:
        print('YES')
else:
    if max(aa)>l or min(aa)/2>h:
        print('NO')
    else:
        print('YES')