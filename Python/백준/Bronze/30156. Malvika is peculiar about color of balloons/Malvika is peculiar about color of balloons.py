a=int(input())
for i in range(a):
    b = input()
    c1 = b.count('a')
    c2 = b.count('b')
    if(c1>c2):
        print(c2)
    else:
        print(c1)