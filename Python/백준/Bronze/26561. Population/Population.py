a=int(input())
for i in range(a):
    b,c=map(int,input().split()); sum=b
    b+=c//4
    b-=c//7
    print(b)