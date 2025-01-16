a = int(input())
b = 0
c = 0 #정지 상태
for i in range(a):
    b = int(input())-b
    if c==0:
        c=1 #실행 상태
    else:
        c=0
if c==1:
    print('still running')
else:
    print(b)