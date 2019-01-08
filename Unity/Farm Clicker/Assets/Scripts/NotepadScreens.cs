using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotepadScreens : MonoBehaviour {

	public GameObject imgNotepad;
	public GameObject scrollViewTask;
	public GameObject scrollViewShop;

	public bool TaskActive = false;
	public bool ShopActive = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	// Update is called once per frame
	public void OnBtnTaskClick () {
		if (TaskActive == false) {
			TaskActive = true;
			imgNotepad.SetActive(true);
			scrollViewTask.SetActive(true);
			ShopActive = false;
			scrollViewShop.SetActive(false);
		} else {
			TaskActive = false;
			imgNotepad.SetActive(false);
			scrollViewTask.SetActive(false);
		}
	}

	public void OnBtnShopClick () {
		if (ShopActive == false) {
			ShopActive = true;
			imgNotepad.SetActive(true);
			scrollViewShop.SetActive(true);
			TaskActive = false;
			scrollViewTask.SetActive(false);
		} else {
			ShopActive = false;
			imgNotepad.SetActive(false);
			scrollViewShop.SetActive(false);
		}
	}
}
