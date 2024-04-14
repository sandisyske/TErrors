﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float speed;
	public Transform weapon;
	public float offset;

	public Transform shotPoint;
	public GameObject projectile;
	public float timeBetweenShots;
	float nextShotTime;
	void Start()
	{

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
	}
}
