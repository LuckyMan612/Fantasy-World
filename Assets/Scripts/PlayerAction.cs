using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerAction : MonoBehaviour
{
    public bool isGameEnded;
    [SerializeField] GameObject FinishScreen;
    [SerializeField] TextMeshProUGUI timeText;
    private float Timer;
    void Start(){
        Timer=0;
    }
    void Update(){
        if(!isGameEnded){
        Timer+=Time.deltaTime;
        timeText.text=Timer.ToString("0.000")+"s";
        }
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Finish")){
            isGameEnded=true;
            FinishScreen.SetActive(true);

        }
    }
}
