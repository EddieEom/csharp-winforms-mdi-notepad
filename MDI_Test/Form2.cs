using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Test
{
    public partial class Form2 : Form
    {
        // 현재 파일 경로
        public string FilePath = "";

        // 자식 폼(문서 생성 시 필요)
        public TextBox Editor
        {
            get { return textBox1; }
        }

        public Form2()
        {
            InitializeComponent();
        }
    }
}