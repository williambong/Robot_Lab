using UnityEngine;
using System.Collections;

public class AddForceMouseDown : MonoBehaviour {

    void OnMouseDown()
    {
        rigidbody.AddForce(-transform.forward * 500, ForceMode.Acceleration);
        rigidbody.useGravity = true;
    }
}
