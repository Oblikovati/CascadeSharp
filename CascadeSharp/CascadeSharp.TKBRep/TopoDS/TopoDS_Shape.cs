//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using System.IO;
using System.Text.Json;
using CascadeSharp.TKernel.Standard;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKMath.TopLoc;

namespace CascadeSharp.TKBRep.TopoDS
{
    //---------------------------------------------------------------------
    //  Class  TopoDS_Shape
    //---------------------------------------------------------------------
    /// <summary>
    /// Describes a shape which references an underlying shape with the potential
    /// to be given a location and an orientation has a location for the underlying shape, giving its
    /// placement in the local coordinate system has an orientation for the underlying shape, in
    /// terms of its geometry (as opposed to orientation in relation to other shapes).
    /// Note: A Shape is empty if it references an underlying shape which has an empty list of shapes.
    /// </summary>
    public class TopoDS_Shape
    {
        public TopoDS_Shape()
        {
            myOrient = TopAbs_Orientation.TopAbs_EXTERNAL;
        }

        public TopoDS_Shape(TopoDS_Shape theOther)
        {
            myOrient = theOther.myOrient;
            myLocation = theOther.myLocation;
            myTShape = theOther.myTShape;
        }

        #region Private Objects

        TopoDS_TShape myTShape;
        TopLoc_Location myLocation;
        TopAbs_Orientation myOrient;

        #endregion
        /// <summary>
        /// Returns true if this shape is null. In other words, it  references no underlying shape with the potential to
        /// be given a location and an orientation.
        /// </summary>
        /// <returns></returns>
        public bool IsNull()
        {
            return myTShape is null;
        }
        /// <summary>
        /// Destroys the reference to the underlying shape
        /// stored in this shape. As a result, this shape becomes null.
        /// </summary>
        public void Nullify()
        {
            myTShape = null;
        }
        /// <summary>
        /// Returns the shape local coordinate system.
        /// </summary>
        /// <returns></returns>
        public TopLoc_Location Location
        {
            get => myLocation;
            set => myLocation = value;
        }
        /// <summary>
        /// Returns a  shape  similar to <me> with  the local  coordinate system set to <Loc>.
        /// </summary>
        /// <param name="theLoc"></param>
        /// <returns></returns>
        public TopoDS_Shape Located(TopLoc_Location theLoc)
        {
            var aShape = new TopoDS_Shape(this);
            aShape.Location = theLoc;
            return aShape;
        }
        /// <summary>
        /// Returns the shape orientation.
        /// </summary>
        /// <returns></returns>
        public TopAbs_Orientation Orientation
        {
            get => myOrient;
            set => myOrient = value;
        }
        /// <summary>
        /// Returns  a    shape  similar  to  <me>   with  the  orientation set to <Or>.
        /// </summary>
        /// <param name="theOrient"></param>
        /// <returns></returns>
        public TopoDS_Shape Oriented(TopAbs_Orientation theOrient)
        {
            var aShape = new TopoDS_Shape(this);
            aShape.Orientation = theOrient;
            return aShape;
        }

        public TopoDS_TShape TShape()
        {
            return myTShape;
        }

        public TopAbs_ShapeEnum ShapeType()
        {
            return myTShape.ShapeType();
        }

        public bool Free
        {
            get => myTShape.Free;
            set => myTShape.OnlyFriendsFree(value);
        }

        public bool Locked
        {
            get => myTShape.Locked;
            set => myTShape.OnlyFriendsLocked(value);
        }

        public bool Modified
        {
            get => myTShape.Modified;
            set => myTShape.OnlyFriendsModified(value);
        }

        public bool Checked
        {
            get => myTShape.Checked;
            set => myTShape.OnlyFriendsChecked(value);
        }

        public bool Orientable
        {
            get => myTShape.Orientable;
            set => myTShape.OnlyFriendsOrientable(value);
        }

        public bool Closed
        {
            get => myTShape.Closed;
            set => myTShape.OnlyFriendsClosed(value);
        }

        public bool Infinite
        {
            get => myTShape.Infinite;
            set => myTShape.OnlyFriendsInfinite(value);
        }

        public bool Convex
        {
            get => myTShape.Convex;
            set => myTShape.OnlyFriendsConvex(value);
        }

        public void Move(TopLoc_Location thePosition)
        {
            myLocation = thePosition;
        }

        public TopoDS_Shape Moved(TopLoc_Location thePosition)
        {
            var aShape = new TopoDS_Shape(this);
            aShape.Move(thePosition);
            return aShape;
        }

        public void Reverse()
        {
            myOrient = TopAbs.Reverse(myOrient);
        }

        public TopoDS_Shape Reversed()
        {
            var aShape = new TopoDS_Shape(this);
            aShape.Reverse();
            return aShape;
        }

        public void Complement()
        {
            myOrient = TopAbs.Complement(myOrient);
        }

        public TopoDS_Shape Complemented()
        {
            var aShape = new TopoDS_Shape(this);
            aShape.Complement();
            return aShape;
        }

        public void Compose(TopAbs_Orientation theOrient)
        {
            myOrient = TopAbs.Compose(myOrient,theOrient);
        }

        public TopoDS_Shape Composed(TopAbs_Orientation theOrient)
        {
            var aShape = new TopoDS_Shape(this);
            aShape.Compose(theOrient);
            return aShape;
        }

        public int NbChildren()
        {
            return myTShape?.NbChildren() ?? 0;
        }

        public bool IsPartner(TopoDS_Shape theOther)
        {
            return myTShape.Equals(theOther.myTShape);
        }

        public bool IsSame(TopoDS_Shape theOther)
        {
            return myTShape.Equals(theOther.myTShape) && myLocation.Equals(theOther.Location);
        }

        public bool IsEqual(TopoDS_Shape theOther)
        {
            return myTShape.Equals(theOther.myTShape) &&
                   myLocation.Equals(theOther.Location) &&
                   myOrient.Equals(theOther.myOrient);
        }

        public bool IsNotEqual(TopoDS_Shape theOther)
        {
            return !IsEqual(theOther);
        }

        public void EmptyCopy<T>() where T : TopoDS_TShape, new()
        {
           myTShape = myTShape.EmptyCopy<T>();
        }

        public TopoDS_Shape EmptyCopied<T>() where T: TopoDS_TShape, new()
        {
            var aShape = new TopoDS_Shape(this);
            aShape.EmptyCopy<T>();
            return aShape;
        }

        public void TShape(TopoDS_TShape theTShape)
        {
            myTShape = theTShape;
        }

        public int HashCode(TopoDS_Shape theShape, int theUpperBound)
        {
            //TODO: is custom hashcode logic necessary?
            throw new NotImplementedException();
        }

        public void DumpJson(Standard_OStream stream, int theDepth = -1)
        {
            using (stream)
            {
                using (var writer = new StreamWriter(stream))
                {
                    writer.Write(JsonSerializer.Serialize(this,new JsonSerializerOptions()
                    {
                        MaxDepth = theDepth
                    }));
                }
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
                return true;
            if (obj is TopoDS_Shape aShape)
                return myTShape.Equals(aShape.myTShape) &&
                       myLocation.Equals(aShape.myLocation) &&
                       myOrient.Equals(aShape.myOrient);
            return false;
        }

        public override int GetHashCode()
        {
            return System.HashCode.Combine(myTShape.GetHashCode(), myLocation.GetHashCode(), myOrient.GetHashCode());
        }
    }
}