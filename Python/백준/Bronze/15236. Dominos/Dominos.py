a = int(input())
total = 0
for i in range(1,a+1):
    total+=i*(i+1)+(i*(i+1))//2
print(total)