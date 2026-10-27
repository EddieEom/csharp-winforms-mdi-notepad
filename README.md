# MDI 메모장 · WinForms 기초 실습

**폼·컨트롤·이벤트·파일 입출력을 공부하며 만든 작은 메모장입니다.**

C# · WinForms · MDI · 파일 입출력

<img src="https://raw.githubusercontent.com/EddieEom/EddieEom/main/assets/screenshots/mdi-notepad.jpg" alt="하나의 부모 창에서 여러 문서를 연 메모장" width="100%"/>


## 공부한 내용

| 내용 | 구현 |
| --- | --- |
| 부모·자식 폼 | 하나의 창 안에서 여러 문서 열기 |
| 메뉴 이벤트 | 현재 선택한 문서에 편집 명령 적용 |
| 파일 입출력 | 파일 열기·저장·다른 이름으로 저장 |
| 대화상자 | 글꼴·배경색 변경 |
| UI 갱신 | BeginInvoke를 이용한 시간 표시 |

## 구현하며 익힌 점

여러 문서를 열면 메뉴에서 선택한 기능이 어느 문서에 적용되는지 구분해야 했습니다. 부모 폼에서 활성 자식 폼을 찾고, 해당 폼의 편집기를 통해 내용을 변경하도록 구성했습니다.

저장 기능에서는 문서마다 파일 경로를 관리했습니다. 시간 표시용 스레드에서는 `BeginInvoke`로 UI 갱신을 전달하며 백그라운드 작업과 화면 처리를 구분하는 방법을 공부했습니다.

[부모 폼·메뉴 처리](MDI_Test/MainForm.cs) · [자식 문서](MDI_Test/Form2.cs) · [테스트 텍스트](samples)

수업 요구사항을 바탕으로 WinForms 기본 구조를 익힌 실습입니다. 인쇄 메뉴는 대화상자 연결까지 구현했습니다.

## 실행 방법

Windows, Visual Studio, .NET Framework 4.7.2 개발 도구를 준비하고 `MDI_Test.slnx` 또는 `MDI_Test/MDI_Test.csproj`를 열어 실행합니다.
