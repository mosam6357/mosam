a = int(input())
for i in range(5):
    if i==0:
        for j in range(a):
            print('@'*(3*a),end="")
            print(' '*a,end="")
            print('@'*a)
    elif i==4:
        for j in range(a):
            print('@'*a,end="")
            print(' '*a,end="")
            print('@'*(3*a))
    else:
        for j in range(a):
            print('@'*a,end="")
            print(' '*a,end="")
            print('@'*a,end="")
            print(' '*a,end="")
            print('@'*a)