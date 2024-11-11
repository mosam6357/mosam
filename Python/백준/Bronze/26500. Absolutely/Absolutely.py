a=int(input())
for i in range(a):
    aa = list(map(float,input().split()))
    print(round(max(aa)-min(aa),1))