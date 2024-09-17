a=input(); b=int(a); cnt=0; chk=0; 
for i in a:
    if i=='7':
        cnt=1
        break
if b%7==0:
    chk=1
if(cnt+chk==0):
    print(0)
elif(cnt+chk==2):
    print(3)
elif(cnt==1 and chk==0):
    print(2)
else:
    print(1)