a,b = map(int,input().split())
cnt1 = 0 #고정 인상 급여
cnt2 = 0 #두 배 급여
for i in range(a):
    c = int(input())
    if b>c:
        cnt1+=1
    elif b<c:
        cnt2+=1
if cnt1==cnt2:
    print(0)
elif cnt1>cnt2:
    print(1)
else:
    print(2)