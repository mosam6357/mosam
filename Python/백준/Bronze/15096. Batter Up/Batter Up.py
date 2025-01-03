a = int(input())
aa = list(map(int,input().split()))
score = 0
for i in aa:
    if i!=-1:
        score+=i
    else:
        a-=1
print(score/a)