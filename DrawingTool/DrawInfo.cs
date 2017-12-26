using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingTool
{
    class DrawInfo
    {
        // 그리기 종류 저장
        public enum DrawType
        {
            Line = 0,

            Rect,
            Ellipse,
            Triangle,

            FillSolidRect,
            FillSolidEllipse,
            FillSolidTrianglel,

            FillHatchRect,
            FillHatchTriangle,

            FillTextureRect,
            FillTextrueEllipse,
            FillTextureTriangle,

            FillGradientRect,
            FillGradientEllipse,
            FillGradientTriangle
        };
    }

    public class _DrawPenInfo // 일반도형
    {
        public int Width; // 선의 두께(픽셀)
        public Color Color; // 선 칼라
        public DashStyle DashStyle; // 선 대쉬 스타일
        public LineCap StartCap, EndCap; // 선 시작/ 끝 모양
    }

    public class _DrawSolidInfo // Solid 도형
    {
        public Color Color; // 브러쉬 칼라
    }
}
