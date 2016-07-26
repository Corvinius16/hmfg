using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour {
	Singleton singl;
	GameController gameController;
	public GameObject panelFinish;
	// Use this for initialization
	void Start () {
		singl = GameObject.FindGameObjectWithTag ("Singleton").GetComponent<Singleton> ();
		gameController = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
	}
	public void OnCollisionEnter2D(Collision2D _other)
	{
		panelFinish.SetActive (true);
		panelFinish.GetComponent<PanelFinish> ().WinOrLose ();
		try
		{
			if(PlayerPrefs.GetInt("level"+singl.Level)<gameController.Star)
			{
				PlayerPrefs.SetInt("level"+singl.Level,gameController.Star);
			}

		}
		catch{
			PlayerPrefs.SetInt("level"+singl.Level,gameController.Star);
		}
	}
}
