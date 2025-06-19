using UnityEngine;

namespace RMC.UnityAIDemos
{
    public class RotateCube : MonoBehaviour
    {
        public float RotateSpeed = 30f;

        // Update is called once per frame
        void Update()
        {
            // Rotates the cube at 30 degrees per second around y axis
            transform.Rotate(0, RotateSpeed * Time.deltaTime, 0);
        }
    }
}