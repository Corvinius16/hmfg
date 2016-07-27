using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Enemy : MonoBehaviour {
	GameController GC;
	Sprite Visible;
	public enum VisibleObject
	{
		visible,
		unvisible,

	}
	public VisibleObject nowVisible=VisibleObject.unvisible;
	//public Sprite InVisible;
	void Awake()
	{
	}
	// Use this for initialization
	void Start () {
		if(nowVisible==VisibleObject.unvisible)
			GameController.DeadEvent += Fail;
		if (this.gameObject.GetComponent<SpriteRenderer> ()) {
			if (nowVisible == VisibleObject.unvisible) {
				Visible = this.gameObject.GetComponent<SpriteRenderer> ().sprite;
				GC = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = null;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Fail()
	{
		StartCoroutine (time ());
	}

	public void OnCollisionStay2D(Collision2D _other)
	{
		if(GameController.take)
		GameController.DeadEvent();
	}
	public void OnCollisionEnter2D(Collision2D _other)
	{
		if(GameController.take)
			GameController.DeadEvent();
	}

	IEnumerator time()
	{
		if (this.gameObject.GetComponent<SpriteRenderer> ()) {
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = Visible;
			yield return new WaitForSeconds (1);
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = null;
		}
	}

}
