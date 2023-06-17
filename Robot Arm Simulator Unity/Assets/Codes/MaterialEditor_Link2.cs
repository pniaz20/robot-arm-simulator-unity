using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class MaterialEditor_Link2 : MonoBehaviour
{
    MeshRenderer meshRenderer;
    public Dropdown LinkSelection;
    private int a;
    public GameObject Link2_Menu;
    private Color CurrentColor;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        CurrentColor = meshRenderer.material.color;
    }

    public void LinkSelectionValueChanged()
    {
        a = LinkSelection.value;
    }
    private void Update()
    {
        if (a == 2)
            Link2_Menu.SetActive(true);
        else
            Link2_Menu.SetActive(false);
    }

    public void Original_Color()
    {

        meshRenderer.material.color = CurrentColor;

    }
    public void Red_MaterialColor()
    {
        meshRenderer.material.color = Color.red;
    }

    public void Green_MaterialColor()
    {
        meshRenderer.material.color = Color.green;
    }

    public void White_MaterialColor()
    {
        meshRenderer.material.color = Color.white;
    }



    public void MetallicSlider(float metallic)
    {
        meshRenderer.material.SetFloat("_Metallic", metallic);
    }

    public void SmoothnessSlider(float smoothness)
    {
        meshRenderer.material.SetFloat("_Glossiness", smoothness);
    }



}
