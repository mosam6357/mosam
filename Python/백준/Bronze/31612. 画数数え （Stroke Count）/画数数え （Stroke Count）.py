a=int(input()); b=input(); cnt=0
for i in range(a):
    if(b[i]=='o'):
        cnt+=1
    else:
        cnt+=2
print(cnt)