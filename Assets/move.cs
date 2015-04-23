using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	public float speed = 10;
	public string axis = "Vertical";
	void FixedUpdate () {
			float v = Input.GetAxisRaw ("Vertical");
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (1, v);
		}

}
