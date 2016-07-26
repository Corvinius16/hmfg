using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PanelFinish : MonoBehaviour {
	public Image FirstStar;
	public Image SecondStar;
	public Image ThirdStar;

	public Sprite Win;
	public Sprite Lose;
	GameController GC;
	public Button Menu;
	public Button Restart;
	public Button Next;

	// Use this for initialization
	void Awake()
	{
		GC = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
	}

	void Start () {
		Menu.onClick.AddListener (() => GC.loadScene (0));
		Restart.onClick.AddListener (() => GC.Replay ());
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
