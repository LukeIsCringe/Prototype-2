using UnityEngine;

public class WinTriggerRight : MonoBehaviour
{
    public bool p2Win;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            p2Win = true;
        }
    }
}
