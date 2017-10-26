using UnityEngine;
using System.Collections;

public class BulletGenerator : MonoBehaviour {

    public GameObject bulletPrefab;

	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(bulletPrefab) as GameObject;
            Destroy(bullet, 1.0f);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            bullet.GetComponent<BulletController>().Shoot(worldDir.normalized * 2000);
        }
	}
}
