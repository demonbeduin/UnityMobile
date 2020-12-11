using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityMobile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.autorotateToPortrait = true;

        Screen.autorotateToPortraitUpsideDown = true;

        Screen.orientation = ScreenOrientation.AutoRotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
