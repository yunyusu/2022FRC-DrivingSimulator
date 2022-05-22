using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public static int theBalls=0;
    public GameObject loadingText;
    // Update is called once per frame
    void Update()
    {
        loadingText.GetComponent<Text>().text = "Cargo Load: " + theBalls;
    }
}
