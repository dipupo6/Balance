﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishColor : MonoBehaviour
{
    public Material sr;
    public string currentColor;
	public Color colorMagenta;
	public Color colorPurple;
    public Color colorPink;
	public Color colorBrown;
    // Start is called before the first frame update
    void Start()
    {
        SetRandomColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetRandomColor ()
	{
		int index = Random.Range(0, 4);

		switch (index)
		{
			case 0:
				currentColor = "Magenta";
				sr.color = colorMagenta;
				break;
			case 1:
				currentColor = "Purple";
				sr.color = colorPurple;
				break;
            case 2:
				currentColor = "Pink";
				sr.color = colorPink;
				break; 
	        case 3:
				currentColor = "Brown";
				sr.color = colorBrown;
				break; 			 
		}
	}
}
