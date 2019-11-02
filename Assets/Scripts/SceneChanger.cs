﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

	public void ToDare()
	{
		SceneManager.LoadScene("Date");
	}

	public void ToTruth()
	{
		SceneManager.LoadScene("Truth");
	}

	public void ToInfo()
	{
		SceneManager.LoadScene("Info");
	}
}
