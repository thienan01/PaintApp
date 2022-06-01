using PaintMidterm.Model;
using PaintMidterm.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintMidterm.Presenter.Alter
{
    interface IPresenterAlter
    {
        void onClickDrawGroup();


        void onClickDrawUnGroup();


        void onClickDeleteShape();


        void onClickClearAll(PictureBox picturebox);


        void onClickSaveImage(PictureBox picturebox);


        void onClickOpenImage(PictureBox picturebox);


        void onClickNewImage(PictureBox picturebox);

        void onClickShutdown(PictureBox picturebox);


        void onUseKeyStrokes(PictureBox picturebox, Keys key);

    }
}
