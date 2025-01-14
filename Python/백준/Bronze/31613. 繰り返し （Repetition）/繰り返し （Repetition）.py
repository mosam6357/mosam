a = int(input())
b = int(input())
cnt = 0
while(a<b):
    if a%3==0:
        a+=1
    elif a%3==1:
        a*=2
    else:
        a*=3
    cnt+=1
print(cnt)