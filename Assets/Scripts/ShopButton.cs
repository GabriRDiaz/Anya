using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopButton : MonoBehaviour
{
    public GameObject ShopPanel;
    // Start is called before the first frame update

    public void OpenPanel()
    {
        if (ShopPanel != null)
        {
                ShopPanel.SetActive(true);

        }
    }

    public void CloseShop()
    {
        if(ShopPanel != null)
        {
                ShopPanel.SetActive(false);
        }
    }
}
