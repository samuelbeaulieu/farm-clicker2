using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {

	public GameObject imgMoney;
	private GameObject spawnImgMoney;
	public Text scoreText;
	public decimal scoreCount;
	public decimal touchCount;
	public decimal pointsPerSecond;
	private float RandomGoToPositionX;
	private float RandomGoToPositionY;
	public float lastUpdate;

	//Seeds
	public GameObject imgSeeds;
	public decimal seedsLevel;
	public decimal seedsCPS;
	public decimal seedsCost;
	public decimal seedsPointsPerSecond;
	public Text seedsLevelTxt;
	public Text seedsCPSTxt;
	public Text seedsCostTxt;

	//Flowers
	public GameObject btnFlowers;
	public GameObject imgFlowers;
	public decimal flowersLevel;
	public decimal flowersCPS;
	public decimal flowersCost;
	public decimal FlowersPointsPerSecond;
	public Text flowersLevelTxt;
	public Text flowersCPSTxt;
	public Text flowersCostTxt;

	//Tomato
	public GameObject btnTomato;
	public GameObject imgTomato;
	public decimal tomatoLevel;
	public decimal tomatoCPS;
	public decimal tomatoCost;
	public decimal TomatoPointsPerSecond;
	public Text tomatoLevelTxt;
	public Text tomatoCPSTxt;
	public Text tomatoCostTxt;

	//Tree
	public GameObject btnTree;
	public GameObject imgTree;
	public decimal TreeLevel;
	public decimal TreeCPS;
	public decimal TreeCost;
	public decimal TreePointsPerSecond;
	public Text TreeLevelTxt;
	public Text TreeCPSTxt;
	public Text TreeCostTxt;

	//GreenApple
	public GameObject btnGreenApple;
	public GameObject imgGreenApple;
	public decimal GreenAppleLevel;
	public decimal GreenAppleCPS;
	public decimal GreenAppleCost;
	public decimal GreenApplePointsPerSecond;
	public Text GreenAppleLevelTxt;
	public Text GreenAppleCPSTxt;
	public Text GreenAppleCostTxt;

	//Carrot
	public GameObject btnCarrot;
	public GameObject imgCarrot;
	public decimal CarrotLevel;
	public decimal CarrotCPS;
	public decimal CarrotCost;
	public decimal CarrotPointsPerSecond;
	public Text CarrotLevelTxt;
	public Text CarrotCPSTxt;
	public Text CarrotCostTxt;

	//GreenPear
	public GameObject btnGreenPear;
	public GameObject imgGreenPear;
	public decimal GreenPearLevel;
	public decimal GreenPearCPS;
	public decimal GreenPearCost;
	public decimal GreenPearPointsPerSecond;
	public Text GreenPearLevelTxt;
	public Text GreenPearCPSTxt;
	public Text GreenPearCostTxt;

	//Corn
	public GameObject btnCorn;
	public GameObject imgCorn;
	public decimal CornLevel;
	public decimal CornCPS;
	public decimal CornCost;
	public decimal CornPointsPerSecond;
	public Text CornLevelTxt;
	public Text CornCPSTxt;
	public Text CornCostTxt;

	//RedApple
	public GameObject btnRedApple;
	public GameObject imgRedApple;
	public decimal RedAppleLevel;
	public decimal RedAppleCPS;
	public decimal RedAppleCost;
	public decimal RedApplePointsPerSecond;
	public Text RedAppleLevelTxt;
	public Text RedAppleCPSTxt;
	public Text RedAppleCostTxt;

	//Watermelon
	public GameObject btnWatermelon;
	public GameObject imgWatermelon;
	public decimal WatermelonLevel;
	public decimal WatermelonCPS;
	public decimal WatermelonCost;
	public decimal WatermelonPointsPerSecond;
	public Text WatermelonLevelTxt;
	public Text WatermelonCPSTxt;
	public Text WatermelonCostTxt;

	//RedPear
	public GameObject btnRedPear;
	public GameObject imgRedPear;
	public decimal RedPearLevel;
	public decimal RedPearCPS;
	public decimal RedPearCost;
	public decimal RedPearPointsPerSecond;
	public Text RedPearLevelTxt;
	public Text RedPearCPSTxt;
	public Text RedPearCostTxt;

	//Pumpkin
	public GameObject btnPumpkin;
	public GameObject imgPumpkin;
	public decimal PumpkinLevel;
	public decimal PumpkinCPS;
	public decimal PumpkinCost;
	public decimal PumpkinPointsPerSecond;
	public Text PumpkinLevelTxt;
	public Text PumpkinCPSTxt;
	public Text PumpkinCostTxt;

	//Wrench
	public GameObject btnWrench;
	public GameObject imgWrench;
	public decimal WrenchLevel;
	public decimal WrenchCPS;
	public decimal WrenchCost;
	public decimal WrenchPointsPerSecond;
	public Text WrenchLevelTxt;
	public Text WrenchCPSTxt;
	public Text WrenchCostTxt;

	//Screwdriver
	public GameObject btnScrewdriver;
	public GameObject imgScrewdriver;
	public decimal ScrewdriverLevel;
	public decimal ScrewdriverCPS;
	public decimal ScrewdriverCost;
	public decimal ScrewdriverPointsPerSecond;
	public Text ScrewdriverLevelTxt;
	public Text ScrewdriverCPSTxt;
	public Text ScrewdriverCostTxt;

	//Hammer
	public GameObject btnHammer;
	public GameObject imgHammer;
	public decimal HammerLevel;
	public decimal HammerCPS;
	public decimal HammerCost;
	public decimal HammerPointsPerSecond;
	public Text HammerLevelTxt;
	public Text HammerCPSTxt;
	public Text HammerCostTxt;

	//Handsaw
	public GameObject btnHandsaw;
	public GameObject imgHandsaw;
	public decimal HandsawLevel;
	public decimal HandsawCPS;
	public decimal HandsawCost;
	public decimal HandsawPointsPerSecond;
	public Text HandsawLevelTxt;
	public Text HandsawCPSTxt;
	public Text HandsawCostTxt;

	//Fence
	public GameObject btnFence;
	public GameObject imgFence;
	public decimal FenceLevel;
	public decimal FenceCPS;
	public decimal FenceCost;
	public decimal FencePointsPerSecond;
	public Text FenceLevelTxt;
	public Text FenceCPSTxt;
	public Text FenceCostTxt;

	//Dog
	public GameObject btnDog;
	public GameObject imgDog;
	public decimal DogLevel;
	public decimal DogCPS;
	public decimal DogCost;
	public decimal DogPointsPerSecond;
	public Text DogLevelTxt;
	public Text DogCPSTxt;
	public Text DogCostTxt;

	//Cat
	public GameObject btnCat;
	public GameObject imgCat;
	public decimal CatLevel;
	public decimal CatCPS;
	public decimal CatCost;
	public decimal CatPointsPerSecond;
	public Text CatLevelTxt;
	public Text CatCPSTxt;
	public Text CatCostTxt;

	//Chicken
	public GameObject btnChicken;
	public GameObject imgChicken;
	public decimal ChickenLevel;
	public decimal ChickenCPS;
	public decimal ChickenCost;
	public decimal ChickenPointsPerSecond;
	public Text ChickenLevelTxt;
	public Text ChickenCPSTxt;
	public Text ChickenCostTxt;

	//Pig
	public GameObject btnPig;
	public GameObject imgPig;
	public decimal PigLevel;
	public decimal PigCPS;
	public decimal PigCost;
	public decimal PigPointsPerSecond;
	public Text PigLevelTxt;
	public Text PigCPSTxt;
	public Text PigCostTxt;

	//Sheep
	public GameObject btnSheep;
	public GameObject imgSheep;
	public decimal SheepLevel;
	public decimal SheepCPS;
	public decimal SheepCost;
	public decimal SheepPointsPerSecond;
	public Text SheepLevelTxt;
	public Text SheepCPSTxt;
	public Text SheepCostTxt;

	//Cow
	public GameObject btnCow;
	public GameObject imgCow;
	public decimal CowLevel;
	public decimal CowCPS;
	public decimal CowCost;
	public decimal CowPointsPerSecond;
	public Text CowLevelTxt;
	public Text CowCPSTxt;
	public Text CowCostTxt;

	//Horse
	public GameObject btnHorse;
	public GameObject imgHorse;
	public decimal HorseLevel;
	public decimal HorseCPS;
	public decimal HorseCost;
	public decimal HorsePointsPerSecond;
	public Text HorseLevelTxt;
	public Text HorseCPSTxt;
	public Text HorseCostTxt;

	//GoldPear
	public GameObject btnGoldPear;
	public GameObject imgGoldPear;
	public decimal GoldPearLevel;
	public decimal GoldPearCPS;
	public decimal GoldPearCost;
	public decimal GoldPearPointsPerSecond;
	public Text GoldPearLevelTxt;
	public Text GoldPearCPSTxt;
	public Text GoldPearCostTxt;

	//Barn
	public GameObject btnBarn;
	public GameObject imgBarn;
	public decimal BarnLevel;
	public decimal BarnCPS;
	public decimal BarnCost;
	public decimal BarnPointsPerSecond;
	public Text BarnLevelTxt;
	public Text BarnCPSTxt;
	public Text BarnCostTxt;

	//Tractor
	public GameObject btnTractor;
	public GameObject imgTractor;
	public decimal TractorLevel;
	public decimal TractorCPS;
	public decimal TractorCost;
	public decimal TractorPointsPerSecond;
	public Text TractorLevelTxt;
	public Text TractorCPSTxt;
	public Text TractorCostTxt;

	//Mill
	public GameObject btnMill;
	public GameObject imgMill;
	public decimal MillLevel;
	public decimal MillCPS;
	public decimal MillCost;
	public decimal MillPointsPerSecond;
	public Text MillLevelTxt;
	public Text MillCPSTxt;
	public Text MillCostTxt;

	//GoldApple
	public GameObject btnGoldApple;
	public GameObject imgGoldApple;
	public decimal GoldAppleLevel;
	public decimal GoldAppleCPS;
	public decimal GoldAppleCost;
	public decimal GoldApplePointsPerSecond;
	public Text GoldAppleLevelTxt;
	public Text GoldAppleCPSTxt;
	public Text GoldAppleCostTxt;

	//notepad screens
	public GameObject imgNotepad;
	public GameObject scrollViewTask;
	public GameObject scrollViewShop;
	public bool TaskActive = false;
	public bool ShopActive = false;

	//intro
	public GameObject panelWelcome;
	public GameObject panelInstructions;
	public GameObject btnInstructions;
	public string playerName;
	public bool WelcomeActive;
	public bool instructionsActive;

	//Gift
	public GameObject btnGift;
	public bool gift;

	//Task1
	public Text txtTask1;
	public GameObject btnTask1;
	public GameObject imgToDo1;
	public GameObject imgCompleted1;
	public GameObject imgColor1;
	public decimal taskResult1;
	public bool taskCompleted1;

	//Task2
	public Text txtTask2;
	public GameObject btnTask2;
	public GameObject imgToDo2;
	public GameObject imgCompleted2;
	public GameObject imgColor2;
	public decimal taskResult2;
	public bool taskCompleted2;

	//Task3
	public Text txtTask3;
	public GameObject btnTask3;
	public GameObject imgToDo3;
	public GameObject imgCompleted3;
	public GameObject imgColor3;
	public decimal taskResult3;
	public bool taskCompleted3;

	//Task4
	public Text txtTask4;
	public GameObject btnTask4;
	public GameObject imgToDo4;
	public GameObject imgCompleted4;
	public GameObject imgColor4;
	public decimal taskResult4;
	public bool taskCompleted4;

	//Task5
	public Text txtTask5;
	public GameObject btnTask5;
	public GameObject imgToDo5;
	public GameObject imgCompleted5;
	public GameObject imgColor5;
	public decimal taskResult5;
	public bool taskCompleted5;

	//Task6
	public Text txtTask6;
	public GameObject btnTask6;
	public GameObject imgToDo6;
	public GameObject imgCompleted6;
	public GameObject imgColor6;
	public decimal taskResult6;
	public bool taskCompleted6;

	//Task7
	public Text txtTask7;
	public GameObject btnTask7;
	public GameObject imgToDo7;
	public GameObject imgCompleted7;
	public GameObject imgColor7;
	public decimal taskResult7;
	public bool taskCompleted7;

	//Task8
	public Text txtTask8;
	public GameObject btnTask8;
	public GameObject imgToDo8;
	public GameObject imgCompleted8;
	public GameObject imgColor8;
	public decimal taskResult8;
	public bool taskCompleted8;

	//audio
	public AudioClip clickMoney;
	public AudioClip btnClick;
	public AudioClip btnError;
	AudioSource m_source;

	void Awake () {
		//verify if score data already exist in PlayerPrefs
		if (PlayerPrefs.HasKey ("Score")) {
			scoreCount = decimal.Parse (PlayerPrefs.GetString("Score"));

			//verify if seeds data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("seedsCost") && PlayerPrefs.HasKey ("seedsLevel") && PlayerPrefs.HasKey ("seedsCPS") && PlayerPrefs.HasKey ("seedsPointsPerSecond")) {
				//retreive seeds data and convert it to decimal
				seedsCost = decimal.Parse (PlayerPrefs.GetString("seedsCost"));
				seedsLevel = decimal.Parse (PlayerPrefs.GetString("seedsLevel"));
				seedsCPS = decimal.Parse (PlayerPrefs.GetString("seedsCPS"));
				seedsPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("seedsPointsPerSecond"));
				//add pre-existing seeds data to pointsPerSecond
				pointsPerSecond += seedsPointsPerSecond;
				imgSeeds.SetActive(true);
				//verify to unlock next object
				if (seedsLevel >= 25) {
					btnFlowers.GetComponent<Button>().interactable = true;
				} else {
					btnFlowers.GetComponent<Button>().interactable = false;
				}
				//seeds txt update
				seedsCPSTxt.text = "C.P.S : " + seedsCPS;
				seedsLevelTxt.text = "Lvl : " + seedsLevel;
				seedsCostTxt.text = seedsCost + "$";
			} else {
				//set seeds default values
				seedsCost = 100;
				seedsLevel = 0;
				seedsCPS = 0;
				//seeds txt update
				seedsCPSTxt.text = "C.P.S : " + seedsCPS;
				seedsLevelTxt.text = "Lvl : " + seedsLevel;
				seedsCostTxt.text = seedsCost + "$";
			}

			//verify if flowers data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("flowersCost") && PlayerPrefs.HasKey ("flowersLevel") && PlayerPrefs.HasKey ("flowersCPS") && PlayerPrefs.HasKey ("flowersPointsPerSecond")) {
				//retreive flowers data and convert it to decimal
				flowersCost = decimal.Parse (PlayerPrefs.GetString("flowersCost"));
				flowersLevel = decimal.Parse (PlayerPrefs.GetString("flowersLevel"));
				flowersCPS = decimal.Parse (PlayerPrefs.GetString("flowersCPS"));
				FlowersPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("flowersPointsPerSecond"));
				//add pre-existing flowers data to pointsPerSecond
				pointsPerSecond += FlowersPointsPerSecond;
				imgFlowers.SetActive(true);
				//verify to unlock next object
				if (flowersLevel >= 25) {
					btnTomato.GetComponent<Button>().interactable = true;
				} else {
					btnTomato.GetComponent<Button>().interactable = false;
				}
				//flowers txt update
				flowersCPSTxt.text = "C.P.S : " + flowersCPS;
				flowersLevelTxt.text = "Lvl : " + flowersLevel;
				flowersCostTxt.text = flowersCost + "$";
			} else {
				//set flowers default values
				flowersCost = 10000;
				flowersLevel = 0;
				flowersCPS = 0;
				//lock flowers
				btnFlowers.GetComponent<Button>().interactable = false;
				//flowers txt update
				flowersCPSTxt.text = "C.P.S : " + flowersCPS;
				flowersLevelTxt.text = "Lvl : " + flowersLevel;
				flowersCostTxt.text = flowersCost + "$";
			}

			//verify if tomato data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("tomatoCost") && PlayerPrefs.HasKey ("tomatoLevel") && PlayerPrefs.HasKey ("tomatoCPS") && PlayerPrefs.HasKey ("tomatoPointsPerSecond")) {
				//retreive tomato data and convert it to decimal
				tomatoCost = decimal.Parse (PlayerPrefs.GetString("tomatoCost"));
				tomatoLevel = decimal.Parse (PlayerPrefs.GetString("tomatoLevel"));
				tomatoCPS = decimal.Parse (PlayerPrefs.GetString("tomatoCPS"));
				TomatoPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("tomatoPointsPerSecond"));
				//add pre-existing tomato data to pointsPerSecond
				pointsPerSecond += TomatoPointsPerSecond;
				imgTomato.SetActive(true);
				//verify to unlock next object
				if (tomatoLevel >= 25) {
					btnTree.GetComponent<Button>().interactable = true;
				} else {
					btnTree.GetComponent<Button>().interactable = false;
				}
				//tomato txt update
				tomatoCPSTxt.text = "C.P.S : " + tomatoCPS;
				tomatoLevelTxt.text = "Lvl : " + tomatoLevel;
				tomatoCostTxt.text = tomatoCost + "$";
			} else {
				//set tomato default values
				tomatoCost = 100000;
				tomatoLevel = 0;
				tomatoCPS = 0;
				//lock tomato
				btnTomato.GetComponent<Button>().interactable = false;
				//tomato txt update
				tomatoCPSTxt.text = "C.P.S : " + tomatoCPS;
				tomatoLevelTxt.text = "Lvl : " + tomatoLevel;
				tomatoCostTxt.text = tomatoCost + "$";
			}

			//verify if Tree data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("TreeCost") && PlayerPrefs.HasKey ("TreeLevel") && PlayerPrefs.HasKey ("TreeCPS") && PlayerPrefs.HasKey ("TreePointsPerSecond")) {
				//retreive Tree data and convert it to decimal
				TreeCost = decimal.Parse (PlayerPrefs.GetString("TreeCost"));
				TreeLevel = decimal.Parse (PlayerPrefs.GetString("TreeLevel"));
				TreeCPS = decimal.Parse (PlayerPrefs.GetString("TreeCPS"));
				TreePointsPerSecond = decimal.Parse (PlayerPrefs.GetString("TreePointsPerSecond"));
				//add pre-existing Tree data to pointsPerSecond
				pointsPerSecond += TreePointsPerSecond;
				imgTree.SetActive(true);
				//verify to unlock next object
				if (TreeLevel >= 25) {
					btnGreenApple.GetComponent<Button>().interactable = true;
				} else {
					btnGreenApple.GetComponent<Button>().interactable = false;
				}
				//Tree txt update
				TreeCPSTxt.text = "C.P.S : " + TreeCPS;
				TreeLevelTxt.text = "Lvl : " + TreeLevel;
				TreeCostTxt.text = TreeCost + "$";
			} else {
				//set Tree default values
				TreeCost = 500000;
				TreeLevel = 0;
				TreeCPS = 0;
				//lock Tree
				btnTree.GetComponent<Button>().interactable = false;
				//Tree txt update
				TreeCPSTxt.text = "C.P.S : " + TreeCPS;
				TreeLevelTxt.text = "Lvl : " + TreeLevel;
				TreeCostTxt.text = TreeCost + "$";
			}

			//verify if GreenApple data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("GreenAppleCost") && PlayerPrefs.HasKey ("GreenAppleLevel") && PlayerPrefs.HasKey ("GreenAppleCPS") && PlayerPrefs.HasKey ("GreenApplePointsPerSecond")) {
				//retreive GreenApple data and convert it to decimal
				GreenAppleCost = decimal.Parse (PlayerPrefs.GetString("GreenAppleCost"));
				GreenAppleLevel = decimal.Parse (PlayerPrefs.GetString("GreenAppleLevel"));
				GreenAppleCPS = decimal.Parse (PlayerPrefs.GetString("GreenAppleCPS"));
				GreenApplePointsPerSecond = decimal.Parse (PlayerPrefs.GetString("GreenApplePointsPerSecond"));
				//add pre-existing GreenApple data to pointsPerSecond
				pointsPerSecond += GreenApplePointsPerSecond;
				imgGreenApple.SetActive(true);
				//verify to unlock next object
				if (GreenAppleLevel >= 25) {
					btnCarrot.GetComponent<Button>().interactable = true;
				} else {
					btnCarrot.GetComponent<Button>().interactable = false;
				}
				//GreenApple txt update
				GreenAppleCPSTxt.text = "C.P.S : " + GreenAppleCPS;
				GreenAppleLevelTxt.text = "Lvl : " + GreenAppleLevel;
				GreenAppleCostTxt.text = GreenAppleCost + "$";
			} else {
				//set GreenApple default values
				GreenAppleCost = 2000000;
				GreenAppleLevel = 0;
				GreenAppleCPS = 0;
				//lock GreenApple
				btnGreenApple.GetComponent<Button>().interactable = false;
				//GreenApple txt update
				GreenAppleCPSTxt.text = "C.P.S : " + GreenAppleCPS;
				GreenAppleLevelTxt.text = "Lvl : " + GreenAppleLevel;
				GreenAppleCostTxt.text = GreenAppleCost + "$";
			}

			//verify if Carrot data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("CarrotCost") && PlayerPrefs.HasKey ("CarrotLevel") && PlayerPrefs.HasKey ("CarrotCPS") && PlayerPrefs.HasKey ("CarrotPointsPerSecond")) {
				//retreive Carrot data and convert it to decimal
				CarrotCost = decimal.Parse (PlayerPrefs.GetString("CarrotCost"));
				CarrotLevel = decimal.Parse (PlayerPrefs.GetString("CarrotLevel"));
				CarrotCPS = decimal.Parse (PlayerPrefs.GetString("CarrotCPS"));
				CarrotPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("CarrotPointsPerSecond"));
				//add pre-existing Carrot data to pointsPerSecond
				pointsPerSecond += CarrotPointsPerSecond;
				imgCarrot.SetActive(true);
				//verify to unlock next object
				if (CarrotLevel >= 25) {
					btnGreenPear.GetComponent<Button>().interactable = true;
				} else {
					btnGreenPear.GetComponent<Button>().interactable = false;
				}
				//Carrot txt update
				CarrotCPSTxt.text = "C.P.S : " + CarrotCPS;
				CarrotLevelTxt.text = "Lvl : " + CarrotLevel;
				CarrotCostTxt.text = CarrotCost + "$";
			} else {
				//set Carrot default values
				CarrotCost = 10000000;
				CarrotLevel = 0;
				CarrotCPS = 0;
				//lock Carrot
				btnCarrot.GetComponent<Button>().interactable = false;
				//Carrot txt update
				CarrotCPSTxt.text = "C.P.S : " + CarrotCPS;
				CarrotLevelTxt.text = "Lvl : " + CarrotLevel;
				CarrotCostTxt.text = CarrotCost + "$";
			}

			//verify if GreenPear data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("GreenPearCost") && PlayerPrefs.HasKey ("GreenPearLevel") && PlayerPrefs.HasKey ("GreenPearCPS") && PlayerPrefs.HasKey ("GreenPearPointsPerSecond")) {
				//retreive GreenPear data and convert it to decimal
				GreenPearCost = decimal.Parse (PlayerPrefs.GetString("GreenPearCost"));
				GreenPearLevel = decimal.Parse (PlayerPrefs.GetString("GreenPearLevel"));
				GreenPearCPS = decimal.Parse (PlayerPrefs.GetString("GreenPearCPS"));
				GreenPearPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("GreenPearPointsPerSecond"));
				//add pre-existing GreenPear data to pointsPerSecond
				pointsPerSecond += GreenPearPointsPerSecond;
				imgGreenPear.SetActive(true);
				//verify to unlock next object
				if (GreenPearLevel >= 25) {
					btnCorn.GetComponent<Button>().interactable = true;
				} else {
					btnCorn.GetComponent<Button>().interactable = false;
				}
				//GreenPear txt update
				GreenPearCPSTxt.text = "C.P.S : " + GreenPearCPS;
				GreenPearLevelTxt.text = "Lvl : " + GreenPearLevel;
				GreenPearCostTxt.text = GreenPearCost + "$";
			} else {
				//set GreenPear default values
				GreenPearCost = 50000000;
				GreenPearLevel = 0;
				GreenPearCPS = 0;
				//lock GreenPear
				btnGreenPear.GetComponent<Button>().interactable = false;
				//GreenPear txt update
				GreenPearCPSTxt.text = "C.P.S : " + GreenPearCPS;
				GreenPearLevelTxt.text = "Lvl : " + GreenPearLevel;
				GreenPearCostTxt.text = GreenPearCost + "$";
			}

			//verify if Corn data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("CornCost") && PlayerPrefs.HasKey ("CornLevel") && PlayerPrefs.HasKey ("CornCPS") && PlayerPrefs.HasKey ("CornPointsPerSecond")) {
				//retreive Corn data and convert it to decimal
				CornCost = decimal.Parse (PlayerPrefs.GetString("CornCost"));
				CornLevel = decimal.Parse (PlayerPrefs.GetString("CornLevel"));
				CornCPS = decimal.Parse (PlayerPrefs.GetString("CornCPS"));
				CornPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("CornPointsPerSecond"));
				//add pre-existing Corn data to pointsPerSecond
				pointsPerSecond += CornPointsPerSecond;
				imgCorn.SetActive(true);
				//verify to unlock next object
				if (CornLevel >= 25) {
					btnRedApple.GetComponent<Button>().interactable = true;
				} else {
					btnRedApple.GetComponent<Button>().interactable = false;
				}
				//Corn txt update
				CornCPSTxt.text = "C.P.S : " + CornCPS;
				CornLevelTxt.text = "Lvl : " + CornLevel;
				CornCostTxt.text = CornCost + "$";
			} else {
				//set Corn default values
				CornCost = 300000000;
				CornLevel = 0;
				CornCPS = 0;
				//lock Corn
				btnCorn.GetComponent<Button>().interactable = false;
				//Corn txt update
				CornCPSTxt.text = "C.P.S : " + CornCPS;
				CornLevelTxt.text = "Lvl : " + CornLevel;
				CornCostTxt.text = CornCost + "$";
			}

			//verify if RedApple data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("RedAppleCost") && PlayerPrefs.HasKey ("RedAppleLevel") && PlayerPrefs.HasKey ("RedAppleCPS") && PlayerPrefs.HasKey ("RedApplePointsPerSecond")) {
				//retreive RedApple data and convert it to decimal
				RedAppleCost = decimal.Parse (PlayerPrefs.GetString("RedAppleCost"));
				RedAppleLevel = decimal.Parse (PlayerPrefs.GetString("RedAppleLevel"));
				RedAppleCPS = decimal.Parse (PlayerPrefs.GetString("RedAppleCPS"));
				RedApplePointsPerSecond = decimal.Parse (PlayerPrefs.GetString("RedApplePointsPerSecond"));
				//add pre-existing RedApple data to pointsPerSecond
				pointsPerSecond += RedApplePointsPerSecond;
				imgRedApple.SetActive(true);
				//verify to unlock next object
				if (RedAppleLevel >= 25) {
					btnWatermelon.GetComponent<Button>().interactable = true;
				} else {
					btnWatermelon.GetComponent<Button>().interactable = false;
				}
				//RedApple txt update
				RedAppleCPSTxt.text = "C.P.S : " + RedAppleCPS;
				RedAppleLevelTxt.text = "Lvl : " + RedAppleLevel;
				RedAppleCostTxt.text = RedAppleCost + "$";
			} else {
				//set RedApple default values
				RedAppleCost = 700000000;
				RedAppleLevel = 0;
				RedAppleCPS = 0;
				//lock RedApple
				btnRedApple.GetComponent<Button>().interactable = false;
				//RedApple txt update
				RedAppleCPSTxt.text = "C.P.S : " + RedAppleCPS;
				RedAppleLevelTxt.text = "Lvl : " + RedAppleLevel;
				RedAppleCostTxt.text = RedAppleCost + "$";
			}

			//verify if Watermelon data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("WatermelonCost") && PlayerPrefs.HasKey ("WatermelonLevel") && PlayerPrefs.HasKey ("WatermelonCPS") && PlayerPrefs.HasKey ("WatermelonPointsPerSecond")) {
				//retreive Watermelon data and convert it to decimal
				WatermelonCost = decimal.Parse (PlayerPrefs.GetString("WatermelonCost"));
				WatermelonLevel = decimal.Parse (PlayerPrefs.GetString("WatermelonLevel"));
				WatermelonCPS = decimal.Parse (PlayerPrefs.GetString("WatermelonCPS"));
				WatermelonPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("WatermelonPointsPerSecond"));
				//add pre-existing Watermelon data to pointsPerSecond
				pointsPerSecond += WatermelonPointsPerSecond;
				imgWatermelon.SetActive(true);
				//verify to unlock next object
				if (WatermelonLevel >= 25) {
					btnRedPear.GetComponent<Button>().interactable = true;
				} else {
					btnRedPear.GetComponent<Button>().interactable = false;
				}
				//Watermelon txt update
				WatermelonCPSTxt.text = "C.P.S : " + WatermelonCPS;
				WatermelonLevelTxt.text = "Lvl : " + WatermelonLevel;
				WatermelonCostTxt.text = WatermelonCost + "$";
			} else {
				//set Watermelon default values
				WatermelonCost = 2000000000;
				WatermelonLevel = 0;
				WatermelonCPS = 0;
				//lock Watermelon
				btnWatermelon.GetComponent<Button>().interactable = false;
				//Watermelon txt update
				WatermelonCPSTxt.text = "C.P.S : " + WatermelonCPS;
				WatermelonLevelTxt.text = "Lvl : " + WatermelonLevel;
				WatermelonCostTxt.text = WatermelonCost + "$";
			}

			//verify if RedPear data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("RedPearCost") && PlayerPrefs.HasKey ("RedPearLevel") && PlayerPrefs.HasKey ("RedPearCPS") && PlayerPrefs.HasKey ("RedPearPointsPerSecond")) {
				//retreive RedPear data and convert it to decimal
				RedPearCost = decimal.Parse (PlayerPrefs.GetString("RedPearCost"));
				RedPearLevel = decimal.Parse (PlayerPrefs.GetString("RedPearLevel"));
				RedPearCPS = decimal.Parse (PlayerPrefs.GetString("RedPearCPS"));
				RedPearPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("RedPearPointsPerSecond"));
				//add pre-existing RedPear data to pointsPerSecond
				pointsPerSecond += RedPearPointsPerSecond;
				imgRedPear.SetActive(true);
				//verify to unlock next object
				if (RedPearLevel >= 25) {
					btnPumpkin.GetComponent<Button>().interactable = true;
				} else {
					btnPumpkin.GetComponent<Button>().interactable = false;
				}
				//RedPear txt update
				RedPearCPSTxt.text = "C.P.S : " + RedPearCPS;
				RedPearLevelTxt.text = "Lvl : " + RedPearLevel;
				RedPearCostTxt.text = RedPearCost + "$";
			} else {
				//set RedPear default values
				RedPearCost = 4000000000;
				RedPearLevel = 0;
				RedPearCPS = 0;
				//lock RedPear
				btnRedPear.GetComponent<Button>().interactable = false;
				//RedPear txt update
				RedPearCPSTxt.text = "C.P.S : " + RedPearCPS;
				RedPearLevelTxt.text = "Lvl : " + RedPearLevel;
				RedPearCostTxt.text = RedPearCost + "$";
			}

			//verify if Pumpkin data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("PumpkinCost") && PlayerPrefs.HasKey ("PumpkinLevel") && PlayerPrefs.HasKey ("PumpkinCPS") && PlayerPrefs.HasKey ("PumpkinPointsPerSecond")) {
				//retreive Pumpkin data and convert it to decimal
				PumpkinCost = decimal.Parse (PlayerPrefs.GetString("PumpkinCost"));
				PumpkinLevel = decimal.Parse (PlayerPrefs.GetString("PumpkinLevel"));
				PumpkinCPS = decimal.Parse (PlayerPrefs.GetString("PumpkinCPS"));
				PumpkinPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("PumpkinPointsPerSecond"));
				//add pre-existing Pumpkin data to pointsPerSecond
				pointsPerSecond += PumpkinPointsPerSecond;
				imgPumpkin.SetActive(true);
				//verify to unlock next object
				if (PumpkinLevel >= 25) {
					btnWrench.GetComponent<Button>().interactable = true;
				} else {
					btnWrench.GetComponent<Button>().interactable = false;
				}
				//Pumpkin txt update
				PumpkinCPSTxt.text = "C.P.S : " + PumpkinCPS;
				PumpkinLevelTxt.text = "Lvl : " + PumpkinLevel;
				PumpkinCostTxt.text = PumpkinCost + "$";
			} else {
				//set Pumpkin default values
				PumpkinCost = 6000000000;
				PumpkinLevel = 0;
				PumpkinCPS = 0;
				//lock Pumpkin
				btnPumpkin.GetComponent<Button>().interactable = false;
				//Pumpkin txt update
				PumpkinCPSTxt.text = "C.P.S : " + PumpkinCPS;
				PumpkinLevelTxt.text = "Lvl : " + PumpkinLevel;
				PumpkinCostTxt.text = PumpkinCost + "$";
			}

			//verify if Wrench data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("WrenchCost") && PlayerPrefs.HasKey ("WrenchLevel") && PlayerPrefs.HasKey ("WrenchCPS") && PlayerPrefs.HasKey ("WrenchPointsPerSecond")) {
				//retreive Wrench data and convert it to decimal
				WrenchCost = decimal.Parse (PlayerPrefs.GetString("WrenchCost"));
				WrenchLevel = decimal.Parse (PlayerPrefs.GetString("WrenchLevel"));
				WrenchCPS = decimal.Parse (PlayerPrefs.GetString("WrenchCPS"));
				WrenchPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("WrenchPointsPerSecond"));
				//add pre-existing Wrench data to pointsPerSecond
				pointsPerSecond += WrenchPointsPerSecond;
				imgWrench.SetActive(true);
				//verify to unlock next object
				if (WrenchLevel >= 25) {
					btnScrewdriver.GetComponent<Button>().interactable = true;
				} else {
					btnScrewdriver.GetComponent<Button>().interactable = false;
				}
				//Wrench txt update
				WrenchCPSTxt.text = "C.P.S : " + WrenchCPS;
				WrenchLevelTxt.text = "Lvl : " + WrenchLevel;
				WrenchCostTxt.text = WrenchCost + "$";
			} else {
				//set Wrench default values
				WrenchCost = 10000000000;
				WrenchLevel = 0;
				WrenchCPS = 0;
				//lock Wrench
				btnWrench.GetComponent<Button>().interactable = false;
				//Wrench txt update
				WrenchCPSTxt.text = "C.P.S : " + WrenchCPS;
				WrenchLevelTxt.text = "Lvl : " + WrenchLevel;
				WrenchCostTxt.text = WrenchCost + "$";
			}

			//verify if Screwdriver data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("ScrewdriverCost") && PlayerPrefs.HasKey ("ScrewdriverLevel") && PlayerPrefs.HasKey ("ScrewdriverCPS") && PlayerPrefs.HasKey ("ScrewdriverPointsPerSecond")) {
				//retreive Screwdriver data and convert it to decimal
				ScrewdriverCost = decimal.Parse (PlayerPrefs.GetString("ScrewdriverCost"));
				ScrewdriverLevel = decimal.Parse (PlayerPrefs.GetString("ScrewdriverLevel"));
				ScrewdriverCPS = decimal.Parse (PlayerPrefs.GetString("ScrewdriverCPS"));
				ScrewdriverPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("ScrewdriverPointsPerSecond"));
				//add pre-existing Screwdriver data to pointsPerSecond
				pointsPerSecond += ScrewdriverPointsPerSecond;
				imgScrewdriver.SetActive(true);
				//verify to unlock next object
				if (ScrewdriverLevel >= 25) {
					btnHammer.GetComponent<Button>().interactable = true;
				} else {
					btnHammer.GetComponent<Button>().interactable = false;
				}
				//Screwdriver txt update
				ScrewdriverCPSTxt.text = "C.P.S : " + ScrewdriverCPS;
				ScrewdriverLevelTxt.text = "Lvl : " + ScrewdriverLevel;
				ScrewdriverCostTxt.text = ScrewdriverCost + "$";
			} else {
				//set Screwdriver default values
				ScrewdriverCost = 30000000000;
				ScrewdriverLevel = 0;
				ScrewdriverCPS = 0;
				//lock Screwdriver
				btnScrewdriver.GetComponent<Button>().interactable = false;
				//Screwdriver txt update
				ScrewdriverCPSTxt.text = "C.P.S : " + ScrewdriverCPS;
				ScrewdriverLevelTxt.text = "Lvl : " + ScrewdriverLevel;
				ScrewdriverCostTxt.text = ScrewdriverCost + "$";
			}

			//verify if Hammer data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("HammerCost") && PlayerPrefs.HasKey ("HammerLevel") && PlayerPrefs.HasKey ("HammerCPS") && PlayerPrefs.HasKey ("HammerPointsPerSecond")) {
				//retreive Hammer data and convert it to decimal
				HammerCost = decimal.Parse (PlayerPrefs.GetString("HammerCost"));
				HammerLevel = decimal.Parse (PlayerPrefs.GetString("HammerLevel"));
				HammerCPS = decimal.Parse (PlayerPrefs.GetString("HammerCPS"));
				HammerPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("HammerPointsPerSecond"));
				//add pre-existing Hammer data to pointsPerSecond
				pointsPerSecond += HammerPointsPerSecond;
				imgHammer.SetActive(true);
				//verify to unlock next object
				if (HammerLevel >= 25) {
					btnHandsaw.GetComponent<Button>().interactable = true;
				} else {
					btnHandsaw.GetComponent<Button>().interactable = false;
				}
				//Hammer txt update
				HammerCPSTxt.text = "C.P.S : " + HammerCPS;
				HammerLevelTxt.text = "Lvl : " + HammerLevel;
				HammerCostTxt.text = HammerCost + "$";
			} else {
				//set Hammer default values
				HammerCost = 50000000000;
				HammerLevel = 0;
				HammerCPS = 0;
				//lock Hammer
				btnHammer.GetComponent<Button>().interactable = false;
				//Hammer txt update
				HammerCPSTxt.text = "C.P.S : " + HammerCPS;
				HammerLevelTxt.text = "Lvl : " + HammerLevel;
				HammerCostTxt.text = HammerCost + "$";
			}

			//verify if Handsaw data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("HandsawCost") && PlayerPrefs.HasKey ("HandsawLevel") && PlayerPrefs.HasKey ("HandsawCPS") && PlayerPrefs.HasKey ("HandsawPointsPerSecond")) {
				//retreive Handsaw data and convert it to decimal
				HandsawCost = decimal.Parse (PlayerPrefs.GetString("HandsawCost"));
				HandsawLevel = decimal.Parse (PlayerPrefs.GetString("HandsawLevel"));
				HandsawCPS = decimal.Parse (PlayerPrefs.GetString("HandsawCPS"));
				HandsawPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("HandsawPointsPerSecond"));
				//add pre-existing Handsaw data to pointsPerSecond
				pointsPerSecond += HandsawPointsPerSecond;
				imgHandsaw.SetActive(true);
				//verify to unlock next object
				if (HandsawLevel >= 25) {
					btnFence.GetComponent<Button>().interactable = true;
				} else {
					btnFence.GetComponent<Button>().interactable = false;
				}
				//Handsaw txt update
				HandsawCPSTxt.text = "C.P.S : " + HandsawCPS;
				HandsawLevelTxt.text = "Lvl : " + HandsawLevel;
				HandsawCostTxt.text = HandsawCost + "$";
			} else {
				//set Handsaw default values
				HandsawCost = 100000000000;
				HandsawLevel = 0;
				HandsawCPS = 0;
				//lock Handsaw
				btnHandsaw.GetComponent<Button>().interactable = false;
				//Handsaw txt update
				HandsawCPSTxt.text = "C.P.S : " + HandsawCPS;
				HandsawLevelTxt.text = "Lvl : " + HandsawLevel;
				HandsawCostTxt.text = HandsawCost + "$";
			}

			//verify if Fence data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("FenceCost") && PlayerPrefs.HasKey ("FenceLevel") && PlayerPrefs.HasKey ("FenceCPS") && PlayerPrefs.HasKey ("FencePointsPerSecond")) {
				//retreive Fence data and convert it to decimal
				FenceCost = decimal.Parse (PlayerPrefs.GetString("FenceCost"));
				FenceLevel = decimal.Parse (PlayerPrefs.GetString("FenceLevel"));
				FenceCPS = decimal.Parse (PlayerPrefs.GetString("FenceCPS"));
				FencePointsPerSecond = decimal.Parse (PlayerPrefs.GetString("FencePointsPerSecond"));
				//add pre-existing Fence data to pointsPerSecond
				pointsPerSecond += FencePointsPerSecond;
				imgFence.SetActive(true);
				//verify to unlock next object
				if (FenceLevel >= 25) {
					btnDog.GetComponent<Button>().interactable = true;
				} else {
					btnDog.GetComponent<Button>().interactable = false;
				}
				//Fence txt update
				FenceCPSTxt.text = "C.P.S : " + FenceCPS;
				FenceLevelTxt.text = "Lvl : " + FenceLevel;
				FenceCostTxt.text = FenceCost + "$";
			} else {
				//set Fence default values
				FenceCost = 200000000000;
				FenceLevel = 0;
				FenceCPS = 0;
				//lock Fence
				btnFence.GetComponent<Button>().interactable = false;
				//Fence txt update
				FenceCPSTxt.text = "C.P.S : " + FenceCPS;
				FenceLevelTxt.text = "Lvl : " + FenceLevel;
				FenceCostTxt.text = FenceCost + "$";
			}

			//verify if Dog data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("DogCost") && PlayerPrefs.HasKey ("DogLevel") && PlayerPrefs.HasKey ("DogCPS") && PlayerPrefs.HasKey ("DogPointsPerSecond")) {
				//retreive Dog data and convert it to decimal
				DogCost = decimal.Parse (PlayerPrefs.GetString("DogCost"));
				DogLevel = decimal.Parse (PlayerPrefs.GetString("DogLevel"));
				DogCPS = decimal.Parse (PlayerPrefs.GetString("DogCPS"));
				DogPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("DogPointsPerSecond"));
				//add pre-existing Dog data to pointsPerSecond
				pointsPerSecond += DogPointsPerSecond;
				imgDog.SetActive(true);
				//verify to unlock next object
				if (DogLevel >= 25) {
					btnCat.GetComponent<Button>().interactable = true;
				} else {
					btnCat.GetComponent<Button>().interactable = false;
				}
				//Dog txt update
				DogCPSTxt.text = "C.P.S : " + DogCPS;
				DogLevelTxt.text = "Lvl : " + DogLevel;
				DogCostTxt.text = DogCost + "$";
			} else {
				//set Dog default values
				DogCost = 500000000000;
				DogLevel = 0;
				DogCPS = 0;
				//lock Dog
				btnDog.GetComponent<Button>().interactable = false;
				//Dog txt update
				DogCPSTxt.text = "C.P.S : " + DogCPS;
				DogLevelTxt.text = "Lvl : " + DogLevel;
				DogCostTxt.text = DogCost + "$";
			}

			//verify if Cat data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("CatCost") && PlayerPrefs.HasKey ("CatLevel") && PlayerPrefs.HasKey ("CatCPS") && PlayerPrefs.HasKey ("CatPointsPerSecond")) {
				//retreive Cat data and convert it to decimal
				CatCost = decimal.Parse (PlayerPrefs.GetString("CatCost"));
				CatLevel = decimal.Parse (PlayerPrefs.GetString("CatLevel"));
				CatCPS = decimal.Parse (PlayerPrefs.GetString("CatCPS"));
				CatPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("CatPointsPerSecond"));
				//add pre-existing Cat data to pointsPerSecond
				pointsPerSecond += CatPointsPerSecond;
				imgCat.SetActive(true);
				//verify to unlock next object
				if (CatLevel >= 25) {
					btnChicken.GetComponent<Button>().interactable = true;
				} else {
					btnChicken.GetComponent<Button>().interactable = false;
				}
				//Cat txt update
				CatCPSTxt.text = "C.P.S : " + CatCPS;
				CatLevelTxt.text = "Lvl : " + CatLevel;
				CatCostTxt.text = CatCost + "$";
			} else {
				//set Cat default values
				CatCost = 1000000000000;
				CatLevel = 0;
				CatCPS = 0;
				//lock Cat
				btnCat.GetComponent<Button>().interactable = false;
				//Cat txt update
				CatCPSTxt.text = "C.P.S : " + CatCPS;
				CatLevelTxt.text = "Lvl : " + CatLevel;
				CatCostTxt.text = CatCost + "$";
			}

			//verify if Chicken data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("ChickenCost") && PlayerPrefs.HasKey ("ChickenLevel") && PlayerPrefs.HasKey ("ChickenCPS") && PlayerPrefs.HasKey ("ChickenPointsPerSecond")) {
				//retreive Chicken data and convert it to decimal
				ChickenCost = decimal.Parse (PlayerPrefs.GetString("ChickenCost"));
				ChickenLevel = decimal.Parse (PlayerPrefs.GetString("ChickenLevel"));
				ChickenCPS = decimal.Parse (PlayerPrefs.GetString("ChickenCPS"));
				ChickenPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("ChickenPointsPerSecond"));
				//add pre-existing Chicken data to pointsPerSecond
				pointsPerSecond += ChickenPointsPerSecond;
				imgChicken.SetActive(true);
				//verify to unlock next object
				if (ChickenLevel >= 25) {
					btnPig.GetComponent<Button>().interactable = true;
				} else {
					btnPig.GetComponent<Button>().interactable = false;
				}
				//Chicken txt update
				ChickenCPSTxt.text = "C.P.S : " + ChickenCPS;
				ChickenLevelTxt.text = "Lvl : " + ChickenLevel;
				ChickenCostTxt.text = ChickenCost + "$";
			} else {
				//set Chicken default values
				ChickenCost = 2000000000000;
				ChickenLevel = 0;
				ChickenCPS = 0;
				//lock Chicken
				btnChicken.GetComponent<Button>().interactable = false;
				//Chicken txt update
				ChickenCPSTxt.text = "C.P.S : " + ChickenCPS;
				ChickenLevelTxt.text = "Lvl : " + ChickenLevel;
				ChickenCostTxt.text = ChickenCost + "$";
			}

			//verify if Pig data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("PigCost") && PlayerPrefs.HasKey ("PigLevel") && PlayerPrefs.HasKey ("PigCPS") && PlayerPrefs.HasKey ("PigPointsPerSecond")) {
				//retreive Pig data and convert it to decimal
				PigCost = decimal.Parse (PlayerPrefs.GetString("PigCost"));
				PigLevel = decimal.Parse (PlayerPrefs.GetString("PigLevel"));
				PigCPS = decimal.Parse (PlayerPrefs.GetString("PigCPS"));
				PigPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("PigPointsPerSecond"));
				//add pre-existing Pig data to pointsPerSecond
				pointsPerSecond += PigPointsPerSecond;
				imgPig.SetActive(true);
				//verify to unlock next object
				if (PigLevel >= 25) {
					btnSheep.GetComponent<Button>().interactable = true;
				} else {
					btnSheep.GetComponent<Button>().interactable = false;
				}
				//Pig txt update
				PigCPSTxt.text = "C.P.S : " + PigCPS;
				PigLevelTxt.text = "Lvl : " + PigLevel;
				PigCostTxt.text = PigCost + "$";
			} else {
				//set Pig default values
				PigCost = 4000000000000;
				PigLevel = 0;
				PigCPS = 0;
				//lock Pig
				btnPig.GetComponent<Button>().interactable = false;
				//Pig txt update
				PigCPSTxt.text = "C.P.S : " + PigCPS;
				PigLevelTxt.text = "Lvl : " + PigLevel;
				PigCostTxt.text = PigCost + "$";
			}

			//verify if Sheep data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("SheepCost") && PlayerPrefs.HasKey ("SheepLevel") && PlayerPrefs.HasKey ("SheepCPS") && PlayerPrefs.HasKey ("SheepPointsPerSecond")) {
				//retreive Sheep data and convert it to decimal
				SheepCost = decimal.Parse (PlayerPrefs.GetString("SheepCost"));
				SheepLevel = decimal.Parse (PlayerPrefs.GetString("SheepLevel"));
				SheepCPS = decimal.Parse (PlayerPrefs.GetString("SheepCPS"));
				SheepPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("SheepPointsPerSecond"));
				//add pre-existing Sheep data to pointsPerSecond
				pointsPerSecond += SheepPointsPerSecond;
				imgSheep.SetActive(true);
				//verify to unlock next object
				if (SheepLevel >= 25) {
					btnCow.GetComponent<Button>().interactable = true;
				} else {
					btnCow.GetComponent<Button>().interactable = false;
				}
				//Sheep txt update
				SheepCPSTxt.text = "C.P.S : " + SheepCPS;
				SheepLevelTxt.text = "Lvl : " + SheepLevel;
				SheepCostTxt.text = SheepCost + "$";
			} else {
				//set Sheep default values
				SheepCost = 8000000000000;
				SheepLevel = 0;
				SheepCPS = 0;
				//lock Sheep
				btnSheep.GetComponent<Button>().interactable = false;
				//Sheep txt update
				SheepCPSTxt.text = "C.P.S : " + SheepCPS;
				SheepLevelTxt.text = "Lvl : " + SheepLevel;
				SheepCostTxt.text = SheepCost + "$";
			}

			//verify if Cow data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("CowCost") && PlayerPrefs.HasKey ("CowLevel") && PlayerPrefs.HasKey ("CowCPS") && PlayerPrefs.HasKey ("CowPointsPerSecond")) {
				//retreive Cow data and convert it to decimal
				CowCost = decimal.Parse (PlayerPrefs.GetString("CowCost"));
				CowLevel = decimal.Parse (PlayerPrefs.GetString("CowLevel"));
				CowCPS = decimal.Parse (PlayerPrefs.GetString("CowCPS"));
				CowPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("CowPointsPerSecond"));
				//add pre-existing Cow data to pointsPerSecond
				pointsPerSecond += CowPointsPerSecond;
				imgCow.SetActive(true);
				//verify to unlock next object
				if (CowLevel >= 25) {
					btnHorse.GetComponent<Button>().interactable = true;
				} else {
					btnHorse.GetComponent<Button>().interactable = false;
				}
				//Cow txt update
				CowCPSTxt.text = "C.P.S : " + CowCPS;
				CowLevelTxt.text = "Lvl : " + CowLevel;
				CowCostTxt.text = CowCost + "$";
			} else {
				//set Cow default values
				CowCost = 16000000000000;
				CowLevel = 0;
				CowCPS = 0;
				//lock Cow
				btnCow.GetComponent<Button>().interactable = false;
				//Cow txt update
				CowCPSTxt.text = "C.P.S : " + CowCPS;
				CowLevelTxt.text = "Lvl : " + CowLevel;
				CowCostTxt.text = CowCost + "$";
			}

			//verify if Horse data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("HorseCost") && PlayerPrefs.HasKey ("HorseLevel") && PlayerPrefs.HasKey ("HorseCPS") && PlayerPrefs.HasKey ("HorsePointsPerSecond")) {
				//retreive Horse data and convert it to decimal
				HorseCost = decimal.Parse (PlayerPrefs.GetString("HorseCost"));
				HorseLevel = decimal.Parse (PlayerPrefs.GetString("HorseLevel"));
				HorseCPS = decimal.Parse (PlayerPrefs.GetString("HorseCPS"));
				HorsePointsPerSecond = decimal.Parse (PlayerPrefs.GetString("HorsePointsPerSecond"));
				//add pre-existing Horse data to pointsPerSecond
				pointsPerSecond += HorsePointsPerSecond;
				imgHorse.SetActive(true);
				//verify to unlock next object
				if (HorseLevel >= 25) {
					btnGoldPear.GetComponent<Button>().interactable = true;
				} else {
					btnGoldPear.GetComponent<Button>().interactable = false;
				}
				//Horse txt update
				HorseCPSTxt.text = "C.P.S : " + HorseCPS;
				HorseLevelTxt.text = "Lvl : " + HorseLevel;
				HorseCostTxt.text = HorseCost + "$";
			} else {
				//set Horse default values
				HorseCost = 25000000000000;
				HorseLevel = 0;
				HorseCPS = 0;
				//lock Horse
				btnHorse.GetComponent<Button>().interactable = false;
				//Horse txt update
				HorseCPSTxt.text = "C.P.S : " + HorseCPS;
				HorseLevelTxt.text = "Lvl : " + HorseLevel;
				HorseCostTxt.text = HorseCost + "$";
			}

			//verify if GoldPear data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("GoldPearCost") && PlayerPrefs.HasKey ("GoldPearLevel") && PlayerPrefs.HasKey ("GoldPearCPS") && PlayerPrefs.HasKey ("GoldPearPointsPerSecond")) {
				//retreive GoldPear data and convert it to decimal
				GoldPearCost = decimal.Parse (PlayerPrefs.GetString("GoldPearCost"));
				GoldPearLevel = decimal.Parse (PlayerPrefs.GetString("GoldPearLevel"));
				GoldPearCPS = decimal.Parse (PlayerPrefs.GetString("GoldPearCPS"));
				GoldPearPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("GoldPearPointsPerSecond"));
				//add pre-existing GoldPear data to pointsPerSecond
				pointsPerSecond += GoldPearPointsPerSecond;
				imgGoldPear.SetActive(true);
				//verify to unlock next object
				if (GoldPearLevel >= 25) {
					btnBarn.GetComponent<Button>().interactable = true;
				} else {
					btnBarn.GetComponent<Button>().interactable = false;
				}
				//GoldPear txt update
				GoldPearCPSTxt.text = "C.P.S : " + GoldPearCPS;
				GoldPearLevelTxt.text = "Lvl : " + GoldPearLevel;
				GoldPearCostTxt.text = GoldPearCost + "$";
			} else {
				//set GoldPear default values
				GoldPearCost = 40000000000000;
				GoldPearLevel = 0;
				GoldPearCPS = 0;
				//lock GoldPear
				btnGoldPear.GetComponent<Button>().interactable = false;
				//GoldPear txt update
				GoldPearCPSTxt.text = "C.P.S : " + GoldPearCPS;
				GoldPearLevelTxt.text = "Lvl : " + GoldPearLevel;
				GoldPearCostTxt.text = GoldPearCost + "$";
			}

			//verify if Barn data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("BarnCost") && PlayerPrefs.HasKey ("BarnLevel") && PlayerPrefs.HasKey ("BarnCPS") && PlayerPrefs.HasKey ("BarnPointsPerSecond")) {
				//retreive Barn data and convert it to decimal
				BarnCost = decimal.Parse (PlayerPrefs.GetString("BarnCost"));
				BarnLevel = decimal.Parse (PlayerPrefs.GetString("BarnLevel"));
				BarnCPS = decimal.Parse (PlayerPrefs.GetString("BarnCPS"));
				BarnPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("BarnPointsPerSecond"));
				//add pre-existing Barn data to pointsPerSecond
				pointsPerSecond += BarnPointsPerSecond;
				imgBarn.SetActive(true);
				//verify to unlock next object
				if (BarnLevel >= 25) {
					btnTractor.GetComponent<Button>().interactable = true;
				} else {
					btnTractor.GetComponent<Button>().interactable = false;
				}
				//Barn txt update
				BarnCPSTxt.text = "C.P.S : " + BarnCPS;
				BarnLevelTxt.text = "Lvl : " + BarnLevel;
				BarnCostTxt.text = BarnCost + "$";
			} else {
				//set Barn default values
				BarnCost = 80000000000000;
				BarnLevel = 0;
				BarnCPS = 0;
				//lock Barn
				btnBarn.GetComponent<Button>().interactable = false;
				//Barn txt update
				BarnCPSTxt.text = "C.P.S : " + BarnCPS;
				BarnLevelTxt.text = "Lvl : " + BarnLevel;
				BarnCostTxt.text = BarnCost + "$";
			}

			//verify if Tractor data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("TractorCost") && PlayerPrefs.HasKey ("TractorLevel") && PlayerPrefs.HasKey ("TractorCPS") && PlayerPrefs.HasKey ("TractorPointsPerSecond")) {
				//retreive Tractor data and convert it to decimal
				TractorCost = decimal.Parse (PlayerPrefs.GetString("TractorCost"));
				TractorLevel = decimal.Parse (PlayerPrefs.GetString("TractorLevel"));
				TractorCPS = decimal.Parse (PlayerPrefs.GetString("TractorCPS"));
				TractorPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("TractorPointsPerSecond"));
				//add pre-existing Tractor data to pointsPerSecond
				pointsPerSecond += TractorPointsPerSecond;
				imgTractor.SetActive(true);
				//verify to unlock next object
				if (TractorLevel >= 25) {
					btnMill.GetComponent<Button>().interactable = true;
				} else {
					btnMill.GetComponent<Button>().interactable = false;
				}
				//Tractor txt update
				TractorCPSTxt.text = "C.P.S : " + TractorCPS;
				TractorLevelTxt.text = "Lvl : " + TractorLevel;
				TractorCostTxt.text = TractorCost + "$";
			} else {
				//set Tractor default values
				TractorCost = 150000000000000;
				TractorLevel = 0;
				TractorCPS = 0;
				//lock Tractor
				btnTractor.GetComponent<Button>().interactable = false;
				//Tractor txt update
				TractorCPSTxt.text = "C.P.S : " + TractorCPS;
				TractorLevelTxt.text = "Lvl : " + TractorLevel;
				TractorCostTxt.text = TractorCost + "$";
			}

			//verify if Mill data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("MillCost") && PlayerPrefs.HasKey ("MillLevel") && PlayerPrefs.HasKey ("MillCPS") && PlayerPrefs.HasKey ("MillPointsPerSecond")) {
				//retreive Mill data and convert it to decimal
				MillCost = decimal.Parse (PlayerPrefs.GetString("MillCost"));
				MillLevel = decimal.Parse (PlayerPrefs.GetString("MillLevel"));
				MillCPS = decimal.Parse (PlayerPrefs.GetString("MillCPS"));
				MillPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("MillPointsPerSecond"));
				//add pre-existing Mill data to pointsPerSecond
				pointsPerSecond += MillPointsPerSecond;
				imgMill.SetActive(true);
				//verify to unlock next object
				if (MillLevel >= 25) {
					btnGoldApple.GetComponent<Button>().interactable = true;
				} else {
					btnGoldApple.GetComponent<Button>().interactable = false;
				}
				//Mill txt update
				MillCPSTxt.text = "C.P.S : " + MillCPS;
				MillLevelTxt.text = "Lvl : " + MillLevel;
				MillCostTxt.text = MillCost + "$";
			} else {
				//set Mill default values
				MillCost = 500000000000000;
				MillLevel = 0;
				MillCPS = 0;
				//lock Mill
				btnMill.GetComponent<Button>().interactable = false;
				//Mill txt update
				MillCPSTxt.text = "C.P.S : " + MillCPS;
				MillLevelTxt.text = "Lvl : " + MillLevel;
				MillCostTxt.text = MillCost + "$";
			}

			//verify if GoldApple data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("GoldAppleCost") && PlayerPrefs.HasKey ("GoldAppleLevel") && PlayerPrefs.HasKey ("GoldAppleCPS") && PlayerPrefs.HasKey ("GoldApplePointsPerSecond")) {
				//retreive GoldApple data and convert it to decimal
				GoldAppleCost = decimal.Parse (PlayerPrefs.GetString("GoldAppleCost"));
				GoldAppleLevel = decimal.Parse (PlayerPrefs.GetString("GoldAppleLevel"));
				GoldAppleCPS = decimal.Parse (PlayerPrefs.GetString("GoldAppleCPS"));
				GoldApplePointsPerSecond = decimal.Parse (PlayerPrefs.GetString("GoldApplePointsPerSecond"));
				//add pre-existing GoldApple data to pointsPerSecond
				pointsPerSecond += GoldApplePointsPerSecond;
				imgGoldApple.SetActive(true);
				//GoldApple txt update
				GoldAppleCPSTxt.text = "C.P.S : " + GoldAppleCPS;
				GoldAppleLevelTxt.text = "Lvl : " + GoldAppleLevel;
				GoldAppleCostTxt.text = GoldAppleCost + "$";
			} else {
				//set GoldApple default values
				GoldAppleCost = 10000000000000000;
				GoldAppleLevel = 0;
				GoldAppleCPS = 0;
				//lock GoldApple
				btnGoldApple.GetComponent<Button>().interactable = false;
				//GoldApple txt update
				GoldAppleCPSTxt.text = "C.P.S : " + GoldAppleCPS;
				GoldAppleLevelTxt.text = "Lvl : " + GoldAppleLevel;
				GoldAppleCostTxt.text = GoldAppleCost + "$";
			}

			//-------------------- Gift --------------------
			if (PlayerPrefs.HasKey ("GiftReceived")) {
				btnGift.GetComponent<Button>().interactable = false;
			} else {
				gift = true;
			}

			//-------------------- Task1 --------------------
			if (PlayerPrefs.HasKey ("Task1")) {
				btnTask1.GetComponent<Button>().interactable = false;
			}

			//-------------------- Task2 --------------------
			if (PlayerPrefs.HasKey ("Task2")) {
				btnTask2.GetComponent<Button>().interactable = false;
			}

			//-------------------- Task3 --------------------
			if (PlayerPrefs.HasKey ("Task3")) {
				btnTask3.GetComponent<Button>().interactable = false;
			}

			//-------------------- Task4 --------------------
			if (PlayerPrefs.HasKey ("Task4")) {
				btnTask4.GetComponent<Button>().interactable = false;
			}

			//-------------------- Task5 --------------------
			if (PlayerPrefs.HasKey ("Task5")) {
				btnTask5.GetComponent<Button>().interactable = false;
			}

			//-------------------- Task6 --------------------
			if (PlayerPrefs.HasKey ("Task6")) {
				btnTask6.GetComponent<Button>().interactable = false;
			}

			//-------------------- Task7 --------------------
			if (PlayerPrefs.HasKey ("Task7")) {
				btnTask7.GetComponent<Button>().interactable = false;
			}

			//-------------------- Task8 --------------------
			if (PlayerPrefs.HasKey ("Task8")) {
				btnTask8.GetComponent<Button>().interactable = false;
			}

		} else {
			//IF THERE'S NO PREVIOUS GAME, SET THOSE OPTIONS
			//Show welcome message at first launch
			WelcomeActive = true;
			panelWelcome.SetActive (true);
			gift = true;

			//set seeds default values
			seedsCost = 100;
			seedsLevel = 0;
			seedsCPS = 0;
			//seeds txt update
			seedsCPSTxt.text = "C.P.S : " + seedsCPS;
			seedsLevelTxt.text = "Lvl : " + seedsLevel;
			seedsCostTxt.text = seedsCost + "$";

			//set flowers default values
			flowersCost = 10000;
			flowersLevel = 0;
			flowersCPS = 0;
			//lock flowers
			btnFlowers.GetComponent<Button>().interactable = false;
			//flowers txt update
			flowersCPSTxt.text = "C.P.S : " + flowersCPS;
			flowersLevelTxt.text = "Lvl : " + flowersLevel;
			flowersCostTxt.text = flowersCost + "$";

			//set tomato default values
			tomatoCost = 100000;
			tomatoLevel = 0;
			tomatoCPS = 0;
			//lock tomato
			btnTomato.GetComponent<Button>().interactable = false;
			//tomato txt update
			tomatoCPSTxt.text = "C.P.S : " + tomatoCPS;
			tomatoLevelTxt.text = "Lvl : " + tomatoLevel;
			tomatoCostTxt.text = tomatoCost + "$";

			//set Tree default values
			TreeCost = 500000;
			TreeLevel = 0;
			TreeCPS = 0;
			//lock Tree
			btnTree.GetComponent<Button>().interactable = false;
			//Tree txt update
			TreeCPSTxt.text = "C.P.S : " + TreeCPS;
			TreeLevelTxt.text = "Lvl : " + TreeLevel;
			TreeCostTxt.text = TreeCost + "$";

			//set GreenApple default values
			GreenAppleCost = 2000000;
			GreenAppleLevel = 0;
			GreenAppleCPS = 0;
			//lock GreenApple
			btnGreenApple.GetComponent<Button>().interactable = false;
			//GreenApple txt update
			GreenAppleCPSTxt.text = "C.P.S : " + GreenAppleCPS;
			GreenAppleLevelTxt.text = "Lvl : " + GreenAppleLevel;
			GreenAppleCostTxt.text = GreenAppleCost + "$";

			//set GreenApple default values
			GreenAppleCost = 50000000;
			GreenAppleLevel = 0;
			GreenAppleCPS = 0;
			//lock GreenApple
			btnGreenApple.GetComponent<Button>().interactable = false;
			//GreenApple txt update
			GreenAppleCPSTxt.text = "C.P.S : " + GreenAppleCPS;
			GreenAppleLevelTxt.text = "Lvl : " + GreenAppleLevel;
			GreenAppleCostTxt.text = GreenAppleCost + "$";

			//set Carrot default values
			CarrotCost = 10000000;
			CarrotLevel = 0;
			CarrotCPS = 0;
			//lock Carrot
			btnCarrot.GetComponent<Button>().interactable = false;
			//Carrot txt update
			CarrotCPSTxt.text = "C.P.S : " + CarrotCPS;
			CarrotLevelTxt.text = "Lvl : " + CarrotLevel;
			CarrotCostTxt.text = CarrotCost + "$";

			//set GreenPear default values
			GreenPearCost = 50000000;
			GreenPearLevel = 0;
			GreenPearCPS = 0;
			//lock GreenPear
			btnGreenPear.GetComponent<Button>().interactable = false;
			//GreenPear txt update
			GreenPearCPSTxt.text = "C.P.S : " + GreenPearCPS;
			GreenPearLevelTxt.text = "Lvl : " + GreenPearLevel;
			GreenPearCostTxt.text = GreenPearCost + "$";

			//set Corn default values
			CornCost = 300000000;
			CornLevel = 0;
			CornCPS = 0;
			//lock Corn
			btnCorn.GetComponent<Button>().interactable = false;
			//Corn txt update
			CornCPSTxt.text = "C.P.S : " + CornCPS;
			CornLevelTxt.text = "Lvl : " + CornLevel;
			CornCostTxt.text = CornCost + "$";

			//set RedApple default values
			RedAppleCost = 700000000;
			RedAppleLevel = 0;
			RedAppleCPS = 0;
			//lock RedApple
			btnRedApple.GetComponent<Button>().interactable = false;
			//RedApple txt update
			RedAppleCPSTxt.text = "C.P.S : " + RedAppleCPS;
			RedAppleLevelTxt.text = "Lvl : " + RedAppleLevel;
			RedAppleCostTxt.text = RedAppleCost + "$";

			//set Watermelon default values
			WatermelonCost = 2000000000;
			WatermelonLevel = 0;
			WatermelonCPS = 0;
			//lock Watermelon
			btnWatermelon.GetComponent<Button>().interactable = false;
			//Watermelon txt update
			WatermelonCPSTxt.text = "C.P.S : " + WatermelonCPS;
			WatermelonLevelTxt.text = "Lvl : " + WatermelonLevel;
			WatermelonCostTxt.text = WatermelonCost + "$";

			//set RedPear default values
			RedPearCost = 4000000000;
			RedPearLevel = 0;
			RedPearCPS = 0;
			//lock RedPear
			btnRedPear.GetComponent<Button>().interactable = false;
			//RedPear txt update
			RedPearCPSTxt.text = "C.P.S : " + RedPearCPS;
			RedPearLevelTxt.text = "Lvl : " + RedPearLevel;
			RedPearCostTxt.text = RedPearCost + "$";

			//set Pumpkin default values
			PumpkinCost = 6000000000;
			PumpkinLevel = 0;
			PumpkinCPS = 0;
			//lock Pumpkin
			btnPumpkin.GetComponent<Button>().interactable = false;
			//Pumpkin txt update
			PumpkinCPSTxt.text = "C.P.S : " + PumpkinCPS;
			PumpkinLevelTxt.text = "Lvl : " + PumpkinLevel;
			PumpkinCostTxt.text = PumpkinCost + "$";

			//set Wrench default values
			WrenchCost = 10000000000;
			WrenchLevel = 0;
			WrenchCPS = 0;
			//lock Wrench
			btnWrench.GetComponent<Button>().interactable = false;
			//Wrench txt update
			WrenchCPSTxt.text = "C.P.S : " + WrenchCPS;
			WrenchLevelTxt.text = "Lvl : " + WrenchLevel;
			WrenchCostTxt.text = WrenchCost + "$";

			//set Screwdriver default values
			ScrewdriverCost = 30000000000;
			ScrewdriverLevel = 0;
			ScrewdriverCPS = 0;
			//lock Screwdriver
			btnScrewdriver.GetComponent<Button>().interactable = false;
			//Screwdriver txt update
			ScrewdriverCPSTxt.text = "C.P.S : " + ScrewdriverCPS;
			ScrewdriverLevelTxt.text = "Lvl : " + ScrewdriverLevel;
			ScrewdriverCostTxt.text = ScrewdriverCost + "$";

			//set Hammer default values
			HammerCost = 50000000000;
			HammerLevel = 0;
			HammerCPS = 0;
			//lock Hammer
			btnHammer.GetComponent<Button>().interactable = false;
			//Hammer txt update
			HammerCPSTxt.text = "C.P.S : " + HammerCPS;
			HammerLevelTxt.text = "Lvl : " + HammerLevel;
			HammerCostTxt.text = HammerCost + "$";

			//set Handsaw default values
			HandsawCost = 100000000000;
			HandsawLevel = 0;
			HandsawCPS = 0;
			//lock Handsaw
			btnHandsaw.GetComponent<Button>().interactable = false;
			//Handsaw txt update
			HandsawCPSTxt.text = "C.P.S : " + HandsawCPS;
			HandsawLevelTxt.text = "Lvl : " + HandsawLevel;
			HandsawCostTxt.text = HandsawCost + "$";

			//set Fence default values
			FenceCost = 200000000000;
			FenceLevel = 0;
			FenceCPS = 0;
			//lock Fence
			btnFence.GetComponent<Button>().interactable = false;
			//Fence txt update
			FenceCPSTxt.text = "C.P.S : " + FenceCPS;
			FenceLevelTxt.text = "Lvl : " + FenceLevel;
			FenceCostTxt.text = FenceCost + "$";

			//set Dog default values
			DogCost = 500000000000;
			DogLevel = 0;
			DogCPS = 0;
			//lock Dog
			btnDog.GetComponent<Button>().interactable = false;
			//Dog txt update
			DogCPSTxt.text = "C.P.S : " + DogCPS;
			DogLevelTxt.text = "Lvl : " + DogLevel;
			DogCostTxt.text = DogCost + "$";

			//set Cat default values
			CatCost = 1000000000000;
			CatLevel = 0;
			CatCPS = 0;
			//lock Cat
			btnCat.GetComponent<Button>().interactable = false;
			//Cat txt update
			CatCPSTxt.text = "C.P.S : " + CatCPS;
			CatLevelTxt.text = "Lvl : " + CatLevel;
			CatCostTxt.text = CatCost + "$";

			//set Chicken default values
			ChickenCost = 2000000000000;
			ChickenLevel = 0;
			ChickenCPS = 0;
			//lock Chicken
			btnChicken.GetComponent<Button>().interactable = false;
			//Chicken txt update
			ChickenCPSTxt.text = "C.P.S : " + ChickenCPS;
			ChickenLevelTxt.text = "Lvl : " + ChickenLevel;
			ChickenCostTxt.text = ChickenCost + "$";

			//set Pig default values
			PigCost = 4000000000000;
			PigLevel = 0;
			PigCPS = 0;
			//lock Pig
			btnPig.GetComponent<Button>().interactable = false;
			//Pig txt update
			PigCPSTxt.text = "C.P.S : " + PigCPS;
			PigLevelTxt.text = "Lvl : " + PigLevel;
			PigCostTxt.text = PigCost + "$";

			//set Sheep default values
			SheepCost = 8000000000000;
			SheepLevel = 0;
			SheepCPS = 0;
			//lock Sheep
			btnSheep.GetComponent<Button>().interactable = false;
			//Sheep txt update
			SheepCPSTxt.text = "C.P.S : " + SheepCPS;
			SheepLevelTxt.text = "Lvl : " + SheepLevel;
			SheepCostTxt.text = SheepCost + "$";

			//set Cow default values
			CowCost = 16000000000000;
			CowLevel = 0;
			CowCPS = 0;
			//lock Cow
			btnCow.GetComponent<Button>().interactable = false;
			//Cow txt update
			CowCPSTxt.text = "C.P.S : " + CowCPS;
			CowLevelTxt.text = "Lvl : " + CowLevel;
			CowCostTxt.text = CowCost + "$";

			//set Horse default values
			HorseCost = 25000000000000;
			HorseLevel = 0;
			HorseCPS = 0;
			//lock Horse
			btnHorse.GetComponent<Button>().interactable = false;
			//Horse txt update
			HorseCPSTxt.text = "C.P.S : " + HorseCPS;
			HorseLevelTxt.text = "Lvl : " + HorseLevel;
			HorseCostTxt.text = HorseCost + "$";

			//set GoldPear default values
			GoldPearCost = 40000000000000;
			GoldPearLevel = 0;
			GoldPearCPS = 0;
			//lock GoldPear
			btnGoldPear.GetComponent<Button>().interactable = false;
			//GoldPear txt update
			GoldPearCPSTxt.text = "C.P.S : " + GoldPearCPS;
			GoldPearLevelTxt.text = "Lvl : " + GoldPearLevel;
			GoldPearCostTxt.text = GoldPearCost + "$";

			//set Barn default values
			BarnCost = 80000000000000;
			BarnLevel = 0;
			BarnCPS = 0;
			//lock Barn
			btnBarn.GetComponent<Button>().interactable = false;
			//Barn txt update
			BarnCPSTxt.text = "C.P.S : " + BarnCPS;
			BarnLevelTxt.text = "Lvl : " + BarnLevel;
			BarnCostTxt.text = BarnCost + "$";

			//set Tractor default values
			TractorCost = 150000000000000;
			TractorLevel = 0;
			TractorCPS = 0;
			//lock Tractor
			btnTractor.GetComponent<Button>().interactable = false;
			//Tractor txt update
			TractorCPSTxt.text = "C.P.S : " + TractorCPS;
			TractorLevelTxt.text = "Lvl : " + TractorLevel;
			TractorCostTxt.text = TractorCost + "$";

			//set Mill default values
			MillCost = 500000000000000;
			MillLevel = 0;
			MillCPS = 0;
			//lock Mill
			btnMill.GetComponent<Button>().interactable = false;
			//Mill txt update
			MillCPSTxt.text = "C.P.S : " + MillCPS;
			MillLevelTxt.text = "Lvl : " + MillLevel;
			MillCostTxt.text = MillCost + "$";

			//set GoldApple default values
			GoldAppleCost = 10000000000000000;
			GoldAppleLevel = 0;
			GoldAppleCPS = 0;
			//lock GoldApple
			btnGoldApple.GetComponent<Button>().interactable = false;
			//GoldApple txt update
			GoldAppleCPSTxt.text = "C.P.S : " + GoldAppleCPS;
			GoldAppleLevelTxt.text = "Lvl : " + GoldAppleLevel;
			GoldAppleCostTxt.text = GoldAppleCost + "$";
		}
	}

	void Start () {
		m_source = gameObject.GetComponent<AudioSource>();
	}

	void Update () {
		//detect a mouse clik when no other panel is active
		if (Input.GetMouseButtonDown(0) && TaskActive == false && ShopActive == false && WelcomeActive == false && instructionsActive == false) {
			m_source.clip = clickMoney;
			m_source.Play();
			//add to score
			scoreCount++;
			//keep track of how much touch you made
			touchCount++;

			//money animation generation
			Vector3 p = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 10f));
			var addTwoY = p.y + 2;
			var remTwoY = p.y - 2;
			var addTwoX = p.x + 2;
			var remTwoX = p.x - 2;
			RandomGoToPositionX = Random.Range(remTwoX, addTwoX);
			RandomGoToPositionY = Random.Range(remTwoY, addTwoY);
			spawnImgMoney = (GameObject)Instantiate (imgMoney, new Vector3 (p.x, p.y, 0f), Quaternion.identity);
			LeanTween.alpha (spawnImgMoney, 0f, 0.5f);
			LeanTween.moveLocalX (spawnImgMoney, RandomGoToPositionX, 0.5f);
			LeanTween.moveLocalY (spawnImgMoney, RandomGoToPositionY, 0.5f);
			Destroy (spawnImgMoney, 0.5f);
		}

		if(Time.time - lastUpdate >= 1f){
			scoreCount += pointsPerSecond;
			lastUpdate = Time.time;
		}


		//------------------------------------------------ TASK ------------------------------------------------
		//Initialisation of task goals
		taskResult1 = 20000000;
		taskResult2 = 1;
		taskResult3 = 1;
		taskResult4 = 86400;
		taskResult5 = 10000;
		taskResult6 = 40;
		taskResult7 = 1;
		taskResult8 = 500000;

		taskCompleted1 = false;
		taskCompleted2 = false;
		taskCompleted3 = false;
		taskCompleted4 = false;
		taskCompleted5 = false;
		taskCompleted6 = false;
		taskCompleted7 = false;
		taskCompleted8 = false;

		//-------------------- TASK1 --------------------
		if (scoreCount >= taskResult1) {
			txtTask1.text = "Done!";
			imgToDo1.SetActive (false);
			imgCompleted1.SetActive (true);
			imgColor1.GetComponent<Image>().color = new Color32(138,197,97,255);
			taskCompleted1 = true;
		} else {
			txtTask1.text = scoreCount + " / " + taskResult1;
		}

		//-------------------- TASK2 --------------------
		if (RedAppleLevel >= taskResult2) {
			txtTask2.text = "Done!";
			imgToDo2.SetActive (false);
			imgCompleted2.SetActive (true);
			imgColor2.GetComponent<Image>().color = new Color32(138,197,97,255);
			taskCompleted2 = true;
		} else {
			txtTask2.text = RedAppleLevel + " / " + taskResult2;
		}

		//-------------------- TASK3 --------------------
		if (PigLevel >= taskResult3) {
			txtTask3.text = "Done!";
			imgToDo3.SetActive (false);
			imgCompleted3.SetActive (true);
			imgColor3.GetComponent<Image>().color = new Color32(138,197,97,255);
			taskCompleted3 = true;
		} else {
			txtTask3.text = PigLevel + " / " + taskResult3;
		}

		//-------------------- TASK4 --------------------
		if (touchCount >= taskResult4) {
			txtTask4.text = "Done!";
			imgToDo4.SetActive (false);
			imgCompleted4.SetActive (true);
			imgColor4.GetComponent<Image>().color = new Color32(138,197,97,255);
			taskCompleted4 = true;
		} else {
			txtTask4.text = touchCount + " / " + taskResult4;
		}

		//-------------------- TASK5 --------------------
		if (scoreCount >= taskResult5) {
			txtTask5.text = "Done!";
			imgToDo5.SetActive (false);
			imgCompleted5.SetActive (true);
			imgColor5.GetComponent<Image>().color = new Color32(138,197,97,255);
			taskCompleted5 = true;
		} else {
			txtTask5.text = scoreCount + " / " + taskResult5;
		}

		//-------------------- TASK6 --------------------
		if (HammerLevel >= taskResult6) {
			txtTask6.text = "Done!";
			imgToDo6.SetActive (false);
			imgCompleted6.SetActive (true);
			imgColor6.GetComponent<Image>().color = new Color32(138,197,97,255);
			taskCompleted6 = true;
		} else {
			txtTask6.text = HammerLevel + " / " + taskResult6;
		}

		//-------------------- TASK7 --------------------
		if (DogLevel >= taskResult7) {
			txtTask7.text = "Done!";
			imgToDo7.SetActive (false);
			imgCompleted7.SetActive (true);
			imgColor7.GetComponent<Image>().color = new Color32(138,197,97,255);
			taskCompleted7 = true;
		} else {
			txtTask7.text = DogLevel + " / " + taskResult7;
		}

		//-------------------- TASK8 --------------------
		if (touchCount >= taskResult8) {
			txtTask8.text = "Done!";
			imgToDo8.SetActive (false);
			imgCompleted8.SetActive (true);
			imgColor8.GetComponent<Image>().color = new Color32(138,197,97,255);
			taskCompleted8 = true;
		} else {
			txtTask8.text = touchCount + " / " + taskResult8;
		}

		//Return to menu
		if (Input.GetKey(KeyCode.Escape))
		{
			PlayerPrefs.Save ();
			SceneManager.LoadScene(0);
		}

		//update score
		scoreText.text = " " + scoreCount + " ";
		string mymoney = scoreCount.ToString ();
		PlayerPrefs.SetString ("Score", mymoney);
		PlayerPrefs.Save();
	}

	//-------------------------------------------------  Task  -------------------------------------------------
	//--------------------------  Gift  --------------------------
	public void Gift () {
		if (gift == true) {
			m_source.clip = btnClick;
			m_source.Play();
			scoreCount += 100;
			btnGift.GetComponent<Button>().interactable = false;
			PlayerPrefs.SetString("GiftReceived", "GiftReceived");
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}

	}
	//--------------------------  Task1  --------------------------gift = true;
	public void Task1 () {
		if (taskCompleted1 == true) {
			m_source.clip = btnClick;
			m_source.Play();
			scoreCount += 1000000;
			btnTask1.GetComponent<Button>().interactable = false;
			PlayerPrefs.SetString("Task1", "Received");
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
	}
	//--------------------------  Task2  --------------------------
	public void Task2 () {
		if (taskCompleted2 == true) {
			m_source.clip = btnClick;
			m_source.Play();
			scoreCount += 15000000;
			btnTask2.GetComponent<Button>().interactable = false;
			PlayerPrefs.SetString("Task2", "Received");
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
	}
	//--------------------------  Task3  --------------------------
	public void Task3 () {
		if (taskCompleted3 == true) {
			m_source.clip = btnClick;
			m_source.Play();
			scoreCount += 2500000000000;
			btnTask3.GetComponent<Button>().interactable = false;
			PlayerPrefs.SetString("Task3", "Received");
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
	}
	//--------------------------  Task4  --------------------------
	public void Task4 () {
		if (taskCompleted4 == true) {
			m_source.clip = btnClick;
			m_source.Play();
			scoreCount += 86400;
			btnTask4.GetComponent<Button>().interactable = false;
			PlayerPrefs.SetString("Task4", "Received");
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
	}
	//--------------------------  Task5  --------------------------
	public void Task5 () {
		if (taskCompleted5 == true) {
			m_source.clip = btnClick;
			m_source.Play();
			scoreCount += 10000;
			btnTask5.GetComponent<Button>().interactable = false;
			PlayerPrefs.SetString("Task5", "Received");
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
	}
	//--------------------------  Task6  --------------------------
	public void Task6 () {
		if (taskCompleted6 == true) {
			m_source.clip = btnClick;
			m_source.Play();
			scoreCount += 5000000000000;
			btnTask6.GetComponent<Button>().interactable = false;
			PlayerPrefs.SetString("Task6", "Received");
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
	}
	//--------------------------  Task7  --------------------------
	public void Task7 () {
		if (taskCompleted7 == true) {
			m_source.clip = btnClick;
			m_source.Play();
			scoreCount += 250000000000;
			btnTask7.GetComponent<Button>().interactable = false;
			PlayerPrefs.SetString("Task7", "Received");
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
	}
	//--------------------------  Task8  --------------------------
	public void Task8 () {
		if (taskCompleted8 == true) {
			m_source.clip = btnClick;
			m_source.Play();
			scoreCount += 500000000000;
			btnTask8.GetComponent<Button>().interactable = false;
			PlayerPrefs.SetString("Task8", "Received");
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
	}

	//btnShowInstructions showing
	public void OnBtnShowInstructionsClick () {
		m_source.clip = btnClick;
		m_source.Play();
		instructionsActive = true;
		WelcomeActive = false;
		panelWelcome.SetActive (false);
		imgNotepad.SetActive(true);
		panelInstructions.SetActive(true);
		btnInstructions.SetActive(true);
		ShopActive = false;
		TaskActive = false;
		scrollViewShop.SetActive(false);
		scrollViewTask.SetActive(false);
	}

	//btnSkipInstructions showing
	public void OnBtnSkipInstructionsClick () {
		m_source.clip = btnClick;
		m_source.Play();
		instructionsActive = false;
		WelcomeActive = false;
		panelWelcome.SetActive(false);
		imgNotepad.SetActive(false);
		panelInstructions.SetActive(false);
		btnInstructions.SetActive(false);
	}

	//notepad task click
	public void OnBtnTaskClick () {
		m_source.clip = btnClick;
		m_source.Play();
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

	//notepad shop click
	public void OnBtnShopClick () {
		m_source.clip = btnClick;
		m_source.Play();
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

	//Recalculate pointsPerSecond
	public void RecalPtsPerSec () {
		pointsPerSecond = seedsPointsPerSecond + FlowersPointsPerSecond + TomatoPointsPerSecond + TreePointsPerSecond + GreenApplePointsPerSecond + CarrotPointsPerSecond + GreenPearPointsPerSecond + CornPointsPerSecond + RedApplePointsPerSecond + WatermelonPointsPerSecond + RedPearPointsPerSecond + PumpkinPointsPerSecond + WrenchPointsPerSecond + ScrewdriverPointsPerSecond + HammerPointsPerSecond + HandsawPointsPerSecond + FencePointsPerSecond + DogPointsPerSecond + CatPointsPerSecond + ChickenPointsPerSecond + PigPointsPerSecond + SheepPointsPerSecond + CowPointsPerSecond + HorsePointsPerSecond + GoldPearPointsPerSecond + BarnPointsPerSecond + TractorPointsPerSecond + MillPointsPerSecond + GoldApplePointsPerSecond;
	}

	//-------------------------------------------------  Shop  -------------------------------------------------
	//--------------------------  seeds  --------------------------
	public void BuySeeds () {
		//check for the money available
		if (scoreCount >= seedsCost) {
			m_source.clip = btnClick;
			m_source.Play();
			scoreCount -= seedsCost;
			seedsLevel += 1;
			seedsCPS = seedsCPS + 1;
			seedsPointsPerSecond = seedsCPS;
			seedsCost += 50;
			imgSeeds.SetActive(true);
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
		//enable the flowers
		if (seedsLevel >= 25) {
			btnFlowers.GetComponent<Button>().interactable = true;
		}
		//seeds txt update
		seedsCPSTxt.text = "C.P.S : " + seedsCPS;
		seedsLevelTxt.text = "Lvl : " + seedsLevel;
		seedsCostTxt.text = seedsCost + "$";
		//convert seeds data to string to save in PlayerPrefs
		string seedsCPSSave = seedsCPS.ToString ();
		string seedsLevelSave = seedsLevel.ToString ();
		string seedsCostSave = seedsCost.ToString ();
		string seedsPointsPerSecondSave = seedsPointsPerSecond.ToString ();
		//save seeds data to PlayerPrefs
		PlayerPrefs.SetString ("seedsCPS", seedsCPSSave);
		PlayerPrefs.SetString ("seedsLevel", seedsLevelSave);
		PlayerPrefs.SetString ("seedsCost", seedsCostSave);
		PlayerPrefs.SetString ("seedsPointsPerSecond", seedsPointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}

	//--------------------------  flowers  --------------------------
	public void BuyFlowers () {
		if (seedsLevel >= 25) {
			//check for the money available
			if (scoreCount >= flowersCost) {
				m_source.clip = btnClick;
				m_source.Play();
				scoreCount -= flowersCost;
				flowersLevel += 1;
				flowersCPS = flowersCPS + 3;
				FlowersPointsPerSecond = flowersCPS;
				flowersCost += 175;
				imgFlowers.SetActive(true);
			} else {
				m_source.clip = btnError;
				m_source.Play();
			}
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
		//enable the tomato
		if (flowersLevel >= 25) {
			btnTomato.GetComponent<Button>().interactable = true;
		}
		//flowers txt update
		flowersCPSTxt.text = "C.P.S : " + flowersCPS;
		flowersLevelTxt.text = "Lvl : " + flowersLevel;
		flowersCostTxt.text = flowersCost + "$";
		//convert flowers data to string to save in PlayerPrefs
		string flowersCPSSave = flowersCPS.ToString ();
		string flowersLevelSave = flowersLevel.ToString ();
		string flowersCostSave = flowersCost.ToString ();
		string FlowersPointsPerSecondSave = FlowersPointsPerSecond.ToString ();
		//save flowers data to PlayerPrefs
		PlayerPrefs.SetString ("flowersCPS", flowersCPSSave);
		PlayerPrefs.SetString ("flowersLevel", flowersLevelSave);
		PlayerPrefs.SetString ("flowersCost", flowersCostSave);
		PlayerPrefs.SetString ("flowersPointsPerSecond", FlowersPointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}

	//--------------------------  tomato  --------------------------
	public void BuyTomato () {
		if (flowersLevel >= 25) {
			//check for the money available
			if (scoreCount >= tomatoCost) {
				m_source.clip = btnClick;
				m_source.Play();
				scoreCount -= tomatoCost;
				tomatoLevel += 1;
				tomatoCPS = tomatoCPS + 10;
				TomatoPointsPerSecond = tomatoCPS;
				tomatoCost += 1500;
				imgTomato.SetActive(true);
			} else {
				m_source.clip = btnError;
				m_source.Play();
			}
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
		//enable the Tree
		if (tomatoLevel >= 25) {
			btnTree.GetComponent<Button>().interactable = true;
		}
		//tomato txt update
		tomatoCPSTxt.text = "C.P.S : " + tomatoCPS;
		tomatoLevelTxt.text = "Lvl : " + tomatoLevel;
		tomatoCostTxt.text = tomatoCost + "$";
		//convert tomato data to string to save in PlayerPrefs
		string CPSSave = tomatoCPS.ToString ();
		string LevelSave = tomatoLevel.ToString ();
		string CostSave = tomatoCost.ToString ();
		string PointsPerSecondSave = TomatoPointsPerSecond.ToString ();
		//save tomato data to PlayerPrefs
		PlayerPrefs.SetString ("tomatoCPS", CPSSave);
		PlayerPrefs.SetString ("tomatoLevel", LevelSave);
		PlayerPrefs.SetString ("tomatoCost", CostSave);
		PlayerPrefs.SetString ("tomatoPointsPerSecond", PointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}

	//--------------------------  Tree  --------------------------
	public void BuyTree () {
		if (tomatoLevel >= 25) {
			//check for the money available
			if (scoreCount >= TreeCost) {
				m_source.clip = btnClick;
				m_source.Play();
				scoreCount -= TreeCost;
				TreeLevel += 1;
				TreeCPS = TreeCPS + 31;
				TreePointsPerSecond = TreeCPS;
				TreeCost += 5250;
				imgTree.SetActive(true);
			} else {
				m_source.clip = btnError;
				m_source.Play();
			}
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
		//enable the GreenApple
		if (TreeLevel >= 25) {
			btnGreenApple.GetComponent<Button>().interactable = true;
		}
		//Tree txt update
		TreeCPSTxt.text = "C.P.S : " + TreeCPS;
		TreeLevelTxt.text = "Lvl : " + TreeLevel;
		TreeCostTxt.text = TreeCost + "$";
		//convert Tree data to string to save in PlayerPrefs
		string TreeCPSSave = TreeCPS.ToString ();
		string TreeLevelSave = TreeLevel.ToString ();
		string TreeCostSave = TreeCost.ToString ();
		string TreePointsPerSecondSave = TreePointsPerSecond.ToString ();
		//save Tree data to PlayerPrefs
		PlayerPrefs.SetString ("TreeCPS", TreeCPSSave);
		PlayerPrefs.SetString ("TreeLevel", TreeLevelSave);
		PlayerPrefs.SetString ("TreeCost", TreeCostSave);
		PlayerPrefs.SetString ("TreePointsPerSecond", TreePointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}

	//--------------------------  GreenApple  --------------------------
	public void BuyGreenApple () {
		if (TreeLevel >= 25) {
			//check for the money available
			if (scoreCount >= GreenAppleCost) {
				m_source.clip = btnClick;
				m_source.Play();
				scoreCount -= GreenAppleCost;
				GreenAppleLevel += 1;
				GreenAppleCPS = GreenAppleCPS + 60;
				GreenApplePointsPerSecond = GreenAppleCPS;
				GreenAppleCost += 13750;
				imgGreenApple.SetActive(true);
			} else {
				m_source.clip = btnError;
				m_source.Play();
			}
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
		//enable the carrot
		if (GreenAppleLevel >= 25) {
			btnCarrot.GetComponent<Button>().interactable = true;
		}
		//GreenApple txt update
		GreenAppleCPSTxt.text = "C.P.S : " + GreenAppleCPS;
		GreenAppleLevelTxt.text = "Lvl : " + GreenAppleLevel;
		GreenAppleCostTxt.text = GreenAppleCost + "$";
		//convert GreenApple data to string to save in PlayerPrefs
		string GreenAppleCPSSave = GreenAppleCPS.ToString ();
		string GreenAppleLevelSave = GreenAppleLevel.ToString ();
		string GreenAppleCostSave = GreenAppleCost.ToString ();
		string GreenApplePointsPerSecondSave = GreenApplePointsPerSecond.ToString ();
		//save GreenApple data to PlayerPrefs
		PlayerPrefs.SetString ("GreenAppleCPS", GreenAppleCPSSave);
		PlayerPrefs.SetString ("GreenAppleLevel", GreenAppleLevelSave);
		PlayerPrefs.SetString ("GreenAppleCost", GreenAppleCostSave);
		PlayerPrefs.SetString ("GreenApplePointsPerSecond", GreenApplePointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}

	//--------------------------  Carrot  --------------------------
	public void BuyCarrot () {
		if (GreenAppleLevel >= 25) {
			//check for the money available
			if (scoreCount >= CarrotCost) {
				m_source.clip = btnClick;
				m_source.Play();
				scoreCount -= CarrotCost;
				CarrotLevel += 1;
				CarrotCPS = CarrotCPS + 200;
				CarrotPointsPerSecond = CarrotCPS;
				CarrotCost += 73120;
				imgCarrot.SetActive(true);
			} else {
				m_source.clip = btnError;
				m_source.Play();
			}
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
		//enable the GreenPear
		if (CarrotLevel >= 25) {
			btnGreenPear.GetComponent<Button>().interactable = true;
		}
		//Carrot txt update
		CarrotCPSTxt.text = "C.P.S : " + CarrotCPS;
		CarrotLevelTxt.text = "Lvl : " + CarrotLevel;
		CarrotCostTxt.text = CarrotCost + "$";
		//convert Carrot data to string to save in PlayerPrefs
		string CarrotCPSSave = CarrotCPS.ToString ();
		string CarrotLevelSave = CarrotLevel.ToString ();
		string CarrotCostSave = CarrotCost.ToString ();
		string CarrotPointsPerSecondSave = CarrotPointsPerSecond.ToString ();
		//save Carrot data to PlayerPrefs
		PlayerPrefs.SetString ("CarrotCPS", CarrotCPSSave);
		PlayerPrefs.SetString ("CarrotLevel", CarrotLevelSave);
		PlayerPrefs.SetString ("CarrotCost", CarrotCostSave);
		PlayerPrefs.SetString ("CarrotPointsPerSecond", CarrotPointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}

	//--------------------------  GreenPear  --------------------------
	public void BuyGreenPear () {
		if (CarrotLevel >= 25) {
			//check for the money available
			if (scoreCount >= GreenPearCost) {
				m_source.clip = btnClick;
				m_source.Play();
				scoreCount -= GreenPearCost;
				GreenPearLevel += 1;
				GreenPearCPS = GreenPearCPS + 400;
				GreenPearPointsPerSecond = GreenPearCPS;
				GreenPearCost += 137852;
				imgGreenPear.SetActive(true);
			} else {
				m_source.clip = btnError;
				m_source.Play();
			}
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
		//enable the Corn
		if (GreenPearLevel >= 25) {
			btnCorn.GetComponent<Button>().interactable = true;
		}
		//GreenPear txt update
		GreenPearCPSTxt.text = "C.P.S : " + GreenPearCPS;
		GreenPearLevelTxt.text = "Lvl : " + GreenPearLevel;
		GreenPearCostTxt.text = GreenPearCost + "$";
		//convert GreenPear data to string to save in PlayerPrefs
		string GreenPearCPSSave = GreenPearCPS.ToString ();
		string GreenPearLevelSave = GreenPearLevel.ToString ();
		string GreenPearCostSave = GreenPearCost.ToString ();
		string GreenPearPointsPerSecondSave = GreenPearPointsPerSecond.ToString ();
		//save GreenPear data to PlayerPrefs
		PlayerPrefs.SetString ("GreenPearCPS", GreenPearCPSSave);
		PlayerPrefs.SetString ("GreenPearLevel", GreenPearLevelSave);
		PlayerPrefs.SetString ("GreenPearCost", GreenPearCostSave);
		PlayerPrefs.SetString ("GreenPearPointsPerSecond", GreenPearPointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}

	//--------------------------  Corn  --------------------------
	public void BuyCorn () {
		if (GreenPearLevel >= 25) {
			//check for the money available
			if (scoreCount >= CornCost) {
				m_source.clip = btnClick;
				m_source.Play();
				scoreCount -= CornCost;
				CornLevel += 1;
				CornCPS = CornCPS + 700;
				CornPointsPerSecond = CornCPS;
				CornCost += 2600000;
				imgCorn.SetActive(true);
			} else {
				m_source.clip = btnError;
				m_source.Play();
			}
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
		//enable the RedApple
		if (CornLevel >= 25) {
			btnRedApple.GetComponent<Button>().interactable = true;
		}
		//Corn txt update
		CornCPSTxt.text = "C.P.S : " + CornCPS;
		CornLevelTxt.text = "Lvl : " + CornLevel;
		CornCostTxt.text = CornCost + "$";
		//convert Corn data to string to save in PlayerPrefs
		string CornCPSSave = CornCPS.ToString ();
		string CornLevelSave = CornLevel.ToString ();
		string CornCostSave = CornCost.ToString ();
		string CornPointsPerSecondSave = CornPointsPerSecond.ToString ();
		//save Corn data to PlayerPrefs
		PlayerPrefs.SetString ("CornCPS", CornCPSSave);
		PlayerPrefs.SetString ("CornLevel", CornLevelSave);
		PlayerPrefs.SetString ("CornCost", CornCostSave);
		PlayerPrefs.SetString ("CornPointsPerSecond", CornPointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}

	//--------------------------  RedApple  --------------------------
	public void BuyRedApple () {
		if (CornLevel >= 25) {
			//check for the money available
			if (scoreCount >= RedAppleCost) {
				m_source.clip = btnClick;
				m_source.Play();
				scoreCount -= RedAppleCost;
				RedAppleLevel += 1;
				RedAppleCPS = RedAppleCPS + 3000;
				RedApplePointsPerSecond = RedAppleCPS;
				RedAppleCost += 5300000;
				imgRedApple.SetActive(true);
			} else {
				m_source.clip = btnError;
				m_source.Play();
			}
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
		//enable the 
		if (RedAppleLevel >= 25) {
			btnWatermelon.GetComponent<Button>().interactable = true;
		}
		//RedApple txt update
		RedAppleCPSTxt.text = "C.P.S : " + RedAppleCPS;
		RedAppleLevelTxt.text = "Lvl : " + RedAppleLevel;
		RedAppleCostTxt.text = RedAppleCost + "$";
		//convert RedApple data to string to save in PlayerPrefs
		string RedAppleCPSSave = RedAppleCPS.ToString ();
		string RedAppleLevelSave = RedAppleLevel.ToString ();
		string RedAppleCostSave = RedAppleCost.ToString ();
		string RedApplePointsPerSecondSave = RedApplePointsPerSecond.ToString ();
		//save RedApple data to PlayerPrefs
		PlayerPrefs.SetString ("RedAppleCPS", RedAppleCPSSave);
		PlayerPrefs.SetString ("RedAppleLevel", RedAppleLevelSave);
		PlayerPrefs.SetString ("RedAppleCost", RedAppleCostSave);
		PlayerPrefs.SetString ("RedApplePointsPerSecond", RedApplePointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}

	//--------------------------  Watermelon  --------------------------
	public void BuyWatermelon () {
		if (RedAppleLevel >= 25) {
			//check for the money available
			if (scoreCount >= WatermelonCost) {
				m_source.clip = btnClick;
				m_source.Play();
				scoreCount -= WatermelonCost;
				WatermelonLevel += 1;
				WatermelonCPS = WatermelonCPS + 15000;
				WatermelonPointsPerSecond = WatermelonCPS;
				WatermelonCost += 17500000;
				imgWatermelon.SetActive(true);
			} else {
				m_source.clip = btnError;
				m_source.Play();
			}
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
		//enable the RedPear
		if (WatermelonLevel >= 25) {
			btnRedPear.GetComponent<Button>().interactable = true;
		}
		//Watermelon txt update
		WatermelonCPSTxt.text = "C.P.S : " + WatermelonCPS;
		WatermelonLevelTxt.text = "Lvl : " + WatermelonLevel;
		WatermelonCostTxt.text = WatermelonCost + "$";
		//convert Watermelon data to string to save in PlayerPrefs
		string WatermelonCPSSave = WatermelonCPS.ToString ();
		string WatermelonLevelSave = WatermelonLevel.ToString ();
		string WatermelonCostSave = WatermelonCost.ToString ();
		string WatermelonPointsPerSecondSave = WatermelonPointsPerSecond.ToString ();
		//save Watermelon data to PlayerPrefs
		PlayerPrefs.SetString ("WatermelonCPS", WatermelonCPSSave);
		PlayerPrefs.SetString ("WatermelonLevel", WatermelonLevelSave);
		PlayerPrefs.SetString ("WatermelonCost", WatermelonCostSave);
		PlayerPrefs.SetString ("WatermelonPointsPerSecond", WatermelonPointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}

	//--------------------------  RedPear  --------------------------
	public void BuyRedPear () {
		if (WatermelonLevel >= 25) {
			//check for the money available
			if (scoreCount >= RedPearCost) {
				m_source.clip = btnClick;
				m_source.Play();
				scoreCount -= RedPearCost;
				RedPearLevel += 1;
				RedPearCPS = RedPearCPS + 30000;
				RedPearPointsPerSecond = RedPearCPS;
				RedPearCost += 3300252;
				imgRedPear.SetActive(true);
			} else {
				m_source.clip = btnError;
				m_source.Play();
			}
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
		//enable the Pumpkin
		if (RedPearLevel >= 25) {
			btnPumpkin.GetComponent<Button>().interactable = true;
		}
		//RedPear txt update
		RedPearCPSTxt.text = "C.P.S : " + RedPearCPS;
		RedPearLevelTxt.text = "Lvl : " + RedPearLevel;
		RedPearCostTxt.text = RedPearCost + "$";
		//convert RedPear data to string to save in PlayerPrefs
		string RedPearCPSSave = RedPearCPS.ToString ();
		string RedPearLevelSave = RedPearLevel.ToString ();
		string RedPearCostSave = RedPearCost.ToString ();
		string RedPearPointsPerSecondSave = RedPearPointsPerSecond.ToString ();
		//save RedPear data to PlayerPrefs
		PlayerPrefs.SetString ("RedPearCPS", RedPearCPSSave);
		PlayerPrefs.SetString ("RedPearLevel", RedPearLevelSave);
		PlayerPrefs.SetString ("RedPearCost", RedPearCostSave);
		PlayerPrefs.SetString ("RedPearPointsPerSecond", RedPearPointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}

	//--------------------------  Pumpkin  --------------------------
	public void BuyPumpkin () {
		if (RedPearLevel >= 25) {
			//check for the money available
			if (scoreCount >= PumpkinCost) {
				m_source.clip = btnClick;
				m_source.Play();
				scoreCount -= PumpkinCost;
				PumpkinLevel += 1;
				PumpkinCPS = PumpkinCPS + 80000;
				PumpkinPointsPerSecond = PumpkinCPS;
				PumpkinCost += 55000000;
				imgPumpkin.SetActive(true);
			} else {
				m_source.clip = btnError;
				m_source.Play();
			}
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
		//enable the Wrench
		if (PumpkinLevel >= 25) {
			btnWrench.GetComponent<Button>().interactable = true;
		}
		//Pumpkin txt update
		PumpkinCPSTxt.text = "C.P.S : " + PumpkinCPS;
		PumpkinLevelTxt.text = "Lvl : " + PumpkinLevel;
		PumpkinCostTxt.text = PumpkinCost + "$";
		//convert  data to string to save in PlayerPrefs
		string PumpkinCPSSave = PumpkinCPS.ToString ();
		string PumpkinLevelSave = PumpkinLevel.ToString ();
		string PumpkinCostSave = PumpkinCost.ToString ();
		string PumpkinPointsPerSecondSave = PumpkinPointsPerSecond.ToString ();
		//save  data to PlayerPrefs
		PlayerPrefs.SetString ("PumpkinCPS", PumpkinCPSSave);
		PlayerPrefs.SetString ("PumpkinLevel", PumpkinLevelSave);
		PlayerPrefs.SetString ("PumpkinCost", PumpkinCostSave);
		PlayerPrefs.SetString ("PumpkinPointsPerSecond", PumpkinPointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}

	//--------------------------  Wrench  --------------------------
	public void BuyWrench () {
		if (PumpkinLevel >= 25) {
			//check for the money available
			if (scoreCount >= WrenchCost) {
				m_source.clip = btnClick;
				m_source.Play();
				scoreCount -= WrenchCost;
				WrenchLevel += 1;
				WrenchCPS = WrenchCPS + 150000;
				WrenchPointsPerSecond = WrenchCPS;
				WrenchCost += 67895220;
				imgWrench.SetActive(true);
			} else {
				m_source.clip = btnError;
				m_source.Play();
			}
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
		//enable the Screwdriver
		if (WrenchLevel >= 25) {
			btnScrewdriver.GetComponent<Button>().interactable = true;
		}
		//Wrench txt update
		WrenchCPSTxt.text = "C.P.S : " + WrenchCPS;
		WrenchLevelTxt.text = "Lvl : " + WrenchLevel;
		WrenchCostTxt.text = WrenchCost + "$";
		//convert Wrench data to string to save in PlayerPrefs
		string WrenchCPSSave = WrenchCPS.ToString ();
		string WrenchLevelSave = WrenchLevel.ToString ();
		string WrenchCostSave = WrenchCost.ToString ();
		string WrenchPointsPerSecondSave = WrenchPointsPerSecond.ToString ();
		//save Wrench data to PlayerPrefs
		PlayerPrefs.SetString ("WrenchCPS", WrenchCPSSave);
		PlayerPrefs.SetString ("WrenchLevel", WrenchLevelSave);
		PlayerPrefs.SetString ("WrenchCost", WrenchCostSave);
		PlayerPrefs.SetString ("WrenchPointsPerSecond", WrenchPointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}

	//--------------------------  Screwdriver  --------------------------
	public void BuyScrewdriver () {
		if (WrenchLevel >= 25) {
			//check for the money available
			if (scoreCount >= ScrewdriverCost) {
				m_source.clip = btnClick;
				m_source.Play();
				scoreCount -= ScrewdriverCost;
				ScrewdriverLevel += 1;
				ScrewdriverCPS = ScrewdriverCPS + 200000;
				ScrewdriverPointsPerSecond = ScrewdriverCPS;
				ScrewdriverCost += 90632300;
				imgScrewdriver.SetActive(true);
			} else {
				m_source.clip = btnError;
				m_source.Play();
			}
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
		//enable the Hammer
		if (ScrewdriverLevel >= 25) {
			btnHammer.GetComponent<Button>().interactable = true;
		}
		//Screwdriver txt update
		ScrewdriverCPSTxt.text = "C.P.S : " + ScrewdriverCPS;
		ScrewdriverLevelTxt.text = "Lvl : " + ScrewdriverLevel;
		ScrewdriverCostTxt.text = ScrewdriverCost + "$";
		//convert Screwdriver data to string to save in PlayerPrefs
		string ScrewdriverCPSSave = ScrewdriverCPS.ToString ();
		string ScrewdriverLevelSave = ScrewdriverLevel.ToString ();
		string ScrewdriverCostSave = ScrewdriverCost.ToString ();
		string ScrewdriverPointsPerSecondSave = ScrewdriverPointsPerSecond.ToString ();
		//save Screwdriver data to PlayerPrefs
		PlayerPrefs.SetString ("ScrewdriverCPS", ScrewdriverCPSSave);
		PlayerPrefs.SetString ("ScrewdriverLevel", ScrewdriverLevelSave);
		PlayerPrefs.SetString ("ScrewdriverCost", ScrewdriverCostSave);
		PlayerPrefs.SetString ("ScrewdriverPointsPerSecond", ScrewdriverPointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}

	//--------------------------  Hammer  --------------------------
	public void BuyHammer () {
		if (ScrewdriverLevel >= 25) {
			//check for the money available
			if (scoreCount >= HammerCost) {
				m_source.clip = btnClick;
				m_source.Play();
				scoreCount -= HammerCost;
				HammerLevel += 1;
				HammerCPS = HammerCPS + 300000;
				HammerPointsPerSecond = HammerCPS;
				HammerCost += 119230152;
				imgHammer.SetActive(true);
			} else {
				m_source.clip = btnError;
				m_source.Play();
			}
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
		//enable the Handsaw
		if (HammerLevel >= 25) {
			btnHandsaw.GetComponent<Button>().interactable = true;
		}
		//Hammer txt update
		HammerCPSTxt.text = "C.P.S : " + HammerCPS;
		HammerLevelTxt.text = "Lvl : " + HammerLevel;
		HammerCostTxt.text = HammerCost + "$";
		//convert Hammer data to string to save in PlayerPrefs
		string HammerCPSSave = HammerCPS.ToString ();
		string HammerLevelSave = HammerLevel.ToString ();
		string HammerCostSave = HammerCost.ToString ();
		string HammerPointsPerSecondSave = HammerPointsPerSecond.ToString ();
		//save Hammer data to PlayerPrefs
		PlayerPrefs.SetString ("HammerCPS", HammerCPSSave);
		PlayerPrefs.SetString ("HammerLevel", HammerLevelSave);
		PlayerPrefs.SetString ("HammerCost", HammerCostSave);
		PlayerPrefs.SetString ("HammerPointsPerSecond", HammerPointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}

	//--------------------------  Handsaw  --------------------------
	public void BuyHandsaw () {
		if (HammerLevel >= 25) {
			//check for the money available
			if (scoreCount >= HandsawCost) {
				m_source.clip = btnClick;
				m_source.Play();
				scoreCount -= HandsawCost;
				HandsawLevel += 1;
				HandsawCPS = HandsawCPS + 800000;
				HandsawPointsPerSecond = HandsawCPS;
				HandsawCost += 165298456;
				imgHandsaw.SetActive(true);
			} else {
				m_source.clip = btnError;
				m_source.Play();
			}
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
		//enable the Fence
		if (HandsawLevel >= 25) {
			btnFence.GetComponent<Button>().interactable = true;
		}
		//Handsaw txt update
		HandsawCPSTxt.text = "C.P.S : " + HandsawCPS;
		HandsawLevelTxt.text = "Lvl : " + HandsawLevel;
		HandsawCostTxt.text = HandsawCost + "$";
		//convert Handsaw data to string to save in PlayerPrefs
		string HandsawCPSSave = HandsawCPS.ToString ();
		string HandsawLevelSave = HandsawLevel.ToString ();
		string HandsawCostSave = HandsawCost.ToString ();
		string HandsawPointsPerSecondSave = HandsawPointsPerSecond.ToString ();
		//save Handsaw data to PlayerPrefs
		PlayerPrefs.SetString ("HandsawCPS", HandsawCPSSave);
		PlayerPrefs.SetString ("HandsawLevel", HandsawLevelSave);
		PlayerPrefs.SetString ("HandsawCost", HandsawCostSave);
		PlayerPrefs.SetString ("HandsawPointsPerSecond", HandsawPointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}

	//--------------------------  Fence  --------------------------
	public void BuyFence () {
		if (HandsawLevel >= 25) {
			//check for the money available
			if (scoreCount >= FenceCost) {
				m_source.clip = btnClick;
				m_source.Play();
				scoreCount -= FenceCost;
				FenceLevel += 1;
				FenceCPS = FenceCPS + 1200000;
				FencePointsPerSecond = FenceCPS;
				FenceCost += 250000000;
				imgFence.SetActive(true);
			} else {
				m_source.clip = btnError;
				m_source.Play();
			}
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
		//enable the Dog
		if (FenceLevel >= 25) {
			btnDog.GetComponent<Button>().interactable = true;
		}
		//Fence txt update
		FenceCPSTxt.text = "C.P.S : " + FenceCPS;
		FenceLevelTxt.text = "Lvl : " + FenceLevel;
		FenceCostTxt.text = FenceCost + "$";
		//convert Fence data to string to save in PlayerPrefs
		string FenceCPSSave = FenceCPS.ToString ();
		string FenceLevelSave = FenceLevel.ToString ();
		string FenceCostSave = FenceCost.ToString ();
		string FencePointsPerSecondSave = FencePointsPerSecond.ToString ();
		//save Fence data to PlayerPrefs
		PlayerPrefs.SetString ("FenceCPS", FenceCPSSave);
		PlayerPrefs.SetString ("FenceLevel", FenceLevelSave);
		PlayerPrefs.SetString ("FenceCost", FenceCostSave);
		PlayerPrefs.SetString ("FencePointsPerSecond", FencePointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}

	//--------------------------  Dog  --------------------------
	public void BuyDog () {
		if (FenceLevel >= 25) {
			//check for the money available
			if (scoreCount >= DogCost) {
				m_source.clip = btnClick;
				m_source.Play();
				scoreCount -= DogCost;
				DogLevel += 1;
				DogCPS = DogCPS + 2000000;
				DogPointsPerSecond = DogCPS;
				DogCost += 400000000;
				imgDog.SetActive(true);
			} else {
				m_source.clip = btnError;
				m_source.Play();
			}
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
		//enable the Cat
		if (DogLevel >= 25) {
			btnCat.GetComponent<Button>().interactable = true;
		}
		//Dog txt update
		DogCPSTxt.text = "C.P.S : " + DogCPS;
		DogLevelTxt.text = "Lvl : " + DogLevel;
		DogCostTxt.text = DogCost + "$";
		//convert Dog data to string to save in PlayerPrefs
		string DogCPSSave = DogCPS.ToString ();
		string DogLevelSave = DogLevel.ToString ();
		string DogCostSave = DogCost.ToString ();
		string DogPointsPerSecondSave = DogPointsPerSecond.ToString ();
		//save Dog data to PlayerPrefs
		PlayerPrefs.SetString ("DogCPS", DogCPSSave);
		PlayerPrefs.SetString ("DogLevel", DogLevelSave);
		PlayerPrefs.SetString ("DogCost", DogCostSave);
		PlayerPrefs.SetString ("DogPointsPerSecond", DogPointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}

	//--------------------------  Cat  --------------------------
	public void BuyCat () {
		if (DogLevel >= 25) {
			//check for the money available
			if (scoreCount >= CatCost) {
				m_source.clip = btnClick;
				m_source.Play();
				scoreCount -= CatCost;
				CatLevel += 1;
				CatCPS = CatCPS + 3500000;
				CatPointsPerSecond = CatCPS;
				CatCost += 800000000;
				imgCat.SetActive(true);
			} else {
				m_source.clip = btnError;
				m_source.Play();
			}
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
		//enable the Chicken
		if (CatLevel >= 25) {
			btnChicken.GetComponent<Button>().interactable = true;
		}
		//Cat txt update
		CatCPSTxt.text = "C.P.S : " + CatCPS;
		CatLevelTxt.text = "Lvl : " + CatLevel;
		CatCostTxt.text = CatCost + "$";
		//convert Cat data to string to save in PlayerPrefs
		string CatCPSSave = CatCPS.ToString ();
		string CatLevelSave = CatLevel.ToString ();
		string CatCostSave = CatCost.ToString ();
		string CatPointsPerSecondSave = CatPointsPerSecond.ToString ();
		//save Cat data to PlayerPrefs
		PlayerPrefs.SetString ("CatCPS", CatCPSSave);
		PlayerPrefs.SetString ("CatLevel", CatLevelSave);
		PlayerPrefs.SetString ("CatCost", CatCostSave);
		PlayerPrefs.SetString ("CatPointsPerSecond", CatPointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}

	//--------------------------  Chicken  --------------------------
	public void BuyChicken () {
		if (CatLevel >= 25) {
			//check for the money available
			if (scoreCount >= ChickenCost) {
				m_source.clip = btnClick;
				m_source.Play();
				scoreCount -= ChickenCost;
				ChickenLevel += 1;
				ChickenCPS = ChickenCPS + 6000000;
				ChickenPointsPerSecond = ChickenCPS;
				ChickenCost += 1200000000;
				imgChicken.SetActive(true);
			} else {
				m_source.clip = btnError;
				m_source.Play();
			}
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
		//enable the Pig
		if (ChickenLevel >= 25) {
			btnPig.GetComponent<Button>().interactable = true;
		}
		//Chicken txt update
		ChickenCPSTxt.text = "C.P.S : " + ChickenCPS;
		ChickenLevelTxt.text = " " + ChickenLevel;
		ChickenCostTxt.text = ChickenCost + "$";
		//convert Chicken data to string to save in PlayerPrefs
		string ChickenCPSSave = ChickenCPS.ToString ();
		string ChickenLevelSave = ChickenLevel.ToString ();
		string ChickenCostSave = ChickenCost.ToString ();
		string ChickenPointsPerSecondSave = ChickenPointsPerSecond.ToString ();
		//save Chicken data to PlayerPrefs
		PlayerPrefs.SetString ("ChickenCPS", ChickenCPSSave);
		PlayerPrefs.SetString ("ChickenLevel", ChickenLevelSave);
		PlayerPrefs.SetString ("ChickenCost", ChickenCostSave);
		PlayerPrefs.SetString ("ChickenPointsPerSecond", ChickenPointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}

	//--------------------------  Pig  --------------------------
	public void BuyPig () {
		if (ChickenLevel >= 25) {
			//check for the money available
			if (scoreCount >= PigCost) {
				m_source.clip = btnClick;
				m_source.Play();
				scoreCount -= PigCost;
				PigLevel += 1;
				PigCPS = PigCPS + 10000000;
				PigPointsPerSecond = PigCPS;
				PigCost += 1700000000;
				imgPig.SetActive(true);
			} else {
				m_source.clip = btnError;
				m_source.Play();
			}
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
		//enable the Sheep
		if (PigLevel >= 25) {
			btnSheep.GetComponent<Button>().interactable = true;
		}
		//Pig txt update
		PigCPSTxt.text = "C.P.S : " + PigCPS;
		PigLevelTxt.text = "Lvl : " + PigLevel;
		PigCostTxt.text = PigCost + "$";
		//convert Pig data to string to save in PlayerPrefs
		string PigCPSSave = PigCPS.ToString ();
		string PigLevelSave = PigLevel.ToString ();
		string PigCostSave = PigCost.ToString ();
		string PigPointsPerSecondSave = PigPointsPerSecond.ToString ();
		//save Pig data to PlayerPrefs
		PlayerPrefs.SetString ("PigCPS", PigCPSSave);
		PlayerPrefs.SetString ("PigLevel", PigLevelSave);
		PlayerPrefs.SetString ("PigCost", PigCostSave);
		PlayerPrefs.SetString ("PigPointsPerSecond", PigPointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}

	//--------------------------  Sheep  --------------------------
	public void BuySheep () {
		if (PigLevel >= 25) {
			//check for the money available
			if (scoreCount >= SheepCost) {
				m_source.clip = btnClick;
				m_source.Play();
				scoreCount -= SheepCost;
				SheepLevel += 1;
				SheepCPS = SheepCPS + 15000000;
				SheepPointsPerSecond = SheepCPS;
				SheepCost += 3000000000;
				imgSheep.SetActive(true);
			} else {
				m_source.clip = btnError;
				m_source.Play();
			}
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
		//enable the Cow
		if (SheepLevel >= 25) {
			btnCow.GetComponent<Button>().interactable = true;
		}
		//Sheep txt update
		SheepCPSTxt.text = "C.P.S : " + SheepCPS;
		SheepLevelTxt.text = "Lvl : " + SheepLevel;
		SheepCostTxt.text = SheepCost + "$";
		//convert Sheep data to string to save in PlayerPrefs
		string SheepCPSSave = SheepCPS.ToString ();
		string SheepLevelSave = SheepLevel.ToString ();
		string SheepCostSave = SheepCost.ToString ();
		string SheepPointsPerSecondSave = SheepPointsPerSecond.ToString ();
		//save Sheep data to PlayerPrefs
		PlayerPrefs.SetString ("SheepCPS", SheepCPSSave);
		PlayerPrefs.SetString ("SheepLevel", SheepLevelSave);
		PlayerPrefs.SetString ("SheepCost", SheepCostSave);
		PlayerPrefs.SetString ("SheepPointsPerSecond", SheepPointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}

	//--------------------------  Cow  --------------------------
	public void BuyCow () {
		if (SheepLevel >= 25) {
			//check for the money available
			if (scoreCount >= CowCost) {
				m_source.clip = btnClick;
				m_source.Play();
				scoreCount -= CowCost;
				CowLevel += 1;
				CowCPS = CowCPS + 25000000;
				CowPointsPerSecond = CowCPS;
				CowCost += 5500000000;
				imgCow.SetActive(true);
			} else {
				m_source.clip = btnError;
				m_source.Play();
			}
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
		//enable the Horse
		if (CowLevel >= 25) {
			btnHorse.GetComponent<Button>().interactable = true;
		}
		//Cow txt update
		CowCPSTxt.text = "C.P.S : " + CowCPS;
		CowLevelTxt.text = "Lvl : " + CowLevel;
		CowCostTxt.text = CowCost + "$";
		//convert Cow data to string to save in PlayerPrefs
		string CowCPSSave = CowCPS.ToString ();
		string CowLevelSave = CowLevel.ToString ();
		string CowCostSave = CowCost.ToString ();
		string CowPointsPerSecondSave = CowPointsPerSecond.ToString ();
		//save Cow data to PlayerPrefs
		PlayerPrefs.SetString ("CowCPS", CowCPSSave);
		PlayerPrefs.SetString ("CowLevel", CowLevelSave);
		PlayerPrefs.SetString ("CowCost", CowCostSave);
		PlayerPrefs.SetString ("CowPointsPerSecond", CowPointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}

	//--------------------------  Horse  --------------------------
	public void BuyHorse () {
		if (CowLevel >= 25) {
			//check for the money available
			if (scoreCount >= HorseCost) {
				m_source.clip = btnClick;
				m_source.Play();
				scoreCount -= HorseCost;
				HorseLevel += 1;
				HorseCPS = HorseCPS + 40000000;
				HorsePointsPerSecond = HorseCPS;
				HorseCost += 8000000000;
				imgHorse.SetActive(true);
			} else {
				m_source.clip = btnError;
				m_source.Play();
			}
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
		//enable the GoldPear
		if (HorseLevel >= 25) {
			btnGoldPear.GetComponent<Button>().interactable = true;
		}
		//Horse txt update
		HorseCPSTxt.text = "C.P.S : " + HorseCPS;
		HorseLevelTxt.text = "Lvl : " + HorseLevel;
		HorseCostTxt.text = HorseCost + "$";
		//convert Horse data to string to save in PlayerPrefs
		string HorseCPSSave = HorseCPS.ToString ();
		string HorseLevelSave = HorseLevel.ToString ();
		string HorseCostSave = HorseCost.ToString ();
		string HorsePointsPerSecondSave = HorsePointsPerSecond.ToString ();
		//save Horse data to PlayerPrefs
		PlayerPrefs.SetString ("HorseCPS", HorseCPSSave);
		PlayerPrefs.SetString ("HorseLevel", HorseLevelSave);
		PlayerPrefs.SetString ("HorseCost", HorseCostSave);
		PlayerPrefs.SetString ("HorsePointsPerSecond", HorsePointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}

	//--------------------------  GoldPear  --------------------------
	public void BuyGoldPear () {
		if (HorseLevel >= 25) {
			//check for the money available
			if (scoreCount >= GoldPearCost) {
				m_source.clip = btnClick;
				m_source.Play();
				scoreCount -= GoldPearCost;
				GoldPearLevel += 1;
				GoldPearCPS = GoldPearCPS + 70000000;
				GoldPearPointsPerSecond = GoldPearCPS;
				GoldPearCost += 13250000000;
				imgGoldPear.SetActive(true);
			} else {
				m_source.clip = btnError;
				m_source.Play();
			}
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
		//enable the Barn
		if (GoldPearLevel >= 25) {
			btnBarn.GetComponent<Button>().interactable = true;
		}
		//GoldPear txt update
		GoldPearCPSTxt.text = "C.P.S : " + GoldPearCPS;
		GoldPearLevelTxt.text = "Lvl : " + GoldPearLevel;
		GoldPearCostTxt.text = GoldPearCost + "$";
		//convert GoldPear data to string to save in PlayerPrefs
		string GoldPearCPSSave = GoldPearCPS.ToString ();
		string GoldPearLevelSave = GoldPearLevel.ToString ();
		string GoldPearCostSave = GoldPearCost.ToString ();
		string GoldPearPointsPerSecondSave = GoldPearPointsPerSecond.ToString ();
		//save GoldPear data to PlayerPrefs
		PlayerPrefs.SetString ("GoldPearCPS", GoldPearCPSSave);
		PlayerPrefs.SetString ("GoldPearLevel", GoldPearLevelSave);
		PlayerPrefs.SetString ("GoldPearCost", GoldPearCostSave);
		PlayerPrefs.SetString ("GoldPearPointsPerSecond", GoldPearPointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}

	//--------------------------  Barn  --------------------------
	public void BuyBarn () {
		if (GoldPearLevel >= 25) {
			//check for the money available
			if (scoreCount >= BarnCost) {
				m_source.clip = btnClick;
				m_source.Play();
				scoreCount -= BarnCost;
				BarnLevel += 1;
				BarnCPS = BarnCPS + 100000000;
				BarnPointsPerSecond = BarnCPS;
				BarnCost += 20000000000;
				imgBarn.SetActive(true);
			} else {
				m_source.clip = btnError;
				m_source.Play();
			}
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
		//enable the Tractor
		if (BarnLevel >= 25) {
			btnTractor.GetComponent<Button>().interactable = true;
		}
		//Barn txt update
		BarnCPSTxt.text = "C.P.S : " + BarnCPS;
		BarnLevelTxt.text = "Lvl : " + BarnLevel;
		BarnCostTxt.text = BarnCost + "$";
		//convert Barn data to string to save in PlayerPrefs
		string BarnCPSSave = BarnCPS.ToString ();
		string BarnLevelSave = BarnLevel.ToString ();
		string BarnCostSave = BarnCost.ToString ();
		string BarnPointsPerSecondSave = BarnPointsPerSecond.ToString ();
		//save Barn data to PlayerPrefs
		PlayerPrefs.SetString ("BarnCPS", BarnCPSSave);
		PlayerPrefs.SetString ("BarnLevel", BarnLevelSave);
		PlayerPrefs.SetString ("BarnCost", BarnCostSave);
		PlayerPrefs.SetString ("BarnPointsPerSecond", BarnPointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}

	//--------------------------  Tractor  --------------------------
	public void BuyTractor () {
		if (BarnLevel >= 25) {
			//check for the money available
			if (scoreCount >= TractorCost) {
				m_source.clip = btnClick;
				m_source.Play();
				scoreCount -= TractorCost;
				TractorLevel += 1;
				TractorCPS = TractorCPS + 150000000;
				TractorPointsPerSecond = TractorCPS;
				TractorCost += 45000000000;
				imgTractor.SetActive(true);
			} else {
				m_source.clip = btnError;
				m_source.Play();
			}
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
		//enable the Mill
		if (TractorLevel >= 25) {
			btnMill.GetComponent<Button>().interactable = true;
		}
		//Tractor txt update
		TractorCPSTxt.text = "C.P.S : " + TractorCPS;
		TractorLevelTxt.text = "Lvl : " + TractorLevel;
		TractorCostTxt.text = TractorCost + "$";
		//convert Tractor data to string to save in PlayerPrefs
		string TractorCPSSave = TractorCPS.ToString ();
		string TractorLevelSave = TractorLevel.ToString ();
		string TractorCostSave = TractorCost.ToString ();
		string TractorPointsPerSecondSave = TractorPointsPerSecond.ToString ();
		//save Tractor data to PlayerPrefs
		PlayerPrefs.SetString ("TractorCPS", TractorCPSSave);
		PlayerPrefs.SetString ("TractorLevel", TractorLevelSave);
		PlayerPrefs.SetString ("TractorCost", TractorCostSave);
		PlayerPrefs.SetString ("TractorPointsPerSecond", TractorPointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}

	//--------------------------  Mill  --------------------------
	public void BuyMill () {
		if (TractorLevel >= 25) {
			//check for the money available
			if (scoreCount >= MillCost) {
				m_source.clip = btnClick;
				m_source.Play();
				scoreCount -= MillCost;
				MillLevel += 1;
				MillCPS = MillCPS + 250000000;
				MillPointsPerSecond = MillCPS;
				MillCost += 95000000000;
				imgMill.SetActive(true);
			} else {
				m_source.clip = btnError;
				m_source.Play();
			}
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
		//enable the GoldApple
		if (MillLevel >= 25) {
			btnGoldApple.GetComponent<Button>().interactable = true;
		}
		//Mill txt update
		MillCPSTxt.text = "C.P.S : " + MillCPS;
		MillLevelTxt.text = "Lvl : " + MillLevel;
		MillCostTxt.text = MillCost + "$";
		//convert Mill data to string to save in PlayerPrefs
		string MillCPSSave = MillCPS.ToString ();
		string MillLevelSave = MillLevel.ToString ();
		string MillCostSave = MillCost.ToString ();
		string MillPointsPerSecondSave = MillPointsPerSecond.ToString ();
		//save Mill data to PlayerPrefs
		PlayerPrefs.SetString ("MillCPS", MillCPSSave);
		PlayerPrefs.SetString ("MillLevel", MillLevelSave);
		PlayerPrefs.SetString ("MillCost", MillCostSave);
		PlayerPrefs.SetString ("MillPointsPerSecond", MillPointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}

	//--------------------------  GoldApple  --------------------------
	public void BuyGoldApple () {
		if (MillLevel >= 25) {
			//check for the money available
			if (scoreCount >= GoldAppleCost) {
				m_source.clip = btnClick;
				m_source.Play();
				scoreCount -= GoldAppleCost;
				GoldAppleLevel += 1;
				GoldAppleCPS = GoldAppleCPS + 1000000000;
				GoldApplePointsPerSecond = GoldAppleCPS;
				GoldAppleCost += 300000000000;
				imgGoldApple.SetActive(true);
			} else {
				m_source.clip = btnError;
				m_source.Play();
			}
		} else {
			m_source.clip = btnError;
			m_source.Play();
		}
		//GoldApple txt update
		GoldAppleCPSTxt.text = "C.P.S : " + GoldAppleCPS;
		GoldAppleLevelTxt.text = "Lvl : " + GoldAppleLevel;
		GoldAppleCostTxt.text = GoldAppleCost + "$";
		//convert GoldApple data to string to save in PlayerPrefs
		string GoldAppleCPSSave = GoldAppleCPS.ToString ();
		string GoldAppleLevelSave = GoldAppleLevel.ToString ();
		string GoldAppleCostSave = GoldAppleCost.ToString ();
		string GoldApplePointsPerSecondSave = GoldApplePointsPerSecond.ToString ();
		//save GoldApple data to PlayerPrefs
		PlayerPrefs.SetString ("GoldAppleCPS", GoldAppleCPSSave);
		PlayerPrefs.SetString ("GoldAppleLevel", GoldAppleLevelSave);
		PlayerPrefs.SetString ("GoldAppleCost", GoldAppleCostSave);
		PlayerPrefs.SetString ("GoldApplePointsPerSecond", GoldApplePointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}
}
