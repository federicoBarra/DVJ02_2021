using UnityEngine;

namespace DVJ02.Semana05
{
    public class QuaternionsExample : MonoBehaviour
    {
        [Header("Angle")]
        public Transform AngleBetween01;
        public Transform AngleBetween02;
        public float angle;

        [Header("MovingObjects")]
        public Transform pingPongTransform;
        public Transform SetLookRotation;

        [Header("RotateTowards")]
        public Transform RotateTowards;
        public Transform RotateTowardsDestiny;
        public float RotateTowardsSpeed = 2;

        [Header("Slerp")]
        public Transform SlerpTarget;
        public Transform SlerpFrom;
        public Transform SlerpTo;

        private void Update()
        {
            //ANGLE BETWEEN TWO QUATERNIONS
            angle = Quaternion.Angle(AngleBetween01.rotation, AngleBetween02.rotation);

            //MOVING OBJECT
            pingPongTransform.transform.position = new Vector3(Mathf.PingPong(Time.time, 2), Mathf.PingPong(Time.time, 5), Mathf.PingPong(Time.time, 10));

            //SET LOOK ROTATION USE
            Quaternion q01 = Quaternion.identity;

            Vector3 pingV3 = pingPongTransform.position;
            Vector3 source = SetLookRotation.position;

            //pingV3.x = 0;

            q01.SetLookRotation(pingV3 - source, Vector3.up); // similar to Quaternion.LookRotation
            SetLookRotation.rotation = Quaternion.Slerp(SetLookRotation.rotation, q01, Time.deltaTime / RotateTowardsSpeed);

            Quaternion q02 = Quaternion.LookRotation(pingV3 - source, Vector3.up);

            //SetLookRotation.rotation.SetLookRotation();

            //transform.Rotate(Vector3.up);

            //ROTATE TOWARDS
            RotateTowards.rotation = Quaternion.RotateTowards(RotateTowards.rotation, RotateTowardsDestiny.rotation, RotateTowardsSpeed * Time.deltaTime);

            //SLERP ROTATION
            SlerpTarget.rotation = Quaternion.Slerp(SlerpFrom.rotation, SlerpTo.rotation, Mathf.PingPong(Time.time, 2) / 2);
        }
    }
}
