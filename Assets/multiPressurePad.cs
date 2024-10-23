using UnityEngine;

public class multiPressurePad : MonoBehaviour
{
    public Animator Door;
    public Animator pPad;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Something Hit Trigger");
        if (other.gameObject.tag == "Player")
        {
            Door.SetBool("openDoor", true);
            pPad.SetBool("padPressed", true);
            Debug.Log("Player Hit Trigger");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Door.SetBool("openDoor", false);
        }
    }
}
