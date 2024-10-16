aa = list(map(int,input().split()))
c = int(input())
for i in range(c):
    d = int(input())
    if(d>1000):
        print(f'{d} {1000*min(aa)+(d-1000)*max(aa)}')
    else:
        print(f'{d} {d*min(aa)}')