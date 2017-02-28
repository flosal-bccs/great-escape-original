﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FeedbackPanel : MonoBehaviour {
	public Text fbDisplay;
	public GameObject p;
	//public GameObject button;

	void Awake() {
		print("in Awake for FeedbackPanel");
		p = GameObject.FindGameObjectWithTag("FeedbackDisplay");
		if(p == null){
			print("p is null");
		} else {
			print("p != null");
		}
	}

	// Use this for initialization
	void Start () {
		print("in Start of FeedbackPanel script");
		fbDisplay.text = "";
		this.GetComponent<Image>().enabled = false;
		//button.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		//print("in update in Feedback Panel");
		//if (!string.IsNullOrEmpty (WordDisplay.text.ToString ().Trim ())) {
			//this.GetComponent<SpriteRenderer>().enabled = true;
			//button.SetActive(true);
		//} else {
		//	this.GetComponent<SpriteRenderer>().enabled = false;
		//	button.SetActive(false);
		//}
		
	}


	//called by to enable feedback panel
	public void enableFBPanel() {
		print("in enableFBPanel of FeedbackPanel script");
		fbDisplay.text = "this is text for Feedback";
		//this.GetComponent<SpriteRenderer>().enabled = true;
		this.GetComponent<Image>().enabled = true;
	}

	public void disableFBPanel (){
		print("in disableFBPanel of FeedbackPanel script");
		this.GetComponent<SpriteRenderer> ().enabled = false;
	}
}
