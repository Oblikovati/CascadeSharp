//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKGeomBase.AppCont
{
    //---------------------------------------------------------------------
    //  Class  AppCont_Function
    //---------------------------------------------------------------------
    public abstract class AppCont_Function
    {
        public AppCont_Function()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public AppCont_Function(AppCont_Function parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public void GetNumberOfPoints(ref int theNbPnt, ref int theNbPnt2d)
        {
            throw new NotImplementedException();
        }

        public int GetNbOf3dPoints()
        {
            throw new NotImplementedException();
        }

        public int GetNbOf2dPoints()
        {
            throw new NotImplementedException();
        }

        public double FirstParameter()
        {
            throw new NotImplementedException();
        }

        public double LastParameter()
        {
            throw new NotImplementedException();
        }

        public void PeriodInformation(int parameter1, ref bool IsPeriodic, ref double thePeriod)
        {
            throw new NotImplementedException();
        }
    }; // class AppCont_Function
}