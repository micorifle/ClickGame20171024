using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {

    public GameObject bulletPrefab;

	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(bulletPrefab) as GameObject;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            bullet.GetComponent<Controller>().Shoot(worldDir.normalized * 20000);
        }
	}
}
