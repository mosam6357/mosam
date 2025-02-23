def solution(arr, queries):
    answer = []
    for i in queries:
        m = []
        for j in range(i[0],i[1]+1):
            if(arr[j]>i[2]):
                m.append(arr[j])
        if (len(m)==0):
            answer.append(-1)
        else:
            answer.append(min(m))
    return answer