using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using GoogleARCore.Examples.Common;

public class CameraScript : MonoBehaviour {
	public Camera firstPersonCamera;
//	public GameObject DetectedPlanePrefab;
	public GameObject AnchorPlanePrefab;
	public GameObject AnchorPointPrefab;
	private const float k_ModelRotation = 180.0f;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		_update ();
	}

	public bool IsNotValidTouch(int touchCount, TouchPhase phase)
	{
		return touchCount < 1 || phase != TouchPhase.Began;
	}

	// Detect if user touches screen
		// if not do nothing

	// 


	private void _update() {
		// If the player has not touched the screen, we are done with this update.
//		Touch touch;
//		if (Input.touchCount < 1 || (touch = Input.GetTouch(0)).phase != TouchPhase.Began)
//		{
			return;
//		}
//
//		// Should not handle input if the player is pointing on UI.
//		if (EventSystem.current.IsPointerOverGameObject(touch.fingerId))
//		{
//			return;
//		}
//
//		// Raycast against the location the player touched to search for planes.
//		TrackableHit hit;
//		TrackableHitFlags raycastFilter = TrackableHitFlags.PlaneWithinPolygon |
//			TrackableHitFlags.FeaturePointWithSurfaceNormal;
//
//		if (Frame.Raycast(touch.position.x, touch.position.y, raycastFilter, out hit))
//		{
//			// Use hit pose and camera pose to check if hittest is from the
//			// back of the plane, if it is, no need to create the anchor.
//			if ((hit.Trackable is DetectedPlane) &&
//				Vector3.Dot(FirstPersonCamera.transform.position - hit.Pose.position,
//					hit.Pose.rotation * Vector3.up) < 0)
//			{
//				Debug.Log("Hit at back of the current DetectedPlane");
//			}
//			else
//			{
//				// Choose the Andy model for the Trackable that got hit.
//				GameObject prefab;
//				if (hit.Trackable is FeaturePoint)
//				{
//					prefab = AnchorPointPrefab;
//				}
//				else
//				{
//					prefab = AnchorPlanePrefab;
//				}
//
//				// Instantiate Andy model at the hit pose.
//				var andyObject = Instantiate(prefab, hit.Pose.position, hit.Pose.rotation);
//
//				// Compensate for the hitPose rotation facing away from the raycast (i.e.
//				// camera).
//				andyObject.transform.Rotate(0, k_ModelRotation, 0, Space.Self);
//
//				// Create an anchor to allow ARCore to track the hitpoint as understanding of
//				// the physical world evolves.
//				var anchor = hit.Trackable.CreateAnchor(hit.Pose);
//				// Make Andy model a child of the anchor.
//				andyObject.transform.parent = anchor.transform;
//			}
//		}
	}
}
