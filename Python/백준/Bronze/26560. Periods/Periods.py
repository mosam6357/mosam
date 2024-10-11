a=int(input())
for i in range(a):
    b=input()
    if(b[len(b)-1]!='.'):
        print(b+'.')
    else:
        print(b)