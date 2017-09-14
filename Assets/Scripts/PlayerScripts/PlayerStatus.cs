using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatus : MonoBehaviour {

    public GameObject[] playerSwords;

    private GameObject itemsPanel;
    
    private void Start()
    {
        GameObject[] buttons = GameObject.FindGameObjectsWithTag("SwordBtn");
        

        foreach (GameObject btn in buttons)
        {
            btn.GetComponent<Button>().onClick.AddListener(ChangeSword);
        }

        itemsPanel = GameObject.Find("Items Panel");
        itemsPanel.SetActive(false);
        
        GameObject.Find("Items").GetComponent<Button>().onClick.AddListener(ActivateItemsPanel);

    }

    // Update is called once per frame
    void Update () {
		
	}
    
    public void ActivateItemsPanel()
    {
        if (itemsPanel.activeInHierarchy)
        {
            itemsPanel.SetActive(false);
        }
        else
        {
            itemsPanel.SetActive(true);
        }
    }

    public void ChangeSword()
    {
        int swordIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

        for (int i = 0;i < playerSwords.Length; i++ )
        {
            playerSwords[i].SetActive(false);
        }

        playerSwords[swordIndex].SetActive(true);

    }
}
