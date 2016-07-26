using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PanelFinish : MonoBehaviour {
	public Image FirstStar;
	public Image SecondStar;
	public Image ThirdStar;

	public Sprite Win;
	public Sprite Lose;
	public GameController GC;
	// Use this for initialization
	void Start () {
	//	GC = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
		WinOrLose ();
	}
	public void WinOrLose()
	{
		FirstStar.sprite = Lose;
		SecondStar.sprite = Lose;
		ThirdStar.sprite = Lose;
		if (GC.Star == 3) {
			FirstStar.sprite = Win;
			SecondStar.sprite = Win;
			ThirdStar.sprite = Win;
		} else if (GC.Star == 2) {
			FirstStar.sprite = Win;
			SecondStar.sprite = Win;
		} else if (GC.Star == 1) {
			FirstStar.sprite = Win;
		}
	}
}
