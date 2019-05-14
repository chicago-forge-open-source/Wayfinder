using UnityEngine;
using Mapbox.Utils;
using Mapbox.Unity.Map;
using Mapbox.Unity.MeshGeneration.Factories;
using Mapbox.Unity.Utilities;
using System.Collections.Generic;

public class CameraScript : MonoBehaviour {
	void Start()
	{
	}
	
	// Update is called once per frame
	private void Update()
	{
	}

	public bool IsNotValidTouch(int touchCount, TouchPhase phase)
	{
		return touchCount < 1 || phase != TouchPhase.Began;
	}
}