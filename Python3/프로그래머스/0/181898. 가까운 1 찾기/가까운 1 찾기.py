def solution(arr, idx):
    while(arr.count(1)!=0):
        n = arr.index(1)
        if n>=idx:
            return n
        else:
            arr[n] = 0
    return -1