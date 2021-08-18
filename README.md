# CameraProject
<br>상위 프로그래머로 가는 길은 수학의 문제풀이 과정과 같다.<br> 확률과 통계,로그, 편미분, 적분, 삼각함수라는 도구를 통해 수학 문제를 풀듯이 해결해야 하는 것이다.
<br>(그리고 실제로도 저 분야를 해 나가면 코딩을 해야 하는 양이 줄어들 뿐더러 어떠한 산업현장에서 프로그래밍을 하더라도 쉽게 다가갈 수 있다.)<br>
중요한 것은 수식이 아니라 알고 있는 정보를 총 동원해서 현실 세계의 객체를 프로세스화 하는 것이다.<br>
상위 정보를 알기 위해서는 유수한 해외 학자들의 논문을 읽어야 하기에 영어를 공부하는 것이다.<br>
구현은 이전 프로그래머들이 잘 해놓았으니 나는 그것들을 잘 활용할 줄 아는 이치를 깨닳아야 한다.<br>
퇴근하고 나서 수능수학 이과 파트를 필히 단계별로 공부해야 프로그래밍할 수 있다. 그 이전에는 단순한 노무 작업을 하게 된다.<br>
몸값이 높아지고 대우를 잘 받으려면 내가 소스를 직접 짜고 라이브러리까지 구현해야 하는 것이다.<br>

<img src="https://github.com/ochestra365/-CameraProject/blob/bugFix/%EA%B9%83%ED%97%88%EB%B8%8C%EC%97%90%20%EC%98%AC%EB%A6%B4%20%EC%9D%B4%EB%AF%B8%EC%A7%80/HoneyWellCam.png" width="100%" height="100%" ><br><br>
모듈식 장치<br><br>
<br><br>
LG사무실로 들어가기 전 사장님께서 테스트용으로 과제물을 내주셨다. 해당 카메라를 던져주고 나에게 가동시켜 보라고 하셨다. 그리고 추가 기능을 덧붙일 건데, 이건 이강산 과장님의 지시를 받으라고 하셨다.<br><br>
LQC상에서 화성의 통신기기들과 각종 검사기기들을 다루기 때문에 이강산과장님이 멀티쓰레드를 잘 사용하는 것이 기본이라고 하셨다.<br><br>
<img src="https://github.com/ochestra365/-CameraProject/blob/bugFix/%EA%B9%83%ED%97%88%EB%B8%8C%EC%97%90%20%EC%98%AC%EB%A6%B4%20%EC%9D%B4%EB%AF%B8%EC%A7%80/%ED%99%94%EB%A9%B4%EA%B5%AC%EB%8F%99.png"><br><br>
화면이 잘 구동된다.<br><br>


--------------

## 목차 <br>
1. 진행상황
2. 개념

------------------



## 1. 진행상황
----------------
경로파일의 파일명을 바꾸려고 노력중이다.<br><br>
<img src="https://github.com/ochestra365/-CameraProject/blob/bugFix/%EA%B9%83%ED%97%88%EB%B8%8C%EC%97%90%20%EC%98%AC%EB%A6%B4%20%EC%9D%B4%EB%AF%B8%EC%A7%80/%EA%B2%BD%EB%A1%9C%20%ED%8C%8C%EC%9D%BC%20%EC%A0%80%EC%9E%A5.png"><br><br>파일이 생성되기 전의 모습이다.<br><br>
<img src="https://github.com/ochestra365/-CameraProject/blob/bugFix/%EA%B9%83%ED%97%88%EB%B8%8C%EC%97%90%20%EC%98%AC%EB%A6%B4%20%EC%9D%B4%EB%AF%B8%EC%A7%80/%EA%B2%BD%EB%A1%9C%20%ED%8C%8C%EC%9D%BC%20%EC%A0%80%EC%9E%A52.png"><br><br>파일이 저장되었다.<br><br>
<img src="https://github.com/ochestra365/-CameraProject/blob/bugFix/%EA%B9%83%ED%97%88%EB%B8%8C%EC%97%90%20%EC%98%AC%EB%A6%B4%20%EC%9D%B4%EB%AF%B8%EC%A7%80/%EA%B2%BD%EB%A1%9C%20%ED%8C%8C%EC%9D%BC%20%EC%A0%80%EC%9E%A53.png"><br><br>잘 저장된 것을 확인할 수 있다.<br><br>
<img src="https://github.com/ochestra365/-CameraProject/blob/bugFix/%EA%B9%83%ED%97%88%EB%B8%8C%EC%97%90%20%EC%98%AC%EB%A6%B4%20%EC%9D%B4%EB%AF%B8%EC%A7%80/RFID.png"><br><br>
지금은 RFID를 Setting과 Get과 병행중이다.<br><br>
## 2. 학습사항 정리
----------------

## 5. 오류 디버깅함과정 정리
----------------
~~~

~~~
디버그 과정
-----------
-----------
메모리 문제를 해결해야 했다.<br><br>
<img src="https://github.com/ochestra365/-CameraProject/blob/bugFix/%EA%B9%83%ED%97%88%EB%B8%8C%EC%97%90%20%EC%98%AC%EB%A6%B4%20%EC%9D%B4%EB%AF%B8%EC%A7%80/%EB%A9%94%EB%AA%A8%EB%A6%AC%20%EB%AC%B8%EC%A0%9C.png"  ><br>
비트맵을 누적시키다 보니 메모리 누수가 발생했다. 가비지 콜렉터로 일단 처리함.<br><br>
스레드를 써서 front의 누적 데이터를 지우는 것이 고급 기술임.<br><br>

<img src="https://github.com/ochestra365/-CameraProject/blob/bugFix/%EA%B9%83%ED%97%88%EB%B8%8C%EC%97%90%20%EC%98%AC%EB%A6%B4%20%EC%9D%B4%EB%AF%B8%EC%A7%80/%EB%A9%94%EB%AA%A8%EB%A6%AC%20%EB%AC%B8%EC%A0%9C2.png" ><br>
메모리 누수가 발생한 것을 확인가능했다.<br>

<img src="https://github.com/ochestra365/-CameraProject/blob/bugFix/%EA%B9%83%ED%97%88%EB%B8%8C%EC%97%90%20%EC%98%AC%EB%A6%B4%20%EC%9D%B4%EB%AF%B8%EC%A7%80/%EB%A9%94%EB%AA%A8%EB%A6%AC%EB%AC%B8%EC%A0%9C3.png" width="40%" height="30%" ><br>
프로세스 메모리가 가득 찼으니 매개변수가 전달될 메인 스레드의 작동이 중단되었다.<br><br>
구글링으로 정보를 찾았다. 비지 콜렉터를 해당 스레드가 돌아가는 라인상에 삽입하니 해결되었다.






