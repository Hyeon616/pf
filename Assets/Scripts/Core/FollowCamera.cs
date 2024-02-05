using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace RPG.Core
{
    public class FollowCamera : MonoBehaviour
    {
        [SerializeField] Transform target;

        public GameObject player;
        public GameObject cam;

        private float xRotateMove, yRotateMove;

        public float rotateSpeed = 500.0f;
        void LateUpdate()
        {
            transform.position = target.position;

            if (Input.GetMouseButton(2))
            {
                xRotateMove = Input.GetAxis("Mouse X") * Time.deltaTime * rotateSpeed;
                yRotateMove = Input.GetAxis("Mouse Y") * Time.deltaTime * rotateSpeed;

                Vector3 stagePosition = player.transform.position;

                transform.RotateAround(stagePosition, Vector3.right, -yRotateMove);
                transform.RotateAround(stagePosition, Vector3.up, -xRotateMove);

                

                transform.LookAt(stagePosition);
            }

        }
    }

}