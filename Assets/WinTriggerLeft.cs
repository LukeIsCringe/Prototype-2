using UnityEngine;

public class WinTriggerLeft : MonoBehaviour
{
    public bool p1Win;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            p1Win = true;
        }
    }
}
