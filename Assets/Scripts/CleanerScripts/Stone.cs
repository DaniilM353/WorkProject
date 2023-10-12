using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
	public static System.Action onCollisionStone;
	
	public bool isAffect = false;

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.transform.TryGetComponent(out Stone other))
		{
			if (!other.isAffect)
			{
				onCollisionStone?.Invoke();
			}
		}
	}
}
