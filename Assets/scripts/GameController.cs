using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour {
	public delegate void Container ();
	public static Container DeadEvent;
	public static bool take;
	public bool move=true;
	public int Star = 0;
	// Use this for initialization
	void Awake()
	{
		DeadEvent = null;
	}
	void Start () {
		DeadEvent += Fail;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Fail()
	{
		StartCoroutine (Death ());
	}
	IEnumerator Death()
	{
		move = false;
		yield return new WaitForSeconds (1);
		move = true;
	}
	public void loadScene(int level)
	{
		SceneManager.LoadScene (level);
	}
	public void Replay()
	{
		DeadEvent();
	}
}
