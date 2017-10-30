using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBehaviour : MonoBehaviour
{
	public float speed;
	public float turningSpeed;
	public List<Transform> targets;
	public float range = 10f;

	Transform gun = null;

	void Start()
	{
		gun = transform.Find("Turret");
	}

	void Update()
	{
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
		foreach (Transform target in targets)
		{
			if ((target.position - transform.position).sqrMagnitude < range)
				shoot(target);
		}
	}

	void shoot(Transform target)
	{
		gun.LookAt(target);


		//// Shot
		//if (lastShotTime > shotRate)
		//{
		//	lastShotTime = Random.Range(-1.5f, 0f);
		//	bullet = Instantiate(bullet);
		//	bullet.GetComponent<Bullet>().setEnemyTag("Player");
		//	bullet.GetComponent<Bullet>().speed = 0.5f;
		//	bullet.transform.position = transform.position + gun.forward * 0.1f;
		//	bullet.GetComponent<Bullet>().setDirection(gun.forward);
		//}

		//lastShotTime += Time.deltaTime;


	}
}