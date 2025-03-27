a = int(input())
for i in range(5):
    for j in range(a):
        if i==0 or i==4:
            print('@'*a,end="")
            print(' '*(3*a),end="")
            print('@'*a)
        elif i==1 or i==3:
            print('@'*a,end="")
            print(' '*(2*a),end="")
            print('@'*a)
        else:
            print('@'*(3*a))