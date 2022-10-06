using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroTest : MonoBehaviour
{
    public bool isFlat = true;
    public GameObject player;
    private void Start()
    {
        Input.gyro.enabled = true;
    }

    private void Update()
    {
        player.transform.Rotate(0, Input.gyro.rotationRateUnbiased.y * 3, 0);
        //Vector3 tilt = Input.acceleration;

        // if (isFlat)
        //     tilt = Quaternion.LookRotation(Vector3.left) * tilt;
        // rb.AddForce(tilt);

        // Debug.DrawRay(transform.position + Vector3.up, tilt, Color.cyan);
    }
}
