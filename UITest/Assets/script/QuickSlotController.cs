using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickSlotController : MonoBehaviour
{
    [SerializeField] private Slot[] quickSlots;
    [SerializeField] private Transform tf_parent;

    private int selectedSlot;
    [SerializeField] private GameObject go_SelectedImage;
        
    
    void Start()
    {
        quickSlots = tf_parent.GetComponentsInChildren<Slot>();
        selectedSlot =0;    
    }

    
    void Update()
    {
        TryInputNumber();
        
    }
    private void TryInputNumber()
    {
        if(Input.GetKeyDown(KeyCode.Alpha0))
        {
            ChangeSlot(0);
            Debug.Log("0 동작확인");
        }
            
        else if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            ChangeSlot(1);
            Debug.Log("1 동작확인");
        }
            
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            ChangeSlot(2);
            Debug.Log("2 동작확인");
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            ChangeSlot(3);
            Debug.Log("3 동작확인");
        }
            
        else if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            ChangeSlot(4);
            Debug.Log("4 동작확인");
        }
            
        else if(Input.GetKeyDown(KeyCode.Alpha5))
        {
            ChangeSlot(5);
            Debug.Log("5 동작확인");
        }
            
        else if(Input.GetKeyDown(KeyCode.Alpha6))
        {
            ChangeSlot(6);
            Debug.Log("6 동작확인");
        }
            
        else if(Input.GetKeyDown(KeyCode.Alpha7))
        {
            ChangeSlot(7);
            Debug.Log("7 동작확인");
        }
            
        else if(Input.GetKeyDown(KeyCode.Alpha8))
        {
            ChangeSlot(8);
            Debug.Log("8 동작확인");
        }
            
    }

    private void ChangeSlot(int _num)
    {
        SelectedSlot(_num);
 //       Execute();
    }
    private void SelectedSlot(int _num)
    {
        selectedSlot = _num;

//        go_SelectedImage.transform.position=quickSlots[selectedSlot].transform.position;
    }
    // private void Execute()
    // {
    //     if(quickSlots[selectedSlot].item !=  null)
    //     {
    //         if(quickSlots[selectedSlot].item.)
    //     }
    // }
}
