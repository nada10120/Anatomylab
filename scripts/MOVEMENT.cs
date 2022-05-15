using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine;


public class MOVEMENT : MonoBehaviour

{
  
    public CharacterController controller;
    public float speed = 12f;
    public Transform target;
    public Transform player;
    public GameObject text;
    public MouseLook playerCameraLook;
    public Transform Camera;
    void Start()
    {
        playerCameraLook = (MouseLook)GameObject.Find("Camera").GetComponent("MouseLook");
    }
        // Update is called once per frame
        void Update()
    {
        float y = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * y + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        if (player.position.z >=9.5)
        {
            text.SetActive(true);
            playerCameraLook.enabled = !playerCameraLook.enabled;
            Camera.transform.position = new Vector3(-25.53706f, 1.090001f, 9.785505f);
             Camera.transform.rotation = Quaternion.Euler(0f, 13.79f, 0f);
        }


    }
}
