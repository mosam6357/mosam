aa = [0 for i in range(100)]
cost = int(input())
n = int(input())
for i in range(n):
    s = input().split()
    a = int(s[0]); b = s[1]
    if (b=='L'):
        a-=2
        while(a!=-1):
            aa[a]+=1
            a-=1
    else:
        while(a!=100):
            aa[a]+=1
            a+=1
for i in range(100):
    aa[i]=aa[i]%3
print(f"{aa.count(0)*0.01*cost:.2f}")
print(f"{aa.count(1)*0.01*cost:.2f}")
print(f"{aa.count(2)*0.01*cost:.2f}")