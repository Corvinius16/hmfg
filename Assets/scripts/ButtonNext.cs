using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ButtonNext : MonoBehaviour {
	GameController GC;
	Singleton singl;
	void Start () {
		singl = GameObject.FindGameObjectWithTag ("Singleton").GetComponent<Singleton>();
		GC = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController>();
		singl.Level += 1;
		this.gameObject.GetComponent<Button> ().onClick.AddListener(()=>GC.loadScene(singl.Level));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
