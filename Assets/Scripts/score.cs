using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    // Start is called before the first frame update
    public float scores;
    public Text scoretext;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void plussc()
    {
        scores += 10;
        scoretext.text=scores.ToString();
    }
}
