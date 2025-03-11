a,b = map(int,input().split())
avg = 0
for i in range(b):
    avg+=int(input())
minavg = (avg-3*(a-b))/a
maxavg = (avg+3*(a-b))/a
print(minavg,maxavg)