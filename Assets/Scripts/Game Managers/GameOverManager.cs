using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour {

	public void BackToMenu()
    {
        SceneLoader.instance.LoadLevel("MainMenu");
        Destroy(gameObject);
    }
}
