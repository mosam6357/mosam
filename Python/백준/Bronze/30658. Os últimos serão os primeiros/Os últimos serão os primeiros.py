while(True):
    a = int(input())
    if(a==0):
        break
    aa=[]
    for i in range(a):
        aa.append(int(input()))
    aa.reverse()
    for i in range(a):
        print(aa[i])
    print(0)