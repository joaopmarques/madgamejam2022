using UnityEngine;
using System.Collections;

public class ProjectileShoot : MonoBehaviour
{

  public Camera cam;
  public GameObject projectile;
  public Transform firePoint;
  public float projectileSpeed = 33.0f;
  public float fireRate = 3.5f;
  public float arcRange = 1.3f;

  private float timeToFire;
  private Vector3 destination;

  void Update()
  {
    if (Input.GetButton("Fire1") && Time.time >= timeToFire)
    {
      timeToFire = Time.time + 1 / fireRate;
      ShootProjectile();
    }
  }

  void ShootProjectile()
  {
    Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
    RaycastHit hit;


    if (Physics.Raycast(ray, out hit))
    {
      destination = hit.point;
    }
    else
    {
      destination = ray.GetPoint(1000);
    }
    InstantiateProjectile(firePoint);
  }

  void InstantiateProjectile(Transform firePoint)
  {
    var projectileObj = Instantiate(projectile, firePoint.position, Quaternion.identity) as GameObject;
    projectileObj.GetComponent<Rigidbody>().velocity = (destination - firePoint.position).normalized * projectileSpeed;

    iTween.PunchPosition(projectileObj, new Vector3(Random.Range(-arcRange, arcRange), Random.Range(-arcRange, arcRange), 0), Random.Range(0.5f, 2.0f));
  }
}