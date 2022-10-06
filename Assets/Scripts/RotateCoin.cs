using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin : MonoBehaviour
{
	[SerializeField] private float rotateSpeed = 3f;
	private void Update()
	{
		transform.Rotate(new Vector3(0, 90, 0) * rotateSpeed
			* Time.deltaTime);
	}
}
