using UnityEngine;

public class WallController : MonoBehaviour
{
    public GameObject Wall;  // Reference to the wall GameObject

    public GameObject player;

    // Method to make the wall disappear
    void HideWall()
    {
        Wall.SetActive(false); // Disables the wall GameObject
    }
    // Method to make the wall reappear
    void ShowWall()
    {   //I want to make the wall reappear put in playercontrollerscript
        
    }
}