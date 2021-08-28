using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseMenus : MonoBehaviour
{
    public void CloseMenu()
    {
        this.transform.gameObject.SetActive(false);
    }
}
