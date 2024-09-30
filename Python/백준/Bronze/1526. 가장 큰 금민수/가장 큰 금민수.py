a=int(input())
while(True):
    b=str(a)
    if(b.count('4')+b.count('7')==len(b)):
        print(b)
        break
    a-=1