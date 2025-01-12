a = int(input())
t = int(input())
case= int(input())
d = {'0':0,'1':0}
p = -1
n = 2
while(True):
    s = '0101'+'0'*n+'1'*n
    for i in range(len(s)):
        d[s[i]]+=1
        p+=1
        if (p==a):
            p=0
        if(d[str(case)]==t):
            break
    if(d[str(case)]==t):
        break
    n+=1
print(p)