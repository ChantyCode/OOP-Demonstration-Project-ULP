using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainManager : MonoBehaviour
{   
    public static MainManager Instance;
    void Awake()
    {
        Instance = this;
    }
    public void SwtichScene(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }
}
