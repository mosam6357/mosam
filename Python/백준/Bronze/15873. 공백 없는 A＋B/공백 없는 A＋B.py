a=input()
if(len(a)==2):
    print(int(a[0])+int(a[1]))
elif(len(a)==3):
    if(a[0:2]=='10'):
        print(10+int(a[2]))
    elif(a[1:3]=='10'):
        print(10+int(a[0]))
else:
    print(20)