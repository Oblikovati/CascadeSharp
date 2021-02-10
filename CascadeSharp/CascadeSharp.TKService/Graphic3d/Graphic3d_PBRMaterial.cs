//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.Quantity;
using CascadeSharp.TKService.Image;

namespace CascadeSharp.TKService.Graphic3d
{
	//---------------------------------------------------------------------
	//  Class  Graphic3d_PBRMaterial
	//---------------------------------------------------------------------
	public  sealed class Graphic3d_PBRMaterial
	{

		public Graphic3d_PBRMaterial()
			: base()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_PBRMaterial(Graphic3d_BSDF theBSDF)
			: base()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_PBRMaterial(Graphic3d_PBRMaterial parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public float Metallic()
		{
			throw new NotImplementedException();
		}

		public void SetMetallic(float theMetallic)
		{
			throw new NotImplementedException();
		}

		public float Roughness(float theNormalizedRoughness)
		{
			throw new NotImplementedException();
		}

		public float Roughness()
		{
			throw new NotImplementedException();
		}

		public float NormalizedRoughness()
		{
			throw new NotImplementedException();
		}

		public void SetRoughness(float theRoughness)
		{
			throw new NotImplementedException();
		}

		public float IOR()
		{
			throw new NotImplementedException();
		}

		public void SetIOR(float theIOR)
		{
			throw new NotImplementedException();
		}

		public Quantity_ColorRGBA Color()
		{
			throw new NotImplementedException();
		}

		public void SetColor(Quantity_ColorRGBA theColor)
		{
			throw new NotImplementedException();
		}

		public void SetColor(Quantity_Color theColor)
		{
			throw new NotImplementedException();
		}

		public float Alpha()
		{
			throw new NotImplementedException();
		}

		public void SetAlpha(float theAlpha)
		{
			throw new NotImplementedException();
		}

						public void SetBSDF(Graphic3d_BSDF theBSDF)
		{
			throw new NotImplementedException();
		}

		public void GenerateEnvLUT(Image_PixMap theLUT, uint theNbIntegralSamples)
		{
			throw new NotImplementedException();
		}

		public void GenerateEnvLUT(Image_PixMap theLUT)
		{
			throw new NotImplementedException();
		}

		public float RoughnessFromSpecular(Quantity_Color theSpecular, double theShiness)
		{
			throw new NotImplementedException();
		}

		public float MetallicFromSpecular(Quantity_Color theSpecular)
		{
			throw new NotImplementedException();
		}

		public float MinRoughness()
		{
			throw new NotImplementedException();
		}

		public float SpecIBLMapSamplesFactor(float theProbability, float theRoughness)
		{
			throw new NotImplementedException();
		}

						public float lutGenGeometryFactor(float theCosL, float theCosV, float theRoughness)
		{
			throw new NotImplementedException();
		}

		public Graphic3d_Vec2 lutGenHammersley(uint theNumber, uint theCount)
		{
			throw new NotImplementedException();
		}

		public float lutGenImportanceSampleCosTheta(float theHammerslayPointComponent, float theRoughness)
		{
			throw new NotImplementedException();
		}

						
	}; // class Graphic3d_PBRMaterial

}
