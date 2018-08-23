using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallNodeDialog : MonoBehaviour {

    private SmallNode target;
    public GameObject ui;

    public BuildingBlueprint building_1;

    public void Show(SmallNode target)
    {
        this.target = target;
        //transform.position = target.GetBuildPosition();
        ui.SetActive(true);
    }
    
    public void Hide()
    {
        ui.SetActive(false);
    }

    public void SelectBuilding_1()
    {
        target.Build(building_1);
        Hide();
        Debug.Log("Select Building 1");
    
    }
}
