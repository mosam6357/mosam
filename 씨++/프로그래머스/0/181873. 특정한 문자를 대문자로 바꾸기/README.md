# [level 0] 특정한 문자를 대문자로 바꾸기 - 181873 

[문제 링크](https://school.programmers.co.kr/learn/courses/30/lessons/181873?language=cpp) 

### 성능 요약

메모리: 4.13 MB, 시간: 0.01 ms

### 구분

코딩테스트 연습 > 코딩 기초 트레이닝

### 채점결과

정확성: 100.0<br/>합계: 100.0 / 100.0

### 제출 일자

2025년 03월 02일 11:52:49

### 문제 설명

<p>영소문자로 이루어진 문자열 <code>my_string</code>과 영소문자 1글자로 이루어진 문자열 <code>alp</code>가 매개변수로 주어질 때, <code>my_string</code>에서 <code>alp</code>에 해당하는 모든 글자를 대문자로 바꾼 문자열을 return 하는 solution 함수를 작성해 주세요.</p>

<hr>

<h5>제한사항</h5>

<ul>
<li>1 ≤ <code>my_string</code>의 길이 ≤ 1,000</li>
</ul>

<hr>

<h5>입출력 예</h5>
<table class="table">
        <thead><tr>
<th><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">나의_문자열</font></font></th>
<th><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">높은 산</font></font></th>
<th><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">결과</font></font></th>
</tr>
</thead>
        <tbody><tr>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">"프로그래머"</font></font></td>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">"피"</font></font></td>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">"프로그래머"</font></font></td>
</tr>
<tr>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">"소문자"</font></font></td>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">"엑스"</font></font></td>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">"소문자"</font></font></td>
</tr>
</tbody>
      </table>
<hr>

<h5>입출력 예 설명</h5>

<p>입출력 예 #1</p>

<ul>
<li>예제 1번의 <code>my_string</code>은 "programmers"이고 <code>alp</code>가 "p"이므로 <code>my_string</code>에 모든 p를 대문자인 P로 바꾼 문자열 "Programmers"를 return 합니다.</li>
</ul>

<p>입출력 예 #2</p>

<ul>
<li>예제 2번의 <code>alp</code>는 "x"이고 <code>my_string</code>에 x는 없습니다. 따라서 "lowercase"를 return 합니다.</li>
</ul>


> 출처: 프로그래머스 코딩 테스트 연습, https://school.programmers.co.kr/learn/challenges