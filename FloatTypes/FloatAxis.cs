﻿using ArtisanDream.Tools.Objects;
using UnityEngine;

namespace ArtisanDream.Experimental.FloatTypes
{
	[CreateAssetMenu]
	public class FloatAxis : FloatData
	{
		public string Axis = "Horizontal";
	
		public override float Value
		{
			get
			{
				return value*Input.GetAxis(Axis); 
			}
		}
	}
}