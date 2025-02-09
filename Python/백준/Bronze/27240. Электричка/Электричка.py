n,a,b = map(int,input().split())
s,e= map(int,input().split())
if a+1<=s<=b-1 and a+1<=e<=b-1:
    print('City')
elif (s<=a and e<=a) or (s>=b and e>=b):
    print('Outside')
else:
    print('Full')