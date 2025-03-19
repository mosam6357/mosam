a,b = map(int,input().split())
s = 1
t = 1
for i in range(a):
    c,d = map(int,input().split())
    if c!=d:
        s=0
for j in range(b):
    c,d = map(int,input().split())
    if c!=d:
        t=0
if s==0:
    print('Wrong Answer')
elif s==1 and t==0:
    print('Why Wrong!!!')
else:
    print('Accepted')