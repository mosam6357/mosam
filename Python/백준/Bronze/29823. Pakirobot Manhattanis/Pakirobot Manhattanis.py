a=int(input()); up=0; rt=0
b=input()
for i in range(a):
    if(b[i]=='W'):
        rt-=1
    elif(b[i]=='E'):
        rt+=1
    elif(b[i]=='N'):
        up+=1
    else:
        up-=1
print(abs(up)+abs(rt))