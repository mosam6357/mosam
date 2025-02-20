def solution(num_list):
    n1 = 0; n2 = 0
    for i in range(len(num_list)):
        if i%2==0:
            n2+=num_list[i]
        else:
            n1+=num_list[i]
    return max(n1,n2)