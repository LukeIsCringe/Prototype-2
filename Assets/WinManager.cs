using UnityEngine;
using UnityEngine.SceneManagement;

public class WinManager : MonoBehaviour
{
    public GameObject wtLeftGO;
    public GameObject wtRightGO;
    public void Update()
    {
        WinTriggerLeft wtLeft = wtLeftGO.GetComponent<WinTriggerLeft>();
        WinTriggerRight wtRight = wtRightGO.GetComponent<WinTriggerRight>(); 

        if (wtLeft.p1Win && wtRight.p2Win)
        {
            SceneManager.LoadScene("End");
            Debug.Log("Win");
        }
    }
}
