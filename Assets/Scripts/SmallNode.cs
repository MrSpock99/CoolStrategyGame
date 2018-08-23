using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SmallNode : MonoBehaviour {

    public Color hoverColor;
    public Vector3 offset;

    private GameObject building;
    private BuildingBlueprint buildingBlueprint;

    private Renderer rend;
    private Color startColor;

    public SmallNodeDialog dialog;


	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
	}

    public Vector3 GetBuildPosition()
    {
        return transform.position + offset;
    }

    public void Build(BuildingBlueprint buildingBlueprint)
    {
        this.buildingBlueprint = buildingBlueprint;
        building = (GameObject)Instantiate(buildingBlueprint.prefab, GetBuildPosition(), Quaternion.identity);

    }

    private void OnMouseDown()
    {
        dialog.Show(this);
    }


}
