using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingTool
{
    public partial class frmMain : Form
    {
        private int m_X1;
        private int m_Y1;
        private int m_X2;
        private int m_Y2;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            picMain.CreateGraphics().DrawLine(new Pen(Color.Black), 0, 0, 300, 300);
        }

        // 마우스 버튼 클릭시
        private void picMain_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                m_X1 = e.X;
                m_Y1 = e.Y;
            }
        }

        // 마우스 이동(그림 그리는 중)
        private void picMain_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                //현재 위치 저장
                m_X2 = e.X;
                m_Y2 = e.Y;
                picMain.Invalidate();
            }
        }

        // 다시 그릴 때
        private void picMain_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black), m_X1, m_Y1, m_X2, m_Y2);
        }
    }
}
