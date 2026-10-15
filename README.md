# C# WinForms MDI 메모장

교수님이 제시한 화면 구성과 기능을 참고해 만든 수업 과제입니다. 제시된 범위에 맞춰 구현했으며, 과제 외에 별도로 추가한 기능은 없습니다.

## 과제 내용

C# WinForms로 여러 문서를 열고 편집할 수 있는 메모장을 만들었습니다. 메뉴를 눌렀을 때 현재 선택한 문서에 기능이 적용되도록 구성했습니다.

## 주요 기능

- MDI 부모·자식 폼을 이용한 여러 문서 관리
- 텍스트 파일 열기·저장·다른 이름으로 저장
- 실행 취소·잘라내기·복사·붙여넣기
- 글꼴과 배경색 변경
- 문서 창 배치
- 상태바 표시와 시간 갱신

인쇄 관련 기능은 페이지 설정·인쇄·미리보기 대화상자를 연결한 범위입니다.

## 사용 기술

C#, WinForms, .NET Framework 4.7.2, System.IO, System.Threading

## 연습한 내용

- 버튼과 메뉴의 이벤트 처리
- 현재 활성화된 자식 폼 찾기
- 파일 경로와 문서 내용을 연결해 저장하기
- 파일·글꼴·색상 대화상자 사용
- 별도 스레드에서 처리한 내용을 `BeginInvoke`로 UI에 반영하기

## 실행 방법

Windows에서 Visual Studio와 .NET Framework 4.7.2 개발 환경을 준비합니다.

1. 저장소를 내려받습니다.
2. Visual Studio에서 `MDI_Test.slnx` 또는 `MDI_Test/MDI_Test.csproj`를 엽니다.
3. 빌드 후 실행합니다.

```bash
git clone https://github.com/EddieEom/csharp-winforms-mdi-notepad.git
```

위 내용은 기존 README의 실행 환경을 기준으로 정리했습니다.
