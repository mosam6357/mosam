a,b = map(int,input().split())
save = 0
bullet = 0
for i in range(a):
    c = input()
    if c=='ammo':
        bullet+=b
        print(bullet)
    elif c=='save':
        save = bullet
        print(bullet)
    elif c=='shoot':
        bullet-=1
        print(bullet)
    else:
        bullet = save
        print(bullet)