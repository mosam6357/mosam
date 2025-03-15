import math

a,b,c,d = map(int,input().split())
print(math.ceil(a/(c+1))*math.ceil(b/(d+1)))