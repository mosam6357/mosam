q=int(input())
cost = 0
for i in range(q):
    a,b = map(int,input().split())
    if(a==136):
        cost+=1000
    elif(a==142):
        cost+=5000
    elif(a==148):
        cost+=10000
    else:
        cost+=50000
print(cost)