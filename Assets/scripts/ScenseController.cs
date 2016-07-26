using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScenseController : MonoBehaviour {

  public void NextLevel(int a)
  {
    SceneManager.LoadScene(a);
  }
}
