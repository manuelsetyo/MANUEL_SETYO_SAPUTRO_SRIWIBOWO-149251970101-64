using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePanel : MonoBehaviour
{
    public GameObject PanelStart;
    public GameObject PanelEnd;

    public void ChangeNewPanel() {
        PanelStart.SetActive(false);
        PanelEnd.SetActive(true);
    }
}
