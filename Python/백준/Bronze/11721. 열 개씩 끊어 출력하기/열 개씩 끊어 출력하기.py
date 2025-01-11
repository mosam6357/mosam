a = input()
r = len(a)//10
if len(a)%10!=0:
    r+=1
for i in range(r):
    for j in range(10):
        try:
            print(a[10*i+j],end="")
        except:
            break
    print("")
    