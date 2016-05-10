using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public float paddleSpeed =1 ;
	public Vector3 PlayerPos;

	void Update () {
	
		float yPos = gameObject.transform.position.y + (Input.GetAxis("Vertical")*paddleSpeed);
		PlayerPos = new Vector3 (-59, Mathf.Clamp(yPos,-22,22),0);
		gameObject.transform.position = PlayerPos;


	}
}
