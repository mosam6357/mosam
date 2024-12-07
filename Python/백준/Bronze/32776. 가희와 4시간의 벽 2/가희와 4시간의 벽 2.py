s=int(input())
aa = map(int,input().split())
if(sum(aa)<s and s>240):
    print('flight')
else:
    print('high speed rail')