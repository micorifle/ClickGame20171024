using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Ball")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
