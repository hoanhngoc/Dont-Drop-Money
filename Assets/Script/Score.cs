using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI; 
    

public class Score : MonoBehaviour
{
    public TMP_Text  Scoretext;
    public TMP_Text Highscore;
    public int currentpoint = 0;
    // Start is called before the first frame update
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
        Scoretext.text = " " + currentpoint.ToString();
        Highscore.text="Hight Score   " + currentpoint.ToString();


    }
}
