import math

i=1
while(True):
    a = int(input())
    n = a/2*1.5/1860000
    if(a==0):
        break
    print(f'File #{i}')
    print(f'John needs {math.ceil(n)} floppies.')
    print()
    i+=1