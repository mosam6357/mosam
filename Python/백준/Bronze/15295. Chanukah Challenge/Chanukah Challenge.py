a = int(input())
for i in range(a):
    b,c = map(int,input().split())
    print(f"{b} {(c*(c+1))//2+c}")