using UnityEngine;
using System.Collections;

public class Star : MonoBehaviour {
	GameController GameController;
	void Awake()
	{

	}
	// Use this for initialization
	void Start () {
		GameController.DeadEvent += Reset;
		GameController = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnCollisionEnter2D(Collision2D _other)
	{
		GameController.Star += 1;
		this.gameObject.SetActive (false);
	}
	public void Reset()
	{
		this.gameObject.SetActive (true);
		GameController.Star = 0;
	}
}
