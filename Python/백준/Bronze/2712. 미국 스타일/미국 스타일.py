t = int(input())
for i in range(t):
    aa = input().split()
    a = float(aa[0])
    b = aa[1]
    if b=='kg':
        print(f"{2.2046*a:.4f} lb")
    elif b=='lb':
        print(f"{0.4536*a:.4f} kg")
    elif b=='l':
        print(f"{0.2642*a:.4f} g")
    else:
        print(f"{3.7854*a:.4f} l")