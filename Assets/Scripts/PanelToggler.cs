using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelToggler : MonoBehaviour
{
    bool isOn = false;
    [SerializeField] GameObject InformationPanel;

    public void togglePanel()
    {
        if (isOn)
        {
            InformationPanel.SetActive(false);
            isOn = false;
        }
        else
        {
            InformationPanel.SetActive(true);
            isOn = true;
        }
    }


}
