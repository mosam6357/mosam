def score(l):
    return l[0]*13+l[1]*7+l[2]*5+(l[3]+l[4])*3+l[5]*2

a = list(map(int,input().split()))
b = list(map(int,input().split()))
s1 = score(a)
s2 = score(b)+1.5
if(s1>s2):
    print('cocjr0208')
else:
    print('ekwoo')