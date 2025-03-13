a,b,c = map(int,input().split())
s1 = ''
s2 = ''
if(a+b==c or a-b==c or a*b==c or a//b==c):
    s2 = '='
    if a+b==c:
        s1 = '+'
    elif a-b==c:
        s1 = '-'
    elif a*b==c:
        s1 = '*'
    elif a//b==c:
        s1 = '/'
else:
    s1 = '='
    if a==b+c:
        s2 = '+'
    elif a==b-c:
        s2 = '-'
    elif a==b*c:
        s2 = '*'
    elif a==b//c:
        s2 = '/'
print(f"{a}{s1}{b}{s2}{c}")