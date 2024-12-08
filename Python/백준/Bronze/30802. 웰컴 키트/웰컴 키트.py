a = int(input())
aa = list(map(int,input().split()))
b,c =map(int,input().split())
sumt = 0    #티셔츠 묶음의 수
sump = a//c    #펜 묶음의 수
for i in aa:
    sumt+=i//b
    if(i%b!=0):
        sumt+=1
p = a%c    #추가 주문하는 펜 수
print(sumt)
print(sump,p)