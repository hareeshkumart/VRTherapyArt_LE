﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuScript : MonoBehaviour, IPointerClickHandler
{
    public GameObject FishTask;
    public GameObject fishButton;

    public GameObject elipseTask;

    public GameObject kyteTask;

    public GameObject infinityTask;

    public GameObject ThreeDFishTask;
    public GameObject threeDfishButton;

    public GameObject chickenTask;
    public GameObject chickenButton;

    public GameObject squareTask;
    public GameObject squareButton;
    public GameObject squareButton2;

    public GameObject afterMenu1;
    public GameObject afterMenu2;

    private TaskCounter TaskCounterScript;
    private ResetDots ResetDotsScript;
    private SpecialTaskCounter SpecialTaskCounterScript;

    public void Start()
    {
        //can't call setActive because that disables every component so scripts no longer call Update()
        //instead I am hiding the objects we don't want shown under the floor of the game
        /*
        FishTask.SetActive(false);
        chickenTask.SetActive(false);
        squareTask.SetActive(false);
        ThreeDFishTask.SetActive(false);

        fishButton.SetActive(true);
        chickenButton.SetActive(true);
        squareButton.SetActive(true);
        threeDfishButton.SetActive(true);

        afterMenu1.SetActive(false);
        afterMenu2.SetActive(false);
       // afterCube1.SetActive(false);
      //  afterCube2.SetActive(false);
        */
        FishTask.transform.position = new Vector3(0f, -50f, 0f);
        chickenTask.transform.position = new Vector3(0f, -50f, 0f);
        squareTask.transform.position = new Vector3(0f, -50f, 0f);
        elipseTask.transform.position = new Vector3(0f, -50f, 0f);
        kyteTask.transform.position = new Vector3(0f, -50f, 0f);
        infinityTask.transform.position = new Vector3(0f, -50f, 0f);
        ThreeDFishTask.transform.position = new Vector3(0f, -50f, 0f);

        fishButton.transform.position = new Vector3(0.064833f, 1.651885f, 0.394774f);
        chickenButton.transform.position = new Vector3(0.064833f, 1.13798f, 0.394774f);
        //squareButton.transform.position = new Vector3(0.064833f, 2.216545f, 0.394774f);
        squareButton.transform.position = new Vector3(-1.45f, 2.216545f, 0.394774f);
        threeDfishButton.transform.position = new Vector3(0.064833f, 0.597109f, 0.394774f);
        squareButton2.transform.position = new Vector3(1.45f, 2.216545f, 0.394774f);


        afterMenu1.transform.position = new Vector3(0f, -50f, 0f);
        afterMenu2.transform.position = new Vector3(0f, -50f, 0f);

        TaskCounterScript = GameObject.Find("Progress Text (TMP)").GetComponent<TaskCounter>();
        TaskCounterScript.Start();

        Debug.Log("Menu Script Started");
    }

    //level menu shows up every time you press return button 
    public void restart()
    {
        FishTask.transform.position = new Vector3(0f, -50f, 0f);
        chickenTask.transform.position = new Vector3(0f, -50f, 0f);
        squareTask.transform.position = new Vector3(0f, -50f, 0f);
        elipseTask.transform.position = new Vector3(0f, -50f, 0f);
        kyteTask.transform.position = new Vector3(0f, -50f, 0f);
        infinityTask.transform.position = new Vector3(0f, -50f, 0f);
        ThreeDFishTask.transform.position = new Vector3(0f, -50f, 0f);

        fishButton.transform.position = new Vector3(0.064833f, 1.651885f, 0.394774f);
        chickenButton.transform.position = new Vector3(0.064833f, 1.13798f, 0.394774f);
        //squareButton.transform.position = new Vector3(0.064833f, 2.216545f, 0.394774f);
        squareButton.transform.position = new Vector3(-1.45f, 2.216545f, 0.394774f);
        threeDfishButton.transform.position = new Vector3(0.064833f, 0.597109f, 0.394774f);
        squareButton2.transform.position = new Vector3(1.45f, 2.216545f, 0.394774f);

        afterMenu1.transform.position = new Vector3(0f, -50f, 0f);
        afterMenu2.transform.position = new Vector3(0f, -50f, 0f);

        Debug.Log("Menu Script RESTART");
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        //Use this to tell when the user right-clicks on the Button
        if (pointerEventData.button == PointerEventData.InputButton.Right)
        {
            //Output to console the clicked GameObject's name and the following message. You can replace this with your own actions for when clicking the GameObject.
            Debug.Log(name + " Game Object Right Clicked!");
        }
    }


    public void SquareIntialization()
    {
        squareTask.SetActive(true);
        Vector3 squarePosition = new Vector3(-0.038f, 1.38f, 1.33f);
        squareTask.transform.position = squarePosition;
        // GameObject.Find("square_dots1").transform.position = new Vector3(-0.038f, 1.38f, 1.33f);
        GameObject.Find("square_dots_edit").transform.position = new Vector3(-0.038f, 1.38f, 1.33f);
        squareTask.transform.eulerAngles = new Vector3(0, 90, 0);

        threeDfishButton.transform.position = new Vector3(0f, -50f, 0f);
        fishButton.transform.position = new Vector3(0f, -50f, 0f);
        chickenButton.transform.position = new Vector3(0f, -50f, 0f);
        squareButton.transform.position = new Vector3(0f, -50f, 0f);
        squareButton2.transform.position = new Vector3(0f, -50f, 0f);

        TaskCounterScript.currentTask = "SquareTask";
        TaskCounterScript.restart();
        ResetDotsScript = squareTask.GetComponent<ResetDots>();
        ResetDotsScript.task = TaskCounterScript.currentTask;
        ResetDotsScript.Start();
        ResetDotsScript.ResetAllDots();
    }

    // TODO Eclipse Init

    public void ElipseIntialization()
    {
        elipseTask.SetActive(true);
        Vector3 ElipsePosition = new Vector3(-0.03f, 0.6f, 0.88f);
        elipseTask.transform.position = ElipsePosition;
        // GameObject.Find("square_dots1").transform.position = new Vector3(-0.038f, 1.38f, 1.33f);
        GameObject.Find("ellipseseparated").transform.position = new Vector3(-0.03f, 0.6f, 0.88f);
        elipseTask.transform.eulerAngles = new Vector3(0, 90, 0);

        threeDfishButton.transform.position = new Vector3(0f, -50f, 0f);
        fishButton.transform.position = new Vector3(0f, -50f, 0f);
        chickenButton.transform.position = new Vector3(0f, -50f, 0f);
        squareButton.transform.position = new Vector3(0f, -50f, 0f);
        squareButton2.transform.position = new Vector3(0f, -50f, 0f);


        TaskCounterScript.currentTask = "ElipseTask";
        TaskCounterScript.restart();
        ResetDotsScript = elipseTask.GetComponent<ResetDots>();
        ResetDotsScript.task = TaskCounterScript.currentTask;
        ResetDotsScript.Start();
        ResetDotsScript.ResetAllDots();
    }
    
    //TODO Kyte Initialization

    public void KyteIntialization()
    {
        kyteTask.SetActive(true);
        Vector3 kytePosition = new Vector3(-0.038f, 1.38f, 1.33f);
        kyteTask.transform.position = kytePosition;
        // GameObject.Find("square_dots1").transform.position = new Vector3(-0.038f, 1.38f, 1.33f);
        GameObject.Find("kite").transform.position = new Vector3(0.372f, 0.283f, 0.985f);
        kyteTask.transform.eulerAngles = new Vector3(0, 90, 0);

        threeDfishButton.transform.position = new Vector3(0f, -50f, 0f);
        fishButton.transform.position = new Vector3(0f, -50f, 0f);
        chickenButton.transform.position = new Vector3(0f, -50f, 0f);
        squareButton.transform.position = new Vector3(0f, -50f, 0f);
        squareButton2.transform.position = new Vector3(0f, -50f, 0f);


        TaskCounterScript.currentTask = "KiteTask";
        TaskCounterScript.restart();
        ResetDotsScript = kyteTask.GetComponent<ResetDots>();
        ResetDotsScript.task = TaskCounterScript.currentTask;
        ResetDotsScript.Start();
        ResetDotsScript.ResetAllDots();
    }
    
    public void InfinityIntialization()
    {
        infinityTask.SetActive(true);
        //Vector3 infinityPosition = new Vector3(-0.038f, 1.38f, 1.33f);
        Vector3 infinityPosition = new Vector3(-0.04f, 0.39f, 0.668f);
        infinityTask.transform.position = infinityPosition;
        // GameObject.Find("square_dots1").transform.position = new Vector3(-0.038f, 1.38f, 1.33f);
        //GameObject.Find("infinity-shape").transform.position = new Vector3(-0.038f, 1.38f, 1.33f);
        GameObject.Find("infinity").transform.position = new Vector3(-0.04f, 0.39f, 0.668f);
        infinityTask.transform.eulerAngles = new Vector3(0, 90, 0);

        threeDfishButton.transform.position = new Vector3(0f, -50f, 0f);
        fishButton.transform.position = new Vector3(0f, -50f, 0f);
        chickenButton.transform.position = new Vector3(0f, -50f, 0f);
        squareButton.transform.position = new Vector3(0f, -50f, 0f);
        squareButton2.transform.position = new Vector3(0f, -50f, 0f);

        TaskCounterScript.currentTask = "InfinityTask";
        TaskCounterScript.restart();
        ResetDotsScript = infinityTask.GetComponent<ResetDots>();
        ResetDotsScript.task = TaskCounterScript.currentTask;
        ResetDotsScript.Start();
        ResetDotsScript.ResetAllDots();
    }

    public void FishIntialization()
    {
        FishTask.SetActive(true);
        Vector3 fishPosition = new Vector3(-0.038f, 1.38f, 1.33f);
        FishTask.transform.position = fishPosition;
        //in Task Counter we hide the dots when there is a victory. this is resetting its position 
        GameObject.Find("fish_dots").transform.position = new Vector3(-0.038f, 1.38f, 1.33f);
        FishTask.transform.eulerAngles = new Vector3(0, 0, 0);
        Debug.Log("FISH Initialization: " + FishTask.activeSelf + " " + fishPosition);

        threeDfishButton.transform.position= new Vector3(0f, -50f, 0f);
        fishButton.transform.position = new Vector3(0f, -50f, 0f);
        chickenButton.transform.position = new Vector3(0f, -50f, 0f);
        squareButton.transform.position = new Vector3(0f, -50f, 0f);
        squareButton2.transform.position = new Vector3(0f, -50f, 0f);

        TaskCounterScript.currentTask = "FishTask";
        TaskCounterScript.restart();
        ResetDotsScript = FishTask.GetComponent<ResetDots>();
        ResetDotsScript.task = TaskCounterScript.currentTask;
        ResetDotsScript.Start();
        ResetDotsScript.ResetAllDots();
    }

    public void ChickenIntialization()
    {
        Debug.Log("CHICK INIT");
        chickenTask.SetActive(true);
        Vector3 chickenPosition = new Vector3(-0.038f, 1.38f, 1.33f);
        chickenTask.transform.position = chickenPosition;
        GameObject.Find("rooster_separate").transform.position = new Vector3(-0.038f, 1.38f, 1.33f);
        chickenTask.transform.eulerAngles = new Vector3(0, 0, 0);

        threeDfishButton.transform.position = new Vector3(0f, -50f, 0f);
        fishButton.transform.position = new Vector3(0f, -50f, 0f);
        chickenButton.transform.position = new Vector3(0f, -50f, 0f);
        squareButton.transform.position = new Vector3(0f, -50f, 0f);
        squareButton2.transform.position = new Vector3(0f, -50f, 0f);

        TaskCounterScript.currentTask = "ChickenTask";
        TaskCounterScript.restart();
        ResetDotsScript = chickenTask.GetComponent<ResetDots>();
        ResetDotsScript.task = TaskCounterScript.currentTask;
        ResetDotsScript.Start();
        ResetDotsScript.ResetAllDots();
    }


    public void ThreeDfishIntialization()
    {
        ThreeDFishTask.SetActive(true);
        Vector3 threeDfishPosition = new Vector3(-0.038f, 1.38f, 1.33f);
        ThreeDFishTask.transform.position = threeDfishPosition;
        GameObject.Find("ThreeDfish_dots").transform.position = new Vector3(-0.038f, 1.38f, 1.33f);
        ThreeDFishTask.transform.eulerAngles = new Vector3(0, 0, 0);
        Debug.Log("3D FISH menu: " + ThreeDFishTask.activeSelf + " " + threeDfishPosition);

        threeDfishButton.transform.position = new Vector3(0f, -50f, 0f);
        fishButton.transform.position = new Vector3(0f, -50f, 0f);
        chickenButton.transform.position = new Vector3(0f, -50f, 0f);
        squareButton.transform.position = new Vector3(0f, -50f, 0f);
        squareButton2.transform.position = new Vector3(0f, -50f, 0f);

        TaskCounterScript.currentTask = "ThreeDFishTask";
        TaskCounterScript.restart();
        ResetDotsScript = ThreeDFishTask.GetComponent<ResetDots>();
        ResetDotsScript.task = TaskCounterScript.currentTask;
        ResetDotsScript.Start();
        ResetDotsScript.ResetAllDots();
    }

    public void RepeatableSquareIntialization()
    {
        squareTask.SetActive(true);
        Vector3 squarePosition = new Vector3(-0.038f, 1.38f, 1.33f);
        squareTask.transform.position = squarePosition;
        // GameObject.Find("square_dots1").transform.position = new Vector3(-0.038f, 1.38f, 1.33f);
        GameObject.Find("square_dots_edit").transform.position = new Vector3(-0.038f, 1.38f, 1.33f);
        squareTask.transform.eulerAngles = new Vector3(0, 90, 0);

        threeDfishButton.transform.position = new Vector3(0f, -50f, 0f);
        fishButton.transform.position = new Vector3(0f, -50f, 0f);
        chickenButton.transform.position = new Vector3(0f, -50f, 0f);
        squareButton.transform.position = new Vector3(0f, -50f, 0f);
        squareButton2.transform.position = new Vector3(0f, -50f, 0f);

        SpecialTaskCounterScript = GameObject.Find("Progress Text (TMP)").GetComponent<SpecialTaskCounter>();
        SpecialTaskCounterScript.Start();
        SpecialTaskCounterScript.currentTask = "SquareTask";
        SpecialTaskCounterScript.restart();
        ResetDotsScript = squareTask.GetComponent<ResetDots>();
        ResetDotsScript.task = SpecialTaskCounterScript.currentTask;
        ResetDotsScript.Start();
        ResetDotsScript.ResetAllDots();
        SpecialTaskCounterScript.ResetDotsScript = ResetDotsScript;
    }
}
