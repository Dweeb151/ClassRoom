using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classRoom
{
    internal class ClassRoom : IComparable<ClassRoom>
    {
        // public properties
        // Declares get and set methods
        public int Col { get; set; }
        public int Row { get; set; }
        public string FieldValue { get; set; }
        public string Colour { get; set; }


        /*
        Method:     ClassRoom()
        Purpose:    
        Inputs:     
        Outputs:    
        */
        public ClassRoom(int row, int col, string fieldValue, string colour)
        {
            Col = col;
            Row = row;
            FieldValue = fieldValue;
            Colour = colour;
        }


        /*
        Method:     ToCSVString()
        Purpose:    
        Inputs:     
        Outputs:    
        */
        public string ToCSVString()
        {
            return Col + "," + Row + "," + FieldValue + "," + Colour;
        }

        /*
        Method:     CompareTo()
        Purpose:    
        Inputs:     
        Outputs:    
        */
        public int CompareTo(ClassRoom obj)
        {
            return FieldValue.CompareTo(obj.FieldValue);
        }
    }
}
