using UnityEngine;

public class NpcMovement2 : MonoBehaviour
{
    public int moveSpeed2 = 2;
    public Vector3 npcRotation2 = new Vector3(0, 0, 0);

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position + transform.forward, transform.TransformDirection(Vector3.forward), out hit))
        {
            transform.Translate(transform.TransformDirection(transform.forward) * moveSpeed2 * Time.deltaTime);
        }
        else 
        {
            npcRotation2 = new Vector3(0, 180, 0);
            transform.Rotate(npcRotation2);
        }
    }
}
