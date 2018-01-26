using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleTrigger : MonoBehaviour {
    public void OnStart()
    {
        SceneManager.LoadScene("Scenes/test");
    }

    public void OnExit()
    {
        Application.Quit();
    }
}
