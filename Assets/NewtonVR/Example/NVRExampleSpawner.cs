using UnityEngine;
using System.Collections;
using NewtonVR;

namespace NewtonVR.Example {
    public class NVRExampleSpawner : MonoBehaviour {
        public NVRButton Button;
        public DigitalRuby.PyroParticles.FireBaseScript flameoHotMan;

        public GameObject ToCopy;

        private void Update() {
            if (Button.ButtonDown) {
                if (flameoHotMan) {
                    flameoHotMan.StartParticleSystems();
                }
            }

            if (Button.ButtonUp) {
                if (flameoHotMan) {
                    flameoHotMan.StopParticleSystems();
                }
            }
        }
    }
}