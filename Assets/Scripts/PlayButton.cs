using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayButton : MonoBehaviour
{
     private Button btn;
    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(BackToMain);
    }

    private void BackToMain()
    {
        MainManager.Instance.SwtichScene(1);
    }
}
