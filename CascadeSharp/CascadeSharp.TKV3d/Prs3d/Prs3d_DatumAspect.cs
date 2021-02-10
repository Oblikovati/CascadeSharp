//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKV3d.Prs3d
{
    //---------------------------------------------------------------------
    //  Class  Prs3d_DatumAspect
    //---------------------------------------------------------------------
    public sealed class Prs3d_DatumAspect : Prs3d_BasicAspect
    {
        public Prs3d_DatumAspect()
            : base()
        {
            throw new NotImplementedException();
        }

        public Prs3d_DatumAspect(Prs3d_DatumAspect parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public Prs3d_LineAspect LineAspect(Prs3d_DatumParts thePart)
        {
            throw new NotImplementedException();
        }

        public Prs3d_ShadingAspect ShadingAspect(Prs3d_DatumParts thePart)
        {
            throw new NotImplementedException();
        }

        public Prs3d_TextAspect TextAspect()
        {
            throw new NotImplementedException();
        }

        public void SetTextAspect(Prs3d_TextAspect theTextAspect)
        {
            throw new NotImplementedException();
        }

        public Prs3d_PointAspect PointAspect()
        {
            throw new NotImplementedException();
        }

        public void SetPointAspect(Prs3d_PointAspect theAspect)
        {
            throw new NotImplementedException();
        }

        public Prs3d_ArrowAspect ArrowAspect()
        {
            throw new NotImplementedException();
        }

        public void SetArrowAspect(Prs3d_ArrowAspect theAspect)
        {
            throw new NotImplementedException();
        }

        public Prs3d_LineAspect FirstAxisAspect()
        {
            throw new NotImplementedException();
        }

        public Prs3d_LineAspect SecondAxisAspect()
        {
            throw new NotImplementedException();
        }

        public Prs3d_LineAspect ThirdAxisAspect()
        {
            throw new NotImplementedException();
        }

        public void SetDrawFirstAndSecondAxis(bool theToDraw)
        {
            throw new NotImplementedException();
        }

        public bool DrawFirstAndSecondAxis()
        {
            throw new NotImplementedException();
        }

        public void SetDrawThirdAxis(bool theToDraw)
        {
            throw new NotImplementedException();
        }

        public bool DrawThirdAxis()
        {
            throw new NotImplementedException();
        }

        public bool DrawDatumPart(Prs3d_DatumParts thePart)
        {
            throw new NotImplementedException();
        }

        public void SetDrawDatumAxes(Prs3d_DatumAxes theType)
        {
            throw new NotImplementedException();
        }

        public Prs3d_DatumAxes DatumAxes()
        {
            throw new NotImplementedException();
        }

        public void SetAttribute(Prs3d_DatumAttribute theType, double theValue)
        {
            throw new NotImplementedException();
        }

        public double Attribute(Prs3d_DatumAttribute theType)
        {
            throw new NotImplementedException();
        }

        public void SetAxisLength(double theL1, double theL2, double theL3)
        {
            throw new NotImplementedException();
        }

        public double AxisLength(Prs3d_DatumParts thePart)
        {
            throw new NotImplementedException();
        }

        public double FirstAxisLength()
        {
            throw new NotImplementedException();
        }

        public double SecondAxisLength()
        {
            throw new NotImplementedException();
        }

        public double ThirdAxisLength()
        {
            throw new NotImplementedException();
        }

        public bool ToDrawLabels()
        {
            throw new NotImplementedException();
        }

        public void SetDrawLabels(bool theToDraw)
        {
            throw new NotImplementedException();
        }

        public void SetToDrawLabels(bool theToDraw)
        {
            throw new NotImplementedException();
        }

        public bool ToDrawArrows()
        {
            throw new NotImplementedException();
        }

        public void SetDrawArrows(bool theToDraw)
        {
            throw new NotImplementedException();
        }

        public Prs3d_DatumParts ArrowPartForAxis(Prs3d_DatumParts thePart)
        {
            throw new NotImplementedException();
        }
    }; // class Prs3d_DatumAspect
}