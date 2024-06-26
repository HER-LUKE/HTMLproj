using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float range = 5f;
    public float fireRate = 1f;
    private float fireCountdown = 0f;

    void Update()
    {
        fireCountdown -= Time.deltaTime;
        if (fireCountdown <= 0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate;
        }
    }

    void Shoot()
    {
        // Instantiate projectile and set its direction
        GameObject projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);
        // Set projectile target or direction here
    }
}
