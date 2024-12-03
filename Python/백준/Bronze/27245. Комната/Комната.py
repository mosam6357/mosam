aa = []
for i in range(2):
    aa.append(int(input()))
a = int(input())
if(min(aa)>=a*2 and max(aa)<=2*min(aa)):
    print('good')
else:
    print('bad')