using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static bool isPause = false;
    public GameObject player;
    public GameObject menuSet;


    //test 1
    ///test 111
    
    //test2

    void Start()
    {
        GameLoad();
        
    }
    

    void Update()
    {
        // if(Input.GetButtonDown("Exit_Button"))
        // {
        //     if(menuSet.activeSelf)
        //         menuSet.SetActive(false);
        //     else
        //         menuSet.SetActive(true);
        // }
            
        
    }
    public void GameSave()
    {
        if(PlayerPrefs.HasKey("PlayerX"))
            return;

        PlayerPrefs.SetFloat("PlayerX",player.transform.position.x);
        PlayerPrefs.SetFloat("PlayerY",player.transform.position.y);
        PlayerPrefs.Save();

        // menuSet.SetActive(false);
    }
    public void GameLoad()
    {
        float x = PlayerPrefs.GetFloat("Playerx");
        float y = PlayerPrefs.GetFloat("PlayerY");

        player.transform.position = new Vector3(x,y,0);

    }
}
