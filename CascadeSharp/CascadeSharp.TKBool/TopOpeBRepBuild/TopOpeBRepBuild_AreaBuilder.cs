//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.TopAbs;

namespace CascadeSharp.TKBool.TopOpeBRepBuild
{
    //---------------------------------------------------------------------
    //  Class  TopOpeBRepBuild_AreaBuilder
    //---------------------------------------------------------------------
    public class TopOpeBRepBuild_AreaBuilder
    {
        public TopOpeBRepBuild_AreaBuilder()
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepBuild_AreaBuilder(TopOpeBRepBuild_LoopSet LS, TopOpeBRepBuild_LoopClassifier LC,
            bool ForceClass)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepBuild_AreaBuilder(TopOpeBRepBuild_LoopSet LS, TopOpeBRepBuild_LoopClassifier LC)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepBuild_AreaBuilder(TopOpeBRepBuild_AreaBuilder parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void InitAreaBuilder(TopOpeBRepBuild_LoopSet LS, TopOpeBRepBuild_LoopClassifier LC, bool ForceClass)
        {
            throw new NotImplementedException();
        }

        public void InitAreaBuilder(TopOpeBRepBuild_LoopSet LS, TopOpeBRepBuild_LoopClassifier LC)
        {
            throw new NotImplementedException();
        }

        public int InitArea()
        {
            throw new NotImplementedException();
        }

        public bool MoreArea()
        {
            throw new NotImplementedException();
        }

        public void NextArea()
        {
            throw new NotImplementedException();
        }

        public int InitLoop()
        {
            throw new NotImplementedException();
        }

        public bool MoreLoop()
        {
            throw new NotImplementedException();
        }

        public void NextLoop()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepBuild_Loop Loop()
        {
            throw new NotImplementedException();
        }

        public void ADD_Loop_TO_LISTOFLoop(TopOpeBRepBuild_Loop L, TopOpeBRepBuild_ListOfLoop LOL, IntPtr s)
        {
            throw new NotImplementedException();
        }

        public void ADD_Loop_TO_LISTOFLoop(TopOpeBRepBuild_Loop L, TopOpeBRepBuild_ListOfLoop LOL)
        {
            throw new NotImplementedException();
        }

        public void ADD_LISTOFLoop_TO_LISTOFLoop(TopOpeBRepBuild_ListOfLoop LOL1, TopOpeBRepBuild_ListOfLoop LOL2,
            IntPtr s, IntPtr s1, IntPtr s2)
        {
            throw new NotImplementedException();
        }

        public void ADD_LISTOFLoop_TO_LISTOFLoop(TopOpeBRepBuild_ListOfLoop LOL1, TopOpeBRepBuild_ListOfLoop LOL2,
            IntPtr s, IntPtr s1)
        {
            throw new NotImplementedException();
        }

        public void ADD_LISTOFLoop_TO_LISTOFLoop(TopOpeBRepBuild_ListOfLoop LOL1, TopOpeBRepBuild_ListOfLoop LOL2,
            IntPtr s)
        {
            throw new NotImplementedException();
        }

        public void ADD_LISTOFLoop_TO_LISTOFLoop(TopOpeBRepBuild_ListOfLoop LOL1, TopOpeBRepBuild_ListOfLoop LOL2)
        {
            throw new NotImplementedException();
        }

        public TopAbs_State CompareLoopWithListOfLoop(TopOpeBRepBuild_LoopClassifier LC, TopOpeBRepBuild_Loop L,
            TopOpeBRepBuild_ListOfLoop LOL, TopOpeBRepBuild_LoopEnum le)
        {
            throw new NotImplementedException();
        }

        public void Atomize(ref TopAbs_State state, TopAbs_State newstate)
        {
            throw new NotImplementedException();
        }
    }; // class TopOpeBRepBuild_AreaBuilder
}