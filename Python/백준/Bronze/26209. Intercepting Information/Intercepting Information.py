a = list(map(int,input().split())) ; check='S'
for i in range(8):
    if(a[i]==9):
        check='F'
        break
print(check)