t = int(input())
for i in range(t):
    aa = list(map(int,input().split()))
    aa.sort()
    a = aa[0]; b = aa[1]; c = aa[2]
    print(f'Scenario #{i+1}:')
    if (c**2==a**2+b**2):
        print('yes\n')
    else:
        print('no\n')