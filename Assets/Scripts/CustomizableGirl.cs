using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizableGirl : MonoBehaviour
{
    public List<CustomizationGirl> CustomizationsGirl;
    int _currentCustomizationIndexGirls;
    public CustomizationGirl CurrentCustomizationGirl { get; private set; }

    void Awake()
    {
        foreach (var customizationGirl in CustomizationsGirl)
        {
            customizationGirl.UpdateSubObjects();
        }
    }

    void Update()
    {
        SelectCustomizationWithButtons();
    }
    public void NextEquipment()
    {
        CurrentCustomizationGirl.NextSubObject();
    }

    void SelectCustomizationWithButtons()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
            _currentCustomizationIndexGirls++;
        if (Input.GetKeyDown(KeyCode.UpArrow))
            _currentCustomizationIndexGirls--;
        if (_currentCustomizationIndexGirls < 0)
            _currentCustomizationIndexGirls = CustomizationsGirl.Count - 1;
        if (_currentCustomizationIndexGirls >= CustomizationsGirl.Count)
            _currentCustomizationIndexGirls = 0;
        CurrentCustomizationGirl = CustomizationsGirl[_currentCustomizationIndexGirls];
    }
}
[Serializable]
public class CustomizationGirl
{
    public string DisplayName;
    public List<GameObject> SubObjects;
    int _materialIndex;
    int _subObjectIndex;

    public void NextSubObject()
    {
        _subObjectIndex++;
        if (_subObjectIndex >= SubObjects.Count)
            _subObjectIndex = 0;

        UpdateSubObjects();
    }

    public void UpdateSubObjects()
    {
        for (var i = 0; i < SubObjects.Count; i++)
            if (SubObjects[i])
                SubObjects[i].SetActive(i == _subObjectIndex);
    }
}
