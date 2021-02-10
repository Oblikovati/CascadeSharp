//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.Intf
{
    //---------------------------------------------------------------------
    //  Class  Intf_SectionPoint
    //---------------------------------------------------------------------
    public sealed class Intf_SectionPoint
    {
        public Intf_SectionPoint()
            : base()
        {
            throw new NotImplementedException();
        }

        public Intf_SectionPoint(gp_Pnt Where, Intf_PIType DimeO, int AddrO1, int AddrO2, double ParamO,
            Intf_PIType DimeT, int AddrT1, int AddrT2, double ParamT, double Incid)
            : base()
        {
            throw new NotImplementedException();
        }

        public Intf_SectionPoint(gp_Pnt2d Where, Intf_PIType DimeO, int AddrO1, double ParamO, Intf_PIType DimeT,
            int AddrT1, double ParamT, double Incid)
            : base()
        {
            throw new NotImplementedException();
        }

        public Intf_SectionPoint(Intf_SectionPoint parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Pnt()
        {
            throw new NotImplementedException();
        }

        public double ParamOnFirst()
        {
            throw new NotImplementedException();
        }

        public double ParamOnSecond()
        {
            throw new NotImplementedException();
        }

        public Intf_PIType TypeOnFirst()
        {
            throw new NotImplementedException();
        }

        public Intf_PIType TypeOnSecond()
        {
            throw new NotImplementedException();
        }

        public void InfoFirst(ref Intf_PIType Dim, ref int Add1, ref int Add2, ref double Param)
        {
            throw new NotImplementedException();
        }

        public void InfoFirst(ref Intf_PIType Dim, ref int Addr, ref double Param)
        {
            throw new NotImplementedException();
        }

        public void InfoSecond(ref Intf_PIType Dim, ref int Add1, ref int Add2, ref double Param)
        {
            throw new NotImplementedException();
        }

        public void InfoSecond(ref Intf_PIType Dim, ref int Addr, ref double Param)
        {
            throw new NotImplementedException();
        }

        public double Incidence()
        {
            throw new NotImplementedException();
        }

        public bool IsEqual(Intf_SectionPoint Other)
        {
            throw new NotImplementedException();
        }

        public bool IsOnSameEdge(Intf_SectionPoint Other)
        {
            throw new NotImplementedException();
        }

        public void Merge(Intf_SectionPoint Other)
        {
            throw new NotImplementedException();
        }

        public void Dump(int Indent)
        {
            throw new NotImplementedException();
        }
    }; // class Intf_SectionPoint
}