using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwnThirdPersonController : MonoBehaviour
{
	public FixedJoystick LeftJoystick;
	public FixedTouchField Touchfield;
	protected Actions Actions;
	protected Rigidbody Rigidbody;


	protected float CameraAngley;
	protected float CameraAngleSpeed = 0.1f;
	protected float CameraPosY;
	protected float CameraPosSpeed = 0.1f;

	[SerializeField] private float cameraYPosition;
	[SerializeField] private float cameraZPosition;
	[SerializeField] private float cameraUpHeight;

	[SerializeField] private float playerSpeed;
	private void Start()
	{
		Actions = GetComponent<Actions>();
		Rigidbody = GetComponent<Rigidbody>();

		LeftJoystick = FindObjectOfType<FixedJoystick>();
		Touchfield = FindObjectOfType<FixedTouchField>();
	}
	private void Update()
	{
		var input = new Vector3(LeftJoystick.input.x, 0, LeftJoystick.input.y);

		var vel = Quaternion.AngleAxis(CameraAngley * 180, Vector3.up) * input * playerSpeed;

		Rigidbody.velocity = new Vector3(vel.x, Rigidbody.velocity.y, vel.z);

		//transform.rotation = Quaternion.AngleAxis(CameraAngley + Vector3.SignedAngle(Vector3.forward, input.normalized + Vector3.forward * 0.001f, Vector3.up), Vector3.up);

		CameraAngley += Touchfield.TouchDist.x * CameraAngleSpeed;

		Camera.main.transform.position = transform.position + Quaternion.AngleAxis(CameraAngley, Vector3.up) * new Vector3(0, cameraYPosition, cameraZPosition);

		Camera.main.transform.rotation = Quaternion.LookRotation(transform.position + Vector3.up * cameraUpHeight - Camera.main.transform.position, Vector3.up);

		if (Rigidbody.velocity.magnitude>3f)
		
			Actions.Run();
		else
			Actions.Stay();
	}
}
