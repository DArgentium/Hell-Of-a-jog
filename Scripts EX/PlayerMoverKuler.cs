using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoverKuler : MonoBehaviour
{
	public float Mangitude = 5.0f;

	private Rigidbody _rigidbody;
	private Vector3 _direction;

	void Start()
	{
		// genericko programiranje
		_rigidbody = GetComponent<Rigidbody>();
		// null = ne postoji = nistica (THE VOID)
		if(_rigidbody == null)
		{
			Debug.LogError("Rigidbody component missing.");
		}
	}

	void Update()
	{
		float horizontalAxis = Input.GetAxisRaw("Horizontal");
		float verticalAxis = Input.GetAxisRaw("Vertical");

		_direction = new Vector3(horizontalAxis, 0.0f, verticalAxis);
		_direction.Normalize(); //bitna linija, ponoviti jedinicne vektore

		//transform.position += direction * Speed * Time.deltaTime;
	}

	// metoda za izvodenje fizike
	// izovdi svakih 0.02 ms, fiksni takt
	void FixedUpdate()
	{
		_rigidbody.AddForce(_direction * Mangitude);
	}
}
