WiseJ 3.5 Hybrid를 사용하여 Windows, Android, IOS 동시에 개발하기

<p>프로그램을 실행 하면 다음과 같은 화면을 볼 수 있습니다.

![poster](./img1.png)

금번예제는 devtunnel 를 설치하고 안드로이드 에뮬레이터와 웹서버를 연결해야 합니다.


PS를 사용하여 아래의 명령을 수행 합니다. 

PS>> winget install Microsoft.devtunnel

devtunnel 사용

devtunnel user login -g  // 로그인하기 

devtunnel host -p 5000 --allow-anonymous // devtunnel 실행   


PS E:\0 romee\0 src\1education\wisej\wisej-hybrid-examples-main\RemoteWebApi> devtunnel host -p 5000 --allow-anonymous

Hosting port: 5000

Connect via browser: https://406cplzz.asse.devtunnels.ms:5000, https://406cplzz-5000.asse.devtunnels.ms

Inspect network activity: https://406cplzz-5000-inspect.asse.devtunnels.ms

Ready to accept connections for tunnel: fun-book-w7cfrxs.asse

코드수정 

![poster](./img2.png)

실행하면 서버와 에뮬레이트가 연결된것을 확인 할 수 있음 

![poster](./img3.png)

호스트에서 시험을 위해 devtunnel 확인을 위한 처음 접속시 나오는 화면 

![poster](./img4.png)

이후 나오는 화면 
![poster](./img5.png)


devtunnel에 대해 자세한 사용법 참조 : https://changsroad.tistory.com/575

License
-------
<img src="http://iceteagroup.com/wp-content/uploads/2017/01/Square-64x64-trasp.png" height="20" align="top"> Copyright (C) ICE TEA GROUP LLC, All rights reserved.

