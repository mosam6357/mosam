a = int(input())
for i in range(a):
    b,c = input().split('-')
    s1 = 0
    s2 = int(c)
    for j in range(3):
        s1+=(ord(b[j])-65)*(26**(2-j))
    if abs(s1-s2)<=100:
        print('nice')
    else:
        print('not nice')