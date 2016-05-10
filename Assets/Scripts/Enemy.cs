using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float speed = 0;
	Vector3 targetPos;
	GameObject ballObj;



	void Update () {
	
		ballObj = GameObject.FindGameObjectWithTag ("Ball");
		if (ballObj != null) {
			targetPos = Vector3.Lerp (gameObject.transform.position, ballObj.transform.position, Time.deltaTime * speed);
			gameObject.transform.position = new Vector3 (61, targetPos.y, 0);
		}
	}
}
