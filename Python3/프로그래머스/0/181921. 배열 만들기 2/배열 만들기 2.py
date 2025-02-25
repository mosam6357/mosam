def solution(l, r):
    answer = []
    for i in range(l,r+1):
        a = str(i)
        if a.count('0')+a.count('5')==len(a):
            answer.append(i)
    if len(answer)==0:
        return [-1]
    return answer