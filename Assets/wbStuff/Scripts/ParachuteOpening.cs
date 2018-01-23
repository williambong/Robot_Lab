using UnityEngine;
using System.Collections;

public class ParachuteOpening : MonoBehaviour {

    public GameObject parachute;
    public float parachuteEffectiveness;
    public float deploymentHeight;

    private bool deployed;

    void Update()
    {
        RaycastHit hit;
        Ray landingRay = new Ray(transform.position, Vector3.down);
        Debug.DrawRay(transform.position, Vector3.down * deploymentHeight);

        if (!deployed)
        {
            if (Physics.Raycast(landingRay, out hit, deploymentHeight))
            {
                if (hit.collider.tag == "environment")
                {
                    DeployParachute();
                }
            }
        }
    }

    void DeployParachute()
    {
        deployed = true;
        animation.Play("openChute");
    }

    void onCollisionEnter()
    {
        animation.Play("closeChute");
    }
}
