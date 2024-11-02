a=int(input())
b=input()
for i in range(a):
    if(b[i]=='?'):
        if(b[::-1][i]=='?'):
            print('a',end="")
        else:
            print(b[::-1][i],end="")
    else:
        print(b[i],end="")