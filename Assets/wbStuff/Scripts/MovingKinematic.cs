using UnityEngine;
using System.Collections;

public class MovingKinematic : MonoBehaviour {

    void Update()
    {
        transform.Translate(transform.forward * 2 * Time.deltaTime);
    }
}
