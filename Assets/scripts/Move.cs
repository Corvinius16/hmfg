using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
public class Move : MonoBehaviour{
	public GameObject Spawn;
	public GameObject Gc;
	public bool reset=true;
	public bool click;

	public AudioClip clip;

	void Awake()
	{
	}
	void Start()
	{
		GameController.DeadEvent += Restart;
	}
	void FixedUpdate () {
		if (click) {
			if (Input.touches.Length > 0) {
				if (Input.touches [0].phase == TouchPhase.Ended) {
					reset = false;
					click = false;
				}
				if (Input.touches [0].phase == TouchPhase.Began) {
					reset = true;
				}
				if (Gc.GetComponent<GameController> ().move && reset) {
					Vector3 MousePos = Input.touches [0].position;
					MousePos = Camera.main.ScreenToWorldPoint (MousePos);
					this.transform.position = new Vector3 (MousePos.x, MousePos.y, 0);
					GameController.take = true;
				}
			}
		}
	}

	#if UNITY_EDITOR
		public void OnMouseDrag()
		{
		if (Gc.GetComponent<GameController> ().move&&reset) {
			
			Vector3 MousePos=Input.mousePosition;
			MousePos = Camera.main.ScreenToWorldPoint(MousePos);
			this.transform.position = new Vector3 (MousePos.x, MousePos.y, 0);
			GameController.take = true;
		}
		}
	#endif
//	public void OnPointerEnter(PointerEventData eventData)
//	{
//		click = true;
//	}
	public void OnMouseDown()
	{
		if (Gc.GetComponent<GameController> ().move) {
			click = true;
			reset = true;
			AudioSource.PlayClipAtPoint (clip, this.transform.position);
		}
		//this.gameObject.GetComponent<CircleCollider2D> ().radius = 0.26f;	
	}
	public void OnMouseUp()
	{
		reset= false;
	}


	void Restart()
	{
		this.transform.position = Spawn.transform.position;
		GameController.take = false;
		reset = false;
	}
	public void Exit()
	{
		GameController.take = false;
	}
}
