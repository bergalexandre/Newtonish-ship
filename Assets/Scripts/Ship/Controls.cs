using UnityEngine;
using UnityEngine.InputSystem;

namespace Ship.Controls {
    public class PlayerControls : PlayableShip.IShipActions
    {
        private GameObject ship;
        
        private Vector3 pitchAndRollSpeed;
        private Vector3 localRotation;


        private Vector3 maxSpeed;
        private Vector3 speed;
        private Vector3 maxAccelerate;
        private Vector3 accelerate; 
        public PlayerControls(GameObject _ship) {
            ship = _ship;

            maxSpeed = new Vector3(0.1f, 2f, 0.1f);
            maxAccelerate = new Vector3(0.05f, 0.2f, 0.05f);
            pitchAndRollSpeed = new Vector3(1f, 1f, 0.2f);


        }

        public void UpdateShipPosition() {
            ship.transform.Translate(speed);
            ship.transform.Rotate(Vector3.Scale(localRotation, pitchAndRollSpeed);
        }

        private System.Single axe_progressif(System.Single x) {
            return Mathf.Pow(x, 3.0f);
        }

        public void OnSteeringleftright(InputAction.CallbackContext context) {
            Debug.Log($"steering leftirght {context.ReadValue<System.Single>()}");
            float angle = axe_progressif(context.ReadValue<System.Single>());
            localRotation.z = angle;
        }
        public void OnSteeringupdown(InputAction.CallbackContext context) {
            Debug.Log($"steering downup {context.ReadValue<System.Single>()}");
            float angle = axe_progressif(context.ReadValue<System.Single>());
            localRotation.x = angle;

        }
        public void OnRoll(InputAction.CallbackContext context) {
            Debug.Log($"roll {context.ReadValue<System.Single>()}");
            float angle = axe_progressif(context.ReadValue<System.Single>());
            localRotation.y = angle;
        }
        public void OnSlide_speed(InputAction.CallbackContext context) {
            Debug.Log($"speed {context.ReadValue<System.Single>()}");
            speed.y = -1 * context.ReadValue<System.Single>();
        }
        public void OnStrafeleftright(InputAction.CallbackContext context) {
            Debug.Log("strafe left right");
            speed.x = context.ReadValue<System.Single>();
        }
        public void OnStrafeupdown(InputAction.CallbackContext context) {
            Debug.Log("strafe up down");
            speed.z = -1 * context.ReadValue<System.Single>();
        }
        public void OnShootprimary(InputAction.CallbackContext context) {
            Debug.Log("shoot");
        }
    }
}