aa = input().split()
a = int(aa[0])
if(aa[1][0]=='m'):
    print(0)
elif(aa[1][0]=='b'):
    print(a*200)
elif(aa[1][0]=='c'):
    print(a*400)
elif(aa[1][0]=='g'):
    print(a*600)
else:
    print(a*1000)