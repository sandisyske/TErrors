using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstspirit : MonoBehaviour
{
    public float speed;
    public int damage;
    public float timeToLive = 1.5f;

    void Start()
    {
        Destroy(gameObject, timeToLive);
    }
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Explode();
        Destroy(gameObject);
    }

    public void Explode() 
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, 10);
        foreach (Collider nearbyObject in colliders) 
        {
            Enemy enemyscript = nearbyObject.gameObject.GetComponent<Enemy>();
            if (enemyscript != null)
            {
                enemyscript.TakeDamage(damage);
            }
        }
    }
}
