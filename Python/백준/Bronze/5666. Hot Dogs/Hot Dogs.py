while(True):
    try:
        a,b = map(float,input().split())
        n = a/b
        print(f"{round(n,2):.2f}")
    except:
        break