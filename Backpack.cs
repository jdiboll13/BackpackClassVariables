using System;

namespace BackpackClassVariables
{
    public class Backpack
    {
        public int numPen { get; set; }
        public int numPencil { get; set; }
        public int numFolder { get; set; }
        

        public Backpack(int pen, int pencil, int folder)
        {
            numPen = pen;
            numPencil = pencil;
            numFolder = folder;
        }
        public Boolean Tracking()
        {
            if (Pen.Length > 0 || Pencil.Length > 0 || Folder.Length > 0)
            {
                IsTracked = true;
            }
            return IsTracked;
        }
        public string AddPen()
        {
            Pen[] += "pen";
            return Pen[];

        }

    }

}