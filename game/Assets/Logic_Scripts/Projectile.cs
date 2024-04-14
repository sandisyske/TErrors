using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Projectile : MonoBehaviour
{
	public float speed;
	public int damage;
	public float timeToLive = 5f;
	void Start()
	{
        Destroy(gameObject, timeToLive);
    }
	void Update()
	{
		transform.Translate(Vector3.up * speed * Time.deltaTime);

	}
}
