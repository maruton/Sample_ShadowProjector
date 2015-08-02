/*
 *	@file	cs_ShadowProjector
 *	@note		None 
 *	@attention	
 *				[cs_ShadowProjector.cs]
 *				Copyright (c) [2015] [Maruton]
 *				This software is released under the MIT License.
 *				http://opensource.org/licenses/mit-license.php
 */
using UnityEngine;
using System.Collections;

public class cs_ShadowProjector : MonoBehaviour {
	Quaternion ShadowRot = Quaternion.Euler(270, 90, 0);	//!< Upright Degree of Shadow Projector(this). 
	Vector3 Distance;										//!< Distance of Shadow Projector(this). 
	Transform FakeCastObject;								//!< Fake cast shadow object. 

	void Start () {
		FakeCastObject = transform.parent.transform;	//Get Transform of Parent object.
		Distance = transform.localPosition;				//Get distance of parent to Shadow Projector(this).
	}
	
	void Update () {
		transform.rotation = ShadowRot;							//Keep upright degree.
		transform.position = FakeCastObject.position + Distance; //Keep distance from parent.(Important: Must be parent's scale <1,1,1>). 
	}
}
