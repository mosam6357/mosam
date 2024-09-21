aa=["Never gonna give you up","Never gonna let you down","Never gonna run around and desert you","Never gonna make you cry","Never gonna say goodbye","Never gonna tell a lie and hurt you","Never gonna stop"]
a=int(input()); ck=0
for i in range(a):
    b=input()
    if b not in aa:
        ck=1;
        break
if(ck==1):
    print('Yes')
else:
    print('No')