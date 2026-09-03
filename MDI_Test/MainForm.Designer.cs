namespace MDI_Test
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Mnu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_New = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Mnu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_AllClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Mnu_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Mnu_PageSet = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Preview = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Mnu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.Mnu_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Format = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Font = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Background = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_View = new System.Windows.Forms.ToolStripMenuItem();
            this.View_Stair = new System.Windows.Forms.ToolStripMenuItem();
            this.View_Tile = new System.Windows.Forms.ToolStripMenuItem();
            this.View_Icon = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Tool_New = new System.Windows.Forms.ToolStripButton();
            this.Tool_Open = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Tool_Save = new System.Windows.Forms.ToolStripButton();
            this.Tool_SaveAs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Tool_Print = new System.Windows.Forms.ToolStripButton();
            this.Tool_Preview = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.Tool_Copy = new System.Windows.Forms.ToolStripButton();
            this.Tool_Cut = new System.Windows.Forms.ToolStripButton();
            this.Tool_Paste = new System.Windows.Forms.ToolStripButton();
            this.Tool_Undo = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Toolstrip_Date = new System.Windows.Forms.ToolStripStatusLabel();
            this.Toolstrip_DateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.Toolstrip_Log = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_File,
            this.Mnu_Edit,
            this.Mnu_Format,
            this.Mnu_View,
            this.Mnu_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Mnu_File
            // 
            this.Mnu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_New,
            this.toolStripMenuItem1,
            this.Mnu_Open,
            this.Mnu_Close,
            this.Mnu_AllClose,
            this.toolStripSeparator3,
            this.Mnu_Save,
            this.Mnu_SaveAs,
            this.toolStripSeparator4,
            this.Mnu_PageSet,
            this.Mnu_Print,
            this.Mnu_Preview,
            this.toolStripSeparator5,
            this.Mnu_Exit});
            this.Mnu_File.Name = "Mnu_File";
            this.Mnu_File.Size = new System.Drawing.Size(57, 20);
            this.Mnu_File.Text = "파일(&F)";
            // 
            // Mnu_New
            // 
            this.Mnu_New.Name = "Mnu_New";
            this.Mnu_New.Size = new System.Drawing.Size(194, 22);
            this.Mnu_New.Text = "새로 만들기(&N)";
            this.Mnu_New.Click += new System.EventHandler(this.TMI_New_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(191, 6);
            // 
            // Mnu_Open
            // 
            this.Mnu_Open.Name = "Mnu_Open";
            this.Mnu_Open.Size = new System.Drawing.Size(194, 22);
            this.Mnu_Open.Text = "열기(&O)";
            this.Mnu_Open.Click += new System.EventHandler(this.TMI_Open_Click);
            // 
            // Mnu_Close
            // 
            this.Mnu_Close.Name = "Mnu_Close";
            this.Mnu_Close.Size = new System.Drawing.Size(194, 22);
            this.Mnu_Close.Text = "닫기(&C)";
            this.Mnu_Close.Click += new System.EventHandler(this.TMI_Close_Click);
            // 
            // Mnu_AllClose
            // 
            this.Mnu_AllClose.Name = "Mnu_AllClose";
            this.Mnu_AllClose.Size = new System.Drawing.Size(194, 22);
            this.Mnu_AllClose.Text = "모두 닫기";
            this.Mnu_AllClose.Click += new System.EventHandler(this.TMI_CloseAll_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(191, 6);
            // 
            // Mnu_Save
            // 
            this.Mnu_Save.Name = "Mnu_Save";
            this.Mnu_Save.Size = new System.Drawing.Size(194, 22);
            this.Mnu_Save.Text = "저장(&S)";
            this.Mnu_Save.Click += new System.EventHandler(this.TMI_Save_Click);
            // 
            // Mnu_SaveAs
            // 
            this.Mnu_SaveAs.Name = "Mnu_SaveAs";
            this.Mnu_SaveAs.Size = new System.Drawing.Size(194, 22);
            this.Mnu_SaveAs.Text = "다른 이름으로 저장(&A)";
            this.Mnu_SaveAs.Click += new System.EventHandler(this.TMI_SaveAs_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(191, 6);
            // 
            // Mnu_PageSet
            // 
            this.Mnu_PageSet.Name = "Mnu_PageSet";
            this.Mnu_PageSet.Size = new System.Drawing.Size(194, 22);
            this.Mnu_PageSet.Text = "페이지 설정(&U)";
            this.Mnu_PageSet.Click += new System.EventHandler(this.TMI_PageSet_Click);
            // 
            // Mnu_Print
            // 
            this.Mnu_Print.Name = "Mnu_Print";
            this.Mnu_Print.Size = new System.Drawing.Size(194, 22);
            this.Mnu_Print.Text = "출력(&P)";
            this.Mnu_Print.Click += new System.EventHandler(this.TMI_Print_Click);
            // 
            // Mnu_Preview
            // 
            this.Mnu_Preview.Name = "Mnu_Preview";
            this.Mnu_Preview.Size = new System.Drawing.Size(194, 22);
            this.Mnu_Preview.Text = "미리보기(&R)";
            this.Mnu_Preview.Click += new System.EventHandler(this.TMI_Preview_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(191, 6);
            // 
            // Mnu_Exit
            // 
            this.Mnu_Exit.Name = "Mnu_Exit";
            this.Mnu_Exit.Size = new System.Drawing.Size(194, 22);
            this.Mnu_Exit.Text = "끝내기(&X)";
            this.Mnu_Exit.Click += new System.EventHandler(this.TMI_Exit_Click);
            // 
            // Mnu_Edit
            // 
            this.Mnu_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_Undo,
            this.toolStripSeparator6,
            this.Mnu_Cut,
            this.Mnu_Copy,
            this.Mnu_Paste});
            this.Mnu_Edit.Name = "Mnu_Edit";
            this.Mnu_Edit.Size = new System.Drawing.Size(57, 20);
            this.Mnu_Edit.Text = "편집(&E)";
            // 
            // Mnu_Undo
            // 
            this.Mnu_Undo.Name = "Mnu_Undo";
            this.Mnu_Undo.Size = new System.Drawing.Size(153, 22);
            this.Mnu_Undo.Text = "지우기 취소(&Z)";
            this.Mnu_Undo.Click += new System.EventHandler(this.TMI_Undo_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(150, 6);
            // 
            // Mnu_Cut
            // 
            this.Mnu_Cut.Name = "Mnu_Cut";
            this.Mnu_Cut.Size = new System.Drawing.Size(153, 22);
            this.Mnu_Cut.Text = "잘라내기(&X)";
            this.Mnu_Cut.Click += new System.EventHandler(this.TMI_Cut_Click);
            // 
            // Mnu_Copy
            // 
            this.Mnu_Copy.Name = "Mnu_Copy";
            this.Mnu_Copy.Size = new System.Drawing.Size(153, 22);
            this.Mnu_Copy.Text = "복사(&C)";
            this.Mnu_Copy.Click += new System.EventHandler(this.TMI_Copy_Click);
            // 
            // Mnu_Paste
            // 
            this.Mnu_Paste.Name = "Mnu_Paste";
            this.Mnu_Paste.Size = new System.Drawing.Size(153, 22);
            this.Mnu_Paste.Text = "붙여넣기(&V)";
            this.Mnu_Paste.Click += new System.EventHandler(this.TMI_Paste_Click);
            // 
            // Mnu_Format
            // 
            this.Mnu_Format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_Font,
            this.Mnu_Background});
            this.Mnu_Format.Name = "Mnu_Format";
            this.Mnu_Format.Size = new System.Drawing.Size(58, 20);
            this.Mnu_Format.Text = "서식(&S)";
            // 
            // Mnu_Font
            // 
            this.Mnu_Font.Name = "Mnu_Font";
            this.Mnu_Font.Size = new System.Drawing.Size(125, 22);
            this.Mnu_Font.Text = "글꼴";
            this.Mnu_Font.Click += new System.EventHandler(this.TMI_Font_Click);
            // 
            // Mnu_Background
            // 
            this.Mnu_Background.Name = "Mnu_Background";
            this.Mnu_Background.Size = new System.Drawing.Size(125, 22);
            this.Mnu_Background.Text = "배경색(&B)";
            this.Mnu_Background.Click += new System.EventHandler(this.TMI_BackColor_Click);
            // 
            // Mnu_View
            // 
            this.Mnu_View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.View_Stair,
            this.View_Tile,
            this.View_Icon});
            this.Mnu_View.Name = "Mnu_View";
            this.Mnu_View.Size = new System.Drawing.Size(50, 20);
            this.Mnu_View.Text = "창(&W)";
            // 
            // View_Stair
            // 
            this.View_Stair.Name = "View_Stair";
            this.View_Stair.Size = new System.Drawing.Size(150, 22);
            this.View_Stair.Text = "계단식 정렬";
            this.View_Stair.Click += new System.EventHandler(this.TMI_Cascade_Click);
            // 
            // View_Tile
            // 
            this.View_Tile.Name = "View_Tile";
            this.View_Tile.Size = new System.Drawing.Size(150, 22);
            this.View_Tile.Text = "바둑판식 정렬";
            this.View_Tile.Click += new System.EventHandler(this.TMI_TileHorizontal_Click);
            // 
            // View_Icon
            // 
            this.View_Icon.Name = "View_Icon";
            this.View_Icon.Size = new System.Drawing.Size(150, 22);
            this.View_Icon.Text = "아이콘식 정렬";
            this.View_Icon.Click += new System.EventHandler(this.TMI_ArrangeIcons_Click);
            // 
            // Mnu_Help
            // 
            this.Mnu_Help.Name = "Mnu_Help";
            this.Mnu_Help.Size = new System.Drawing.Size(55, 20);
            this.Mnu_Help.Text = "도움말";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_New,
            this.Tool_Open,
            this.toolStripSeparator1,
            this.Tool_Save,
            this.Tool_SaveAs,
            this.toolStripSeparator2,
            this.Tool_Print,
            this.Tool_Preview,
            this.toolStripSeparator7,
            this.Tool_Copy,
            this.Tool_Cut,
            this.Tool_Paste,
            this.Tool_Undo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Tool_New
            // 
            this.Tool_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tool_New.Image = ((System.Drawing.Image)(resources.GetObject("Tool_New.Image")));
            this.Tool_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_New.Name = "Tool_New";
            this.Tool_New.Size = new System.Drawing.Size(23, 22);
            this.Tool_New.Text = "New";
            this.Tool_New.Click += new System.EventHandler(this.Tool_New_Click);
            // 
            // Tool_Open
            // 
            this.Tool_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tool_Open.Image = ((System.Drawing.Image)(resources.GetObject("Tool_Open.Image")));
            this.Tool_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_Open.Name = "Tool_Open";
            this.Tool_Open.Size = new System.Drawing.Size(23, 22);
            this.Tool_Open.Text = "Open";
            this.Tool_Open.Click += new System.EventHandler(this.Tool_Open_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Tool_Save
            // 
            this.Tool_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tool_Save.Image = ((System.Drawing.Image)(resources.GetObject("Tool_Save.Image")));
            this.Tool_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_Save.Name = "Tool_Save";
            this.Tool_Save.Size = new System.Drawing.Size(23, 22);
            this.Tool_Save.Text = "Save";
            this.Tool_Save.Click += new System.EventHandler(this.Tool_Save_Click);
            // 
            // Tool_SaveAs
            // 
            this.Tool_SaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tool_SaveAs.Image = ((System.Drawing.Image)(resources.GetObject("Tool_SaveAs.Image")));
            this.Tool_SaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_SaveAs.Name = "Tool_SaveAs";
            this.Tool_SaveAs.Size = new System.Drawing.Size(23, 22);
            this.Tool_SaveAs.Text = "Save As";
            this.Tool_SaveAs.Click += new System.EventHandler(this.Tool_SaveAs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Tool_Print
            // 
            this.Tool_Print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tool_Print.Image = ((System.Drawing.Image)(resources.GetObject("Tool_Print.Image")));
            this.Tool_Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_Print.Name = "Tool_Print";
            this.Tool_Print.Size = new System.Drawing.Size(23, 22);
            this.Tool_Print.Text = "Print";
            this.Tool_Print.Click += new System.EventHandler(this.Tool_Print_Click);
            // 
            // Tool_Preview
            // 
            this.Tool_Preview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tool_Preview.Image = ((System.Drawing.Image)(resources.GetObject("Tool_Preview.Image")));
            this.Tool_Preview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_Preview.Name = "Tool_Preview";
            this.Tool_Preview.Size = new System.Drawing.Size(23, 22);
            this.Tool_Preview.Text = "Preview";
            this.Tool_Preview.Click += new System.EventHandler(this.Tool_Preview_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // Tool_Copy
            // 
            this.Tool_Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tool_Copy.Image = ((System.Drawing.Image)(resources.GetObject("Tool_Copy.Image")));
            this.Tool_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_Copy.Name = "Tool_Copy";
            this.Tool_Copy.Size = new System.Drawing.Size(23, 22);
            this.Tool_Copy.Text = "Copy";
            this.Tool_Copy.Click += new System.EventHandler(this.Tool_Copy_Click);
            // 
            // Tool_Cut
            // 
            this.Tool_Cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tool_Cut.Image = ((System.Drawing.Image)(resources.GetObject("Tool_Cut.Image")));
            this.Tool_Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_Cut.Name = "Tool_Cut";
            this.Tool_Cut.Size = new System.Drawing.Size(23, 22);
            this.Tool_Cut.Text = "Cut";
            this.Tool_Cut.Click += new System.EventHandler(this.Tool_Cut_Click);
            // 
            // Tool_Paste
            // 
            this.Tool_Paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tool_Paste.Image = ((System.Drawing.Image)(resources.GetObject("Tool_Paste.Image")));
            this.Tool_Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_Paste.Name = "Tool_Paste";
            this.Tool_Paste.Size = new System.Drawing.Size(23, 22);
            this.Tool_Paste.Text = "Paste";
            this.Tool_Paste.Click += new System.EventHandler(this.Tool_Paste_Click);
            // 
            // Tool_Undo
            // 
            this.Tool_Undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tool_Undo.Image = ((System.Drawing.Image)(resources.GetObject("Tool_Undo.Image")));
            this.Tool_Undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_Undo.Name = "Tool_Undo";
            this.Tool_Undo.Size = new System.Drawing.Size(23, 22);
            this.Tool_Undo.Text = "Undo";
            this.Tool_Undo.Click += new System.EventHandler(this.Tool_Undo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Toolstrip_Date,
            this.Toolstrip_DateTime,
            this.Toolstrip_Log});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Toolstrip_Date
            // 
            this.Toolstrip_Date.Name = "Toolstrip_Date";
            this.Toolstrip_Date.Size = new System.Drawing.Size(83, 17);
            this.Toolstrip_Date.Text = "Toolstrip_Date";
            // 
            // Toolstrip_DateTime
            // 
            this.Toolstrip_DateTime.Name = "Toolstrip_DateTime";
            this.Toolstrip_DateTime.Size = new System.Drawing.Size(109, 17);
            this.Toolstrip_DateTime.Text = "Toolstrip_DateTime";
            // 
            // Toolstrip_Log
            // 
            this.Toolstrip_Log.Name = "Toolstrip_Log";
            this.Toolstrip_Log.Size = new System.Drawing.Size(593, 17);
            this.Toolstrip_Log.Spring = true;
            this.Toolstrip_Log.Text = "Toolstrip_Log";
            this.Toolstrip_Log.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Mnu_File;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Open;
        private System.Windows.Forms.ToolStripMenuItem Mnu_New;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Close;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Tool_New;
        private System.Windows.Forms.ToolStripButton Tool_Open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Tool_Save;
        private System.Windows.Forms.ToolStripButton Tool_SaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Tool_Print;
        private System.Windows.Forms.ToolStripButton Tool_Preview;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Toolstrip_Date;
        private System.Windows.Forms.ToolStripStatusLabel Toolstrip_DateTime;
        private System.Windows.Forms.ToolStripStatusLabel Toolstrip_Log;
        private System.Windows.Forms.ToolStripMenuItem Mnu_AllClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Save;
        private System.Windows.Forms.ToolStripMenuItem Mnu_SaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem Mnu_PageSet;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Print;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Preview;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Exit;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Edit;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Undo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Cut;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Copy;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Paste;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Format;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Font;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Background;
        private System.Windows.Forms.ToolStripMenuItem Mnu_View;
        private System.Windows.Forms.ToolStripMenuItem View_Stair;
        private System.Windows.Forms.ToolStripMenuItem View_Tile;
        private System.Windows.Forms.ToolStripMenuItem View_Icon;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Help;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton Tool_Copy;
        private System.Windows.Forms.ToolStripButton Tool_Cut;
        private System.Windows.Forms.ToolStripButton Tool_Paste;
        private System.Windows.Forms.ToolStripButton Tool_Undo;
    }
}

