using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchToChangeLevel : MonoBehaviour
{
    public string LevelToLoad;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(LevelToLoad);
    }
}