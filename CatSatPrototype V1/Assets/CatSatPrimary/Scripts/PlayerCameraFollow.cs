using UnityEngine;

public class PlayerCameraFollow : MonoBehaviour
{
    public Transform player;
    public int vecX;
    public int vecY;
    public int vecZ;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(vecX, vecY, vecZ);
    }
}
