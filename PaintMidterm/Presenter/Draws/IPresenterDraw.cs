using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintMidterm.Presenter.Draws
{
    interface IPresenterDraw
    {
        void getDrawing(Graphics g);

        void onClickMouseDown(Point p);


        void onClickMouseMove(Point p);


        void onClickMouseUp();


        void onClickDrawLine();


        void onClickDrawRectangle();


        void onClickDrawEllipse();


        void onClickDrawBezier();


        void onClickDrawPolygon();


        void onClickDrawPen();


        void onClickDrawEraser();


        void onClickStopDrawing(MouseButtons mouse);
    }
}
