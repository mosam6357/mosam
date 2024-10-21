h1,m1,h2,m2=map(int,input().split())
time = (h2-h1)*60+(m2-m1)
if(time<0):
    time+=1440
print(time,time//30)