using UnityEngine;

public class areaTrigger : MonoBehaviour
{
   public string message="You feel suffocated.";
    public bool suffocating = false;
    playerstat playerstat;
    void Start()
    {
        
    }
    void Update(){
        if(suffocating)
        {
            playerstat.TakeDamage(20*Time.deltaTime,"suffocation");
        }
    }
     void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            Debug.Log("Player entered the area");
            playerstat =  other.GetComponent<playerstat>();
            playerstat.UpdateInfoText(message);
            suffocating = true;
        }
    }
     void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            Debug.Log("Player left the area");
            playerstat playerstat =  other.GetComponent<playerstat>();
            playerstat.UpdateInfoText("");
            suffocating = false;
        }
    }
}
