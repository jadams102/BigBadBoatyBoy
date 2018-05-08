using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {

    private void Update()
    {
        if (Input.GetKey("enter"))
        {
            SceneManager.LoadScene(1);
        }
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
