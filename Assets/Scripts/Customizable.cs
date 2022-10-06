using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Customizable : MonoBehaviour
{
    public List<Customization> Customizations;
    int _currentCustomizationIndex;
    public Customization CurrentCustomization { get; private set; }

    void Awake()
    {
        foreach (var customization in Customizations)
        {
            customization.UpdateSubObjects();
        }
    }

    void Update()
    {
        SelectCustomizationWithButtons();
    }
    public void NextEquipment()
    {
        CurrentCustomization.NextSubObject();
    }

    void SelectCustomizationWithButtons()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
            _currentCustomizationIndex++;
        if (Input.GetKeyDown(KeyCode.UpArrow))
            _currentCustomizationIndex--;
        if (_currentCustomizationIndex < 0)
            _currentCustomizationIndex = Customizations.Count - 1;
        if (_currentCustomizationIndex >= Customizations.Count)
            _currentCustomizationIndex = 0;
        CurrentCustomization = Customizations[_currentCustomizationIndex];
    }
}

[Serializable]
public class Customization
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
