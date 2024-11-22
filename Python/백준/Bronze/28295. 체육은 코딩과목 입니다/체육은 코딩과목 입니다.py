d = 0 #북동남서 = d%4
for i in range(10):
    a = int(input()) #지시 종류
    if(a==1): #우향우
        d+=1
    elif(a==2): #뒤로 돌아
        d+=2
    else: #좌향좌
        d+=3
ans = d%4
if(ans==0):
    print('N')
elif(ans==1):
    print('E')
elif(ans==2):
    print('S')
else:
    print('W')