using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _13.Inheritance
{
    class CCar : CCycle
    {
        public Rectangle _rtSquare2;    //몸통

        public CCar(string sName) : base(sName)
        {
            strName = sName;
            _Pen = new Pen(Color.Blue, 3);

            _rtCircle1 = new Rectangle(60, 180, 90, 90);
            _rtCircle2 = new Rectangle(210, 180, 90, 90);
            _rtSquare1 = new Rectangle(90, 30, 180, 90);
            _rtSquare1 = new Rectangle(30, 120, 300, 60);
        }

        public void fMove(int iMove)
        {
            base.fMove(iMove);

            fSquare2Move(iMove);
        }

        protected void fSquare2Move(int iMove)
        {
            Point oPoint = _rtSquare2.Location;
            oPoint.X = oPoint.X + iMove;
            _rtSquare2.Location = oPoint;
        }
    }
}
