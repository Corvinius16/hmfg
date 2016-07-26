using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
public class Teleport : MonoBehaviour,IPointerEnterHandler {
	public GameObject Spawn;
	public EventSystem eventSystem;
	public GameObject Player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnPointerEnter(PointerEventData eventData)
	{
		Player.transform.position = Spawn.transform.position;
		eventSystem.gameObject.SetActive (false);
		eventSystem.gameObject.SetActive (true);
		GameController.take = false;
	}
}
