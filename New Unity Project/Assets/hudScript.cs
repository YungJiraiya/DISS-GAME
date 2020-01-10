using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hudScript : MonoBehaviour
{
    public GameManager gm;
    public Text scoreText;
    public int scoreCap = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ("Score = " + gm.score.ToString()) + "/" + scoreCap;
    }
}
