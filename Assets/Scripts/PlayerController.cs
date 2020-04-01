using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private int count;
    public float speed;
    public Text countText;
    public Text winText;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        UpdateCountText();
    }
    public void FixedUpdate()
    {
        // get keyboard inputs
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement*speed);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickupItem"))
        {
            other.gameObject.SetActive(false);
            count++;
            UpdateCountText();
        }
    }

    public void UpdateCountText()
    {
        countText.text = "Count: " + count.ToString();
        if(count >= 12)
        {
            winText.text = "You Win!";
        }
    }
}
