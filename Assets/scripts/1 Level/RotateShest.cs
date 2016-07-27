using UnityEngine;
using System.Collections;

public class RotateShest : MonoBehaviour {
	public float speed = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate (0, 0, 1*Time.deltaTime*speed);
	}
}
