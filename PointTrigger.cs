using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTrigger : MonoBehaviour
{
	void OnTriggerEnter(Collider collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			collision.gameObject.GetComponent<Points>().ApplyPoint(1);
		}
	}

}
