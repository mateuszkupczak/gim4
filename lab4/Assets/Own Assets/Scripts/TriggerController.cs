using UnityEngine;
using UnityEngine.UI;

public class TriggerController : MonoBehaviour
{
    // Handle some proper animation when the player touches it.
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().CompareTag("Player") && GetComponent<ConstantForce>().torque == new Vector3(0, 0, 0))
        {
            GetComponent<ConstantForce>().torque = new Vector3(20, 0, 0);
        }
    }
}
