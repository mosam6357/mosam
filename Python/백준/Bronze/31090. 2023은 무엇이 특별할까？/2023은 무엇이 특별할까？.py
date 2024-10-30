a=int(input())
for i in range(a):
    b = int(input())
    c = b%100
    if((b+1)%c==0):
        print('Good')
    else:
        print('Bye')