using NUnit.Framework;
using UnityEngine;

namespace Editor
{
	public class CameraSceneTest {

		[Test]
		public void GivenTouchCountIsZeroAndInvalidTouchPhaseShouldReturnTrue()
		{
			var gameObject = new GameObject();
			var script = gameObject.AddComponent<CameraScript>();
			var touched = script.IsNotValidTouch (0, TouchPhase.Ended);
			Assert.True(touched);
		}

		[Test]
		public void GivenTouchCountIsZeroAndValidTouchPhaseShouldReturnTrue()
		{
			var gameObject = new GameObject();
			var script = gameObject.AddComponent<CameraScript>();
			var touched = script.IsNotValidTouch (0, TouchPhase.Began);
			Assert.True(touched);
		}
		
		[Test]
		public void GivenTouchCountGreaterThanZeroAndInvalidTouchPhaseShouldReturnTrue()
		{
			var gameObject = new GameObject();
			var script = gameObject.AddComponent<CameraScript>();
			var touched = script.IsNotValidTouch (1, TouchPhase.Ended);
			Assert.True(touched);
		}

		[Test]
		public void GivenTouchCountGreaterThanZeroAndValidTouchPhaseShouldReturnFalse()
		{
			var gameObject = new GameObject();
			var script = gameObject.AddComponent<CameraScript>();
			var touched = script.IsNotValidTouch(1, TouchPhase.Began);
			Assert.False(touched);
		}
	}
}
