using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replay : MonoBehaviour
{
    public void NextScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
