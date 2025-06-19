using UnityEngine;

namespace RMC.UnityAIDemos
{

    public class FallingCube : MonoBehaviour
    {
        //  Fields ----------------------------------------
        [SerializeField]
        private AudioClip _audioClip;

        //  Variables -------------------------------------
        private AudioSource _audioSource;

        //  Unity Methods ---------------------------------
        protected void Start()
        {
            _audioSource = gameObject.AddComponent<AudioSource>();
        }

        private void OnCollisionEnter(Collision other)
        {
            //Debug.Log($"FallingCube collided with {other.gameObject.name} at {other.GetContact(0).point}");

            // Stop after X seconds
            _audioSource.PlayOneShot(_audioClip);
            Invoke(nameof(StopAudio), 0.25f);_audioSource.PlayOneShot(_audioClip);
        }

        private void StopAudio()
        {
            _audioSource.Stop();
        }
    }
}