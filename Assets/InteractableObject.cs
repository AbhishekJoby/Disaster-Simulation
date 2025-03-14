using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
     Outline outline;
     public string message;

     public UnityEvent OnInteract;

        void Start()
        {
            outline = GetComponent<Outline>();
            DisableOutline();

        }
        public void DisableOutline()
        {
            outline.enabled = false;
        }
         public void EnableOutine()
        {
            outline.enabled = true;
        }
        public void Interact()
        {
            OnInteract.Invoke();
        }

}