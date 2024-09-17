a,b,c=map(int,input().split()); sum1=0
d,e,f=map(int,input().split()); sum2=0
sum1=a*3+b*20+c*120
sum2=d*3+e*20+f*120
if(sum1==sum2):
    print('Draw')
elif(sum1>sum2):
    print('Max')
else:
    print('Mel')