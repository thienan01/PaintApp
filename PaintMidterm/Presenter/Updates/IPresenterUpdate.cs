using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintMidterm.Presenter.Updates
{
    interface IPresenterUpdate
    {


        void onClickSelectMode();

        void onClickSelectColor(Color color, Graphics g);

        void onClickSelectSize(int size);

        void onClickSelectFill(Button btn, Graphics g);


    }
}
