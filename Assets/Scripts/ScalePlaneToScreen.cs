using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalePlaneToScreen : MonoBehaviour
{
    void Start()
    {
        MatchPlaneToScreenSize();
    }

    void Update()
    {
        
    }
    private void MatchPlaneToScreenSize()
    {
        float planeHeight = 2.0f * Camera.main.orthographicSize / 10;
        float planeWidth =  planeHeight * Camera.main.aspect;
        gameObject.transform.localScale = new Vector3(planeWidth, 1, planeHeight);
    }
}
