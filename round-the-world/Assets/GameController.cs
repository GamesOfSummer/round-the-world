using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class GameController : MonoBehaviour
{
    public static GameController instance;
    private bool paused;
    private void Awake()
    {

        if (Application.isPlaying)
        {
            if (instance)
            {
                Debug.Log("Destroying irrelevant GameController instance");
                Destroy(this);
            }

            instance = this;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            togglePause();

    }

    public void togglePause()
    {
        if (paused)
        {
            Time.timeScale = 1f;
            paused = false;
        }
        else
        {
            Time.timeScale = 0f;
            paused = true;
        }
    }


}
