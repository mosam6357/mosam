a=int(input())
for i in range(a):
    aa = list(map(int,input().split()))
    if(sum(aa)-aa[0]>=55 and aa[1]>=35*0.3 and aa[2]>=25*0.3 and aa[3]>=40*0.3):
        print(aa[0],sum(aa)-aa[0],'PASS')
    else:
        print(aa[0],sum(aa)-aa[0],'FAIL')