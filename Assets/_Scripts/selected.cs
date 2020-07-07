using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

 
 public class selected: MonoBehaviour, ISelectHandler, IDeselectHandler // required interface for OnSelect
 {
     public GameObject events;
     public bool opened;
    public void OnSelect(BaseEventData eventData)
    {
       events.GetComponent<game>().selectedButton = transform.name;
       this.gameObject.GetComponent<Image>().color = Color.green;

    }
        public void OnDeselect(BaseEventData eventData)
    {
        this.gameObject.GetComponent<Image>().color = Color.grey;
    }


    

 }


