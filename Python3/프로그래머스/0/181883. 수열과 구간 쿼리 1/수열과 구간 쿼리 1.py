def solution(arr, queries):
    for i in range(len(arr)):
        for j in queries:
            if j[0]<=i and i<=j[1]:
                arr[i]+=1
    return arr