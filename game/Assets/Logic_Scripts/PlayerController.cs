using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float speed;
	public Transform weapon;
	public float offset;
	public int health;
	public Transform shotPoint;
	public GameObject projectile;
	public float timeBetweenShots;
	float nextShotTime;
	Spirits[] allspirits;
	public GameObject Ghost;
	void Start()
	{
        Ghost.AddComponent<firstspirit>();
		Spirit1.Instantiate(Ghost);
        
        //gameObject.AddComponent<Spirit2>(Ghost2);
        //gameObject.AddComponent<Spirit3>(Ghost3);
        allspirits = GetComponentsInChildren<Spirits>();

	}
	void Update()
	{
		Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"),0);
		transform.position += playerInput.normalized*speed*Time.deltaTime;
		//WeaponRotation
		Vector3 displacement = weapon.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
		float angle = Mathf.Atan2(displacement.y,displacement.x) * Mathf.Rad2Deg;
		weapon.rotation = Quaternion.Euler(0f,0f,angle + offset);
		//Tulistamine
		if (Input.GetMouseButtonDown(0))
		{
			if (Time.time > nextShotTime)
			{
				nextShotTime = Time.time + timeBetweenShots;
				Instantiate(projectile, shotPoint.position, shotPoint.rotation);
			}
		}
		foreach (Spirits spirit in allspirits) 
		{
			//if (Input.GetKey(.nupp) ; jäi pooleli

        }
	
	}
}
