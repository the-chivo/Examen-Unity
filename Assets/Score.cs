using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    float score;
    [SerializeField] TMP_Text scoreTxt;
    [SerializeField] GameObject player;
    void Start()
    {
        GameEvents.addCoin.AddListener(AddCoin);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    
    void AddCoin()
    {
        score += 1;
        scoreTxt.text = score.ToString();
    }
}
