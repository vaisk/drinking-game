using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RandomMultiplier : MonoBehaviour
{
    public TextMeshProUGUI Multiplier;

    // Start is called before the first frame update
    void Start()
    {
        System.Random random = new System.Random();
        int multiplier = random.Next(6);
        Multiplier.text = "x" + (multiplier + 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
