a = int(input())
aa = list(map(int,input().split()))
e = 0 #빈 강의실에서 수업할 때
m = 0 #강의를 놓쳤을 때
p = 0 #이전 주의 강의 수
for i in range(a):
    if i!=0:
        if (p>aa[i]):
            e += p-aa[i]
        else: 
            m += aa[i]-p
    p = aa[i]
print(e,m)