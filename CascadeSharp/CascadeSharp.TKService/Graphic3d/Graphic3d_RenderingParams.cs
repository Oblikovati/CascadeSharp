//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Graphic3d_RenderingParams
	//---------------------------------------------------------------------
	public  sealed class Graphic3d_RenderingParams
	{

		public Graphic3d_RenderingParams()
			: base()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_RenderingParams(Graphic3d_RenderingParams parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public float ResolutionRatio()
		{
			throw new NotImplementedException();
		}

				
		//---------------------------------------------------------------------
		//  Enum  Anaglyph
		//---------------------------------------------------------------------
		public		enum Anaglyph
		{
			Anaglyph_RedCyan_Simple = 0,
			Anaglyph_RedCyan_Optimized = 1,
			Anaglyph_YellowBlue_Simple = 2,
			Anaglyph_YellowBlue_Optimized = 3,
			Anaglyph_GreenMagenta_Simple = 4,
			Anaglyph_UserDefined = 5
		} // enum  class Anaglyph

		//---------------------------------------------------------------------
		//  Enum  PerfCounters
		//---------------------------------------------------------------------
		public		enum PerfCounters
		{
			PerfCounters_NONE = 0,
			PerfCounters_FrameRate = 1,
			PerfCounters_CPU = 2,
			PerfCounters_Layers = 4,
			PerfCounters_Structures = 8,
			PerfCounters_Groups = 16,
			PerfCounters_GroupArrays = 32,
			PerfCounters_Triangles = 64,
			PerfCounters_Points = 128,
			PerfCounters_Lines = 256,
			PerfCounters_EstimMem = 512,
			PerfCounters_FrameTime = 1024,
			PerfCounters_FrameTimeMax = 2048,
			PerfCounters_SkipImmediate = 4096,
			PerfCounters_Basic = 15,
			PerfCounters_Extended = 1023,
			PerfCounters_All = 4095
		} // enum  class PerfCounters

		//---------------------------------------------------------------------
		//  Enum  FrustumCulling
		//---------------------------------------------------------------------
		public		enum FrustumCulling
		{
			FrustumCulling_Off = 0,
			FrustumCulling_On = 1,
			FrustumCulling_NoUpdate = 2
		} // enum  class FrustumCulling

	}; // class Graphic3d_RenderingParams

}
