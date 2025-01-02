a = int(input())
aa = list(map(int,input().split()))
bb = list(map(int,input().split()))
score = 0
for i in range(a):
    if aa[i]==bb[i]:
        score+=1
    elif aa[i]>bb[i]:
        score+=3
print(score)