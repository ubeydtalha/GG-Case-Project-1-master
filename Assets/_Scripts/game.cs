using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


 
 public class game: MonoBehaviour// required interface for OnSelect
 {
     public float wait;
     public string selectedButton;
    public Button [] butonlar;
    public Button unlock;

    int ran;
    int select;
    int i;
    public void salla(){
                ran = Random.Range(1,10);
        select = Random.Range(0,8);
        i = 0;
    }
    public void random(){
        unlock.GetComponent<Button>().interactable = false;
           
            int r=Random.Range(0,8);
            if( butonlar[r].GetComponent<selected>().opened == false)butonlar[r].GetComponent<Selectable>().Select(); 
            delay();
            if( butonlar[r].GetComponent<selected>().opened == true) ran+=1;
           
            Debug.Log(r);
            if (i<=ran) Invoke("random",1f);
            else {
                  butonlar[r].GetComponent<Button>().onClick.Invoke();
                   butonlar[r].GetComponent<selected>().opened = true;  
                    unlock.GetComponent<Button>().interactable = true;
                    // oyuncunun hakkı kalıp kalamdığı kontrol edilip ona göre true yada false yazılmalı
            return;} 
            i+=1;
    }
    IEnumerator delay(){
        yield return new WaitForSeconds(wait*Time.deltaTime);
    }
 }


