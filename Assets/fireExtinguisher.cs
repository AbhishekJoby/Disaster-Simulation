using UnityEngine;

public class fireExtinguisher : MonoBehaviour
{
    GameObject player;
    GameObject hand;
    Camera main;
    bool isPickedUp = false;
    public float range = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player");
         hand = player.transform.Find("Hand").gameObject;
         main = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) && isPickedUp)
        {
            Debug.Log("Fire extinguisher used");
            UseFireExtinguisher();
        }
        if(Input.GetKeyDown(KeyCode.Q))
        {
            if(isPickedUp)
            {
                OnDrop();
            }
            else
            {
                OnPickup();
            }
        }
    }

    public void OnPickup()
    {
        transform.parent = hand.transform;
        transform.localPosition = new Vector3(0, 0, 0);
        isPickedUp = true;
    }
    public void OnDrop()
    {
        transform.parent = null;
        isPickedUp = false;
    }

    void UseFireExtinguisher()
    {
        if(Physics.Raycast(main.transform.position, main.transform.forward, out RaycastHit hit, range))
        {
            if(hit.collider.CompareTag("Fire"))
            {
                hit.collider.GetComponent<fire>().Extinguish();
            }
        }
    }
}
