using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace MDI_Test
{
    public partial class MainForm : Form
    {

        // 스레드 및 제어 변수 선언
        private Thread timeThread = null;
        private bool isRunning = true;

        public MainForm()
        {
            InitializeComponent();

            // 시작 메시지
            SetStatus("프로그램 시작");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 폼이 로드될 때 백그라운드 스레드 시작
            timeThread = new Thread(new ThreadStart(UpdateTimeLoop));
            timeThread.IsBackground = true; // 프로그램 종료 시 스레드도 자동 종료되도록 설정
            timeThread.Start();
        }

        // 스레드 루프 메서드
        private void UpdateTimeLoop()
        {
            while (isRunning)
            {
                // BeginInvoke (크로스 스레드 방지)
                this.BeginInvoke(new Action(() =>
                {
                    SetDateTime();
                }));

                Thread.Sleep(1000);
            }
        }

        // 날짜/시간 출력
        private void SetDateTime()
        {
            // Toolstrip 1번째 Date 출력
            Toolstrip_Date.Text =
                DateTime.Now.ToString("yyyy-MM-dd");

            // Toolstrip 2번째 DateTime 출력
            Toolstrip_DateTime.Text =
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        // toolstrip 3번째꺼 상태 메시지 출력
        private void SetStatus(string msg)
        {
            // Toolstrip_log 텍스트에 msg 출력
            Toolstrip_Log.Text = msg;
        }

        

        // 자식폼 TextBox 내용 가져오기
        private TextBox GetActiveTextBox()
        {
            // 자식폼 객체 불러오기
            Form2 child = GetActiveForm();


            // 자식폼에 내용이 있으면
            if (child != null)
                // 열기
                return child.Editor;

            return null;
        }

        // ============================= 파일 메뉴 ========================================
        // 새로 만들기

        int Child_Count = 0;

        private void TMI_New_Click(object sender, EventArgs e)
        {
            // 문서 생성 자식 폼 들고 오기
            Form2 child = new Form2();

            // 자식 폼 갯수 1개씩 추가
            Child_Count++;

            // 현재 객체를 부모 지정
            child.MdiParent = this;

            // 자식폼 창 제목
            child.Text = "문서 " + Child_Count;

            // 화면 출력
            child.Show();

            // 로그에 생성 한것 출력
            SetStatus(child.Text + " 생성");
        }

        // 파일 열기
        private void TMI_Open_Click(object sender, EventArgs e)
        {

            // OpenFileDialog 객체 생성
            OpenFileDialog open = new OpenFileDialog();

            // 파일 확장자 설정
            open.Filter = "텍스트 파일|*.txt|모든 파일|*.*";

            // 만약 파일을 열면
            if (open.ShowDialog() == DialogResult.OK)
            {
                // 자식 폼 객체 생성
                Form2 child = new Form2();

                // 자식 폼 갯수 1개 추가
                Child_Count++;

                // 현재 객체를 부모 지정
                child.MdiParent = this;

                // 파일명만 제목으로
                child.Text = Path.GetFileName(open.FileName);

                // 전체 경로 저장
                child.FilePath = open.FileName;

                // 화면에 출력
                child.Show();

                // 자식폼 불러오기
                TextBox tb =
                    child.Controls["textBox1"] as TextBox;

                // TextBox에 있는 내용 불러오기
                tb.Text = File.ReadAllText(open.FileName);

                SetStatus("파일 열기 : " + open.FileName);
            }
        }

        // 현재 활성화 된 자식 폼 가져오는 로직
        private Form2 GetActiveForm()
        {
            return this.ActiveMdiChild as Form2;
        }

        // 파일 닫기
        private void TMI_Close_Click(object sender, EventArgs e)
        {
            // 현재 활성화 된 자식폼 객체 불러오기
            Form2 child = GetActiveForm();

            // 만약 자식폼이 있으면
            if (child != null)
            {
                // 로그 띄우고
                SetStatus(child.Text + " 닫힘");
                // 자식폼 닫힘
                child.Close();
            }
        }

        // 파일 모두 닫기
        private void TMI_CloseAll_Click(object sender, EventArgs e)
        {
            // foreach 반복문으로 자식폼 전부 꺼내기
            foreach (Form child in this.MdiChildren)
            {
                // 자식폼 닫기
                child.Close();
            }

            SetStatus("모든 창 닫기 완료");
        }

        // 파일 저장
        private void TMI_Save_Click(object sender, EventArgs e)
        {
            // 현재 활성화된 자식폼 객체 불러오기
            Form2 child = GetActiveForm();

            // 자식폼이 없으면 무반응
            if (child == null)
                return;

            // 자식폼 불러오기
            TextBox tb =
                child.Controls["textBox1"] as TextBox;

            // 처음 저장이면 SaveAs 실행
            if (child.FilePath == "")
            {
                TMI_SaveAs_Click(sender, e);

                return;
            }

            // 기존 파일 덮어쓰기
            File.WriteAllText(child.FilePath, tb.Text);

            SetStatus("저장 완료 : " + child.FilePath);
        }

        // 다른 이름으로 저장
        private void TMI_SaveAs_Click(object sender, EventArgs e)
        {

            // 현재 활성화된 자식폼 객체 불러오기
            Form2 child = GetActiveForm();

            // 자식폼이 없으면 무반응
            if (child == null)
                return;

            // SaveFileDialog 객체 생성 하기.
            SaveFileDialog save = new SaveFileDialog();

            // 세이브할 확장자 설정하기
            save.Filter = "텍스트 파일|*.txt";

            // 만약 세이브를 한다면
            if (save.ShowDialog() == DialogResult.OK)
            {
                // 자식폼 내용 불러오기
                TextBox tb =
                    child.Controls["textBox1"] as TextBox;

                // 파일 저장하기
                File.WriteAllText(save.FileName, tb.Text);

                // 새 경로 기억
                child.FilePath = save.FileName;

                // 창 제목 변경하기
                child.Text = Path.GetFileName(save.FileName);

                SetStatus("다른 이름 저장 : " + save.FileName);
            }
        }

        System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();

        // 페이지 설정
        private void TMI_PageSet_Click(object sender, EventArgs e)
        {
            // 페이지 설정 객체 생성하기
            PageSetupDialog page = new PageSetupDialog();

            // 대화상자에 대상 문서(printDocument)를 연결.
            page.Document = printDocument;

            // 페이지 설정 실행
            page.ShowDialog();

            SetStatus("페이지 설정");
        }

        // 출력
        private void TMI_Print_Click(object sender, EventArgs e)
        {
            // 프린트 객체 생성하기
            PrintDialog print = new PrintDialog();

            print.Document = printDocument; // 연결

            // 프린트 실행
            print.ShowDialog();

            SetStatus("출력 실행");
        }

        // 미리보기
        private void TMI_Preview_Click(object sender, EventArgs e)
        {
            // 미리보기 객체 생성하기
            PrintPreviewDialog preview = new PrintPreviewDialog();

            preview.Document = printDocument; // 연결

            // 미리보기 실행
            preview.ShowDialog();

            SetStatus("출력 미리보기");
        }

        // 끝내기
        private void TMI_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // ============================= 파일 메뉴 끝 ========================================

        // ============================= 편집 메뉴 ========================================
        // 되돌리기
        private void TMI_Undo_Click(object sender, EventArgs e)
        {
            // 자식폼 내용 들고오기
            TextBox tb = GetActiveTextBox();

            // 만약 자식폼에 내용이 있으면
            if (tb != null)
            {
            
                if (tb.CanUndo)
                {
                    // 지우기 취소하기
                    tb.Undo();

                    SetStatus("실행 취소");
                }
            }
        }


        // 내용 지우기 
        private void TMI_Clear_Click(object sender, EventArgs e)
        {
            TextBox tb = GetActiveTextBox();

            // 만약 자식폼에 내용이 있으면
            if (tb != null)
            {
                // 내용 지움
                tb.Clear();

                SetStatus("내용 지움");
            }
        }


        // 잘라내기
        private void TMI_Cut_Click(object sender, EventArgs e)
        {
            TextBox tb = GetActiveTextBox();

            if (tb != null)
            {
                tb.Cut();

                SetStatus("잘라내기");
            }
        }

        // 복사하기
        private void TMI_Copy_Click(object sender, EventArgs e)
        {
            TextBox tb = GetActiveTextBox();

            if (tb != null)
            {
                tb.Copy();

                SetStatus("복사");
            }
        }

        // 붙여넣기
        private void TMI_Paste_Click(object sender, EventArgs e)
        {
            TextBox tb = GetActiveTextBox();

            if (tb != null)
            {
                tb.Paste();

                SetStatus("붙여넣기");
            }
        }
        // ============================= 편집 메뉴　끝 ========================================
        // ============================= 서식 메뉴 ========================================

        // 글꼴 메뉴
        private void TMI_Font_Click(object sender, EventArgs e)
        {
            TextBox tb = GetActiveTextBox();

            if (tb != null)
            {
                FontDialog fontDlg = new FontDialog();

                // 현재 폰트 불러오기
                fontDlg.Font = tb.Font;

                if (fontDlg.ShowDialog() == DialogResult.OK)
                {
                    tb.Font = fontDlg.Font;

                    SetStatus("글꼴 변경");
                }
            }
        }


        // 배경색
        private void TMI_BackColor_Click(object sender, EventArgs e)
        {
            TextBox tb = GetActiveTextBox();

            if (tb != null)
            {
                ColorDialog colorDlg = new ColorDialog();

                if (colorDlg.ShowDialog() == DialogResult.OK)
                {
                    tb.BackColor = colorDlg.Color;

                    SetStatus("배경색 변경");
                }
            }
        }
        // ============================= 서식 메뉴끝 ========================================
        // ============================= 정렬 메뉴 ==========================================

        // 계단식 정렬 (Cascade)
        private void TMI_Cascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);

            SetStatus("계단식 정렬");
        }


        // 바둑판식 정렬 (Tile)
        private void TMI_TileHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);

            SetStatus("바둑판식 가로 정렬");
        }

        // 아이콘식 정렬 (Icon)
        private void TMI_ArrangeIcons_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);

            SetStatus("아이콘 정렬");
        }

        // ============================= 정렬 메뉴 끝 ==========================================
        // ============================= 아이콘 메뉴 ==========================================

        // 새로 만들기
        private void Tool_New_Click(object sender, EventArgs e)
        {
            TMI_New_Click(sender, e);
        }

        // 파일 열기
        private void Tool_Open_Click(object sender, EventArgs e)
        {
            TMI_Open_Click(sender, e);
        }


        // 저장 하기
        private void Tool_Save_Click(object sender, EventArgs e)
        {
            TMI_Save_Click(sender, e);
        }


        // 다른이름으로 저장
        private void Tool_SaveAs_Click(object sender, EventArgs e)
        {
            TMI_SaveAs_Click(sender, e);
        }

        // 프린트 하기
        private void Tool_Print_Click(object sender, EventArgs e)
        {
            TMI_Print_Click(sender, e);
        }

        // 미리보기
        private void Tool_Preview_Click(object sender, EventArgs e)
        {
            TMI_Preview_Click(sender, e);
        }

        // 복사하기
        private void Tool_Copy_Click(object sender, EventArgs e)
        {
            TMI_Copy_Click(sender, e);
        }

        // 잘라내기
        private void Tool_Cut_Click(object sender, EventArgs e)
        {
            TMI_Cut_Click(sender, e);
        }

        // 붙여넣기
        private void Tool_Paste_Click(object sender, EventArgs e)
        {
            TMI_Paste_Click(sender, e);
        }

        // 되돌리기
        private void Tool_Undo_Click(object sender, EventArgs e)
        {
            TMI_Undo_Click(sender, e);
        }


    }
}