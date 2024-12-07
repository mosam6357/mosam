n = int(input())
a = int(input())
time = 210
for i in range(a):
    b,c = input().split()
    time-=int(b)
    if(time<=0):
        print(n)
        break
    if(c=='T'):
        n+=1
        if(n>8):
            n=1