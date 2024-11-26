import math

a=int(input())
for i in range(a):
    b,c = map(int,input().split()) #조각면적,가격
    d,e = map(int,input().split()) #원형반지름,가격
    f = math.pi*d*d#원 면적
    if(b/c>f/e):
        print('Slice of pizza')
    else:
        print('Whole pizza')