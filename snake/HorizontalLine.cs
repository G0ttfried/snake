﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class HorizontalLine
    {
        List<Point> pList;

        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for(int i=xLeft; i<=xRight; i++)
            {
                Point p = new Point(i, y, sym);
                pList.Add(p);
            }
        }

        public void Draw()
        {
            foreach(var p in pList)
            {
                p.Draw();
            }
        }
    }
}
