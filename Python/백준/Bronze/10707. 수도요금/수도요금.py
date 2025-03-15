a=int(input())
b=int(input())
c=int(input())
d=int(input())
p=int(input())
c1 = a*p
c2 = b
if p>c:
    c2+=(p-c)*d
print(min([c1,c2]))