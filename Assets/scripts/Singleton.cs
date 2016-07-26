using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Singleton : MonoBehaviour {
	[SerializeField]
	private int level;
	public Sprite Win;
	private static Singleton instance = null;
	public static Singleton Instance
	{
		get {
			return instance;
		}
	}
	public int Level
	{
		get {
			return level;
		}
		set {
			level = value;
		}
	}

	void Awake()
	{
		SingletonMethod ();
	}
	void Start()
	{

	}

	void SingletonMethod()
	{
		if (instance)
		{
			DestroyImmediate (gameObject);
			return;
		}
		instance = this;
		DontDestroyOnLoad (gameObject);
	}

	public void LoadScene()
	{
		SceneManager.LoadScene (level);
	}
}
