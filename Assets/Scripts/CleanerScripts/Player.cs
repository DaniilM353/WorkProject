using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Player : MonoBehaviour
{
	public Transform stick;
	public Transform helper;
	public float range = 30f;
	public float speed = 500f;
	public float power = 20f;

	private bool m_isDown = false;
	private Vector3 m_lastPosition;

	private void Update()
	{
		m_lastPosition = helper.position;
		
		

	}

	public void SetDown(bool value)
	{ 
		m_isDown = value;
		GetComponent<Animator>().SetFloat("Speed Multiplier", 1);
		GetComponent<Animator>().Play("Golf");
		Debug.Log("Down");
	}

	public void SetUp(bool value)
	{ 
		m_isDown = value;
		GetComponent<Animator>().SetFloat("Speed Multiplier", -1);
		GetComponent<Animator>().Play("Golf");
		Debug.Log("Up");
	}
	
	public void OnCollisionStick(Collider collider)
	{
		Debug.Log(collider);
		if (collider.TryGetComponent(out Rigidbody body))
		{
			Debug.Log(body);
			var dir = (helper.position - m_lastPosition).normalized;
			body.AddForce(dir * power, ForceMode.Impulse);

			if (collider.TryGetComponent(out Stone stone))
			{
				stone.isAffect = true;
				GameEvent.StickHit();
			}
		}
	}
}
