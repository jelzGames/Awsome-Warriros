using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMenu : MonoBehaviour {

    public GameObject[] characters;
    public GameObject charPosition;

    private int knight_Warrior_Index = 0;
    private int king_Warrior_Index = 1;
    private int CatGirl_Warrior_Index = 2;


    // Use this for initialization
    void Start () {
        characters[knight_Warrior_Index].SetActive(true);
        characters[knight_Warrior_Index].transform.position = charPosition.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SelectCharacter(int index)
    {
        //get the ui object selected
        //UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        TurnOffCharacters();
        characters[index].SetActive(true);
        characters[index].transform.position = charPosition.transform.position;
    }

    void TurnOffCharacters()
    {
        for (int i = 0; i < characters.Length; i++)
        {
            characters[i].SetActive(false);
        }
    }


}
