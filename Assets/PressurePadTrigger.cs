using UnityEngine;

public class PressurePadTrigger : MonoBehaviour
{
    public Animator Door;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Something Hit Trigger");
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Cube")
        {
            Door.SetBool("openDoor", true);
            Debug.Log("Something hit trigger");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Cube")
        {
            Door.SetBool("openDoor", false);
        }
    }
}
