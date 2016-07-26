using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CameraSize : MonoBehaviour {


	public float Pixels = 200f;
		public GameObject _empty;
		public Sprite _myScense;
		float _koef;
		// Use this for initialization
		void Start () {

			GetProportion();
		}

		void GetProportion()
	{
		Vector2 _resolution;
		Texture2D _textures;
		;
		float _kRes;
		var res = Screen.currentResolution;
		_resolution = new Vector2 (res.width, res.height);
		_textures = _myScense.texture;
		_kRes = (float)_resolution.y / (float)_textures.height;
		_empty.transform.localScale *= _kRes;
		//Camera.main.orthographicSize = res.height/2;
		//_empty.transform.position = new Vector3 (0, -Screen.height,0);
	}
	}
