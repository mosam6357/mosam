a = list(input().split())
for i in range(len(a)):
    if 'd2' in a[i] or 'D2' in a[i]:
        print('D2')
        break
    if i==len(a)-1:
        print('unrated')