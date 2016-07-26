using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ButtonsMenu : MonoBehaviour {
	Singleton singl;
	Button but;
	public int level;
	// Use this for initialization
	void Start () {
		singl = GameObject.FindGameObjectWithTag ("Singleton").GetComponent<Singleton> ();
		but = this.gameObject.GetComponent<Button> ();
		but.onClick.AddListener (() => ChangeLevel ());
		but.onClick.AddListener (() => singl.LoadScene());
		Stars ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void ChangeLevel()
	{
		singl.Level = level;
	}
	void Stars()
	{
		try
		{
			if(PlayerPrefs.GetInt("level"+level)==3)
			{
				for(int i=0;i<this.transform.childCount;i++)
				{
					this.transform.GetChild(i).GetComponent<Image>().sprite=singl.Win;
				}
			}
			if(PlayerPrefs.GetInt("level"+level)==2)
			{
				for(int i=0;i<this.transform.childCount-1;i++)
				{
					this.transform.GetChild(i).GetComponent<Image>().sprite=singl.Win;
				}
			}
			if(PlayerPrefs.GetInt("level"+level)==1)
			{
				for(int i=0;i<this.transform.childCount-2;i++)
				{
					this.transform.GetChild(i).GetComponent<Image>().sprite=singl.Win;
				}
			}
		}
		catch {

		}
	}
}
