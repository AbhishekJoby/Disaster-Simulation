using UnityEngine;

public class PlayerIntract : MonoBehaviour
{
    public float interactDistance = 3f;
    private InteractableObject currentInteractableObject;

    
    void Update()
    {
        CheckInteraction();
    }
    void CheckInteraction()
    {
        RaycastHit hit;
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);  
        if(Physics.Raycast(ray,out hit,interactDistance)){
            if(hit.collider.CompareTag("Interactable")){
                InteractableObject newinteractable=hit.collider.GetComponent<InteractableObject>();
                if(newinteractable.enabled){
                    SetNewCurrentInteractable(newinteractable);
                }
                else{
                    DisableCurrentInteractable();
                }
            }
            else{
                DisableCurrentInteractable();
            }
        }
        else{
            DisableCurrentInteractable();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (currentInteractableObject != null)
            {
                currentInteractableObject.Interact();
            }
        }
    }
    void SetNewCurrentInteractable(InteractableObject newInteractable)
    {
        currentInteractableObject = newInteractable;
        currentInteractableObject.EnableOutine();
    }
    void DisableCurrentInteractable()
    {
        if (currentInteractableObject != null)
        {
            currentInteractableObject.DisableOutline();
            currentInteractableObject = null;
        }
    }  
}
