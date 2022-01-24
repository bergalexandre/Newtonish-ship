using UnityEngine;
using UnityEngine.InputSystem;
using Ship.Controls;

namespace Ship{

[RequireComponent(typeof(PlayerInput))]
    public class InitializePlayerShip : MonoBehaviour
    {

        const double halfJoystick = 0.5;
        @PlayableShip playableShip;
        // Start is called before the first frame update
        public GameObject playerShip;
        float timeSinceLastUpdate;

        private PlayerControls controls;

        void Start()
        {
            //playerShip = GameObject.Find("vaisseau_player");
            //playerShip.GetComponent<PlayerInput>().actions =;
            Debug.Log("created");
            controls = new PlayerControls(playerShip);
            playableShip = new @PlayableShip();
            playableShip.ship.SetCallbacks(controls);
            playableShip.ship.Enable();
        }

        void Awake()
        {
            Debug.Log("Awake");
        }

        void Update() {
            timeSinceLastUpdate += Time.deltaTime;
            if (timeSinceLastUpdate > 0.02f)
            {
                timeSinceLastUpdate = 0.0f;
                controls.UpdateShipPosition();
                
            }
        }

        
    }
}