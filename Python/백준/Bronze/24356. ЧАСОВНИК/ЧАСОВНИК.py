h1,m1,h2,m2=map(int,input().split())
start = h1*60+m1
end = h2*60+m2
time = end - start
if(time<0):
    time+=1440
print(time,time//30)