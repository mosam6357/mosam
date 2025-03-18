a = int(input())
for i in range(5):
    if i!=4:
        for j in range(a):
            print('@'*a)
    else:
        for j in range(a):
            print('@'*(a*5))