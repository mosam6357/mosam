while(True):
    aa = input().split()
    a = int(aa[0]); b = int(aa[2]); s = aa[1]
    if a==0 and b==0 and s=='W':
        break
    if s=='W':
        a-=b
        if (a<-200):
            print('Not allowed')
        else:
            print(a)
    else:
        a+=b
        print(a)