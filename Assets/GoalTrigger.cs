using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    bool reached;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            reached = true;
            Debug.Log("Goal reached!");
        }
    }

    void OnGUI()
    {
        if (!reached) return;
        GUIStyle style = new GUIStyle(GUI.skin.label);
        style.fontSize = 48;
        style.alignment = TextAnchor.MiddleCenter;
        style.normal.textColor = Color.white;
        GUI.Label(new Rect(0, 0, Screen.width, Screen.height), "You made it!", style);
    }
}
