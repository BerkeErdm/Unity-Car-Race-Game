using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
	public static int Min ;
	public static int Second ;
	public static float Millisecond ;
	public static string MilliDisplay ;
	
	public GameObject MinuteBox ;
	public GameObject SecondBox ;
	public GameObject MilliBox ;

    void Start()
    {
        
    }

    void Update()
    {
        Millisecond += Time.deltaTime * 10 ;
		MilliDisplay = Millisecond.ToString("f0");
		MilliBox.GetComponent<Text>().text = "" + MilliDisplay ;
		
		if(Millisecond >= 10 )
		{
			Millisecond = 0 ;
			Second +=1;
		}
		
		if(Second <= 9 )
		{
			SecondBox.GetComponent<Text>().text = "0" + Second + ".";
		}
		else 
		{
			SecondBox.GetComponent<Text>().text = "" + Second + ":";
		}
		
		if(Second >= 60 )
		{
			Second = 0 ;
			Min +=1;
		}
		
		if(Min <= 9 )
		{
			MinuteBox.GetComponent<Text>().text = "0" + Min + ":";
		}
		else 
		{
			MinuteBox.GetComponent<Text>().text = "" + Second + ":";
		}
    }
}
