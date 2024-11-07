n,a,b = map(int,input().split())
if(n>=1000 and (a>=8000 or b>=260)):
    print('Very Good')
elif(n>=1000):
    print('Good')
else:
    print('Bad')