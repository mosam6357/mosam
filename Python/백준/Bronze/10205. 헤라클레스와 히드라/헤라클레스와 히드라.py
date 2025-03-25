a = int(input())
for i in range(a):
    b = int(input())
    s = input()
    for j in s:
        if j=='b':
            b-=1
        else:
            b+=1
    print(f'Data Set {i+1}:\n{b}\n')