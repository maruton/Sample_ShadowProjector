﻿/*
 *	@file	cs_MoveHeadtoPath     s_ShadowProjector s_ShadowProjector s_ShadowProjector s_ShadowProjector cs_MoveHeadtoPathcs_MoveHeadtoPathcs_MoveHeadtoPathcs_MoveHeadtoPathcs_MoveHeadtoPathcs_MoveHeadtoPathcs_MoveHeadtoPathcs_MoveHeadtoPath
 *	@note		None 
 *	@attention	
 *				[cs_MoveHeadtoPath.cs]
 *				Copyright (c) [2015] [Maruton]
 *				This software is released under the MIT License.
 *				http://opensource.org/licenses/mit-license.php
 */
using UnityEngine;
using System.Collections;

public class cs_MoveHeadtoPath : MonoBehaviour {
	string pathName = "MyPath";	//!< Move path name (iTween Visual Editor).
	float pathTime = 18.0f;		//!< Move speed.
	Hashtable table = new Hashtable();
	void SetupPath(){
		table.Add( "path", iTweenPath.GetPath(pathName) );//ITween path hash data
		table.Add( "time", pathTime );
		table.Add( "easetype", iTween.EaseType.easeInOutSine );
		table.Add( "oncomplete", "cb_iTweenComplete" ); //Callback Handler when iTween end
		table.Add( "oncompleteparams", "Complete" ); 	//parameter of Handler func when iTween end
		table.Add( "orienttopath", true ); 				//Head to forwarding vector
		table.Add( "lookTime", 1.0f ); 					//Time value for heading nose
	
		iTween.MoveTo(gameObject, table);
	}
	void cb_iTweenComplete(string param){
		Debug.Log("[iTween] cb_iTweenComplete: "+param);
		iTween.MoveTo(gameObject, table);//Restart iTween.
	}
	
	void Start () {
		SetupPath();
	}
}
