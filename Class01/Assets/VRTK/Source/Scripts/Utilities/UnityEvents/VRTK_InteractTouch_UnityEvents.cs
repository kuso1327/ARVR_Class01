namespace VRTK.UnityEventHelper
{
    using UnityEngine.UI;
    using UnityEngine;
    using UnityEngine.Events;
    using System;

    [AddComponentMenu("VRTK/Scripts/Utilities/Unity Events/VRTK_InteractTouch_UnityEvents")]
    public sealed class VRTK_InteractTouch_UnityEvents : VRTK_UnityEvents<VRTK_InteractTouch>
    {
        [Serializable]
        public sealed class ObjectInteractEvent : UnityEvent<object, ObjectInteractEventArgs> { }

        public ObjectInteractEvent OnControllerStartTouchInteractableObject = new ObjectInteractEvent();
        public ObjectInteractEvent OnControllerTouchInteractableObject = new ObjectInteractEvent();
        public ObjectInteractEvent OnControllerStartUntouchInteractableObject = new ObjectInteractEvent();
        public ObjectInteractEvent OnControllerUntouchInteractableObject = new ObjectInteractEvent();
        public ObjectInteractEvent OnControllerRigidbodyActivated = new ObjectInteractEvent();
        public ObjectInteractEvent OnControllerRigidbodyDeactivated = new ObjectInteractEvent();

        protected override void AddListeners(VRTK_InteractTouch component)
        {
            component.ControllerStartTouchInteractableObject += ControllerStartTouchInteractableObject;
            component.ControllerTouchInteractableObject += ControllerTouchInteractableObject;
            component.ControllerStartUntouchInteractableObject += ControllerStartUntouchInteractableObject;
            component.ControllerUntouchInteractableObject += ControllerUntouchInteractableObject;
            component.ControllerRigidbodyActivated += ControllerRigidbodyActivated;
            component.ControllerRigidbodyDeactivated += ControllerRigidbodyDeactivated;
        }

        protected override void RemoveListeners(VRTK_InteractTouch component)
        {
            component.ControllerStartTouchInteractableObject -= ControllerStartTouchInteractableObject;
            component.ControllerTouchInteractableObject -= ControllerTouchInteractableObject;
            component.ControllerStartUntouchInteractableObject -= ControllerStartUntouchInteractableObject;
            component.ControllerUntouchInteractableObject -= ControllerUntouchInteractableObject;
            component.ControllerRigidbodyActivated -= ControllerRigidbodyActivated;
            component.ControllerRigidbodyDeactivated -= ControllerRigidbodyDeactivated;
        }

        void Cleartext()
        {
            GameObject.Find("阿毛").GetComponent<Text>().text = "";
            
        }
     


        private void Start()
        {
            Invoke("Cleartext", 2);
            
        }

        public Texture cat,cat2;
        public GameObject RawImg;

        

        private void ControllerStartTouchInteractableObject(object o, ObjectInteractEventArgs e)
        {
            OnControllerStartTouchInteractableObject.Invoke(o, e);
            print(e.target.name);
            if (e.target.name=="BlueCube")
            {
                
                e.target.transform.Translate(0, 0, 3);

                RawImg.SetActive(true);
                GameObject.Find("阿毛王國").GetComponent<Text>().text = "Q毛";
                GameObject.Find("MyRawImage").GetComponent<RawImage>().texture = cat;

            }
            else if (e.target.name=="door")
            {
                RawImg.SetActive(true);
                GameObject.Find("阿毛王國").GetComponent<Text>().text = "壞毛";
                GameObject.Find("MyRawImage").GetComponent<RawImage>().texture = cat2;
                GameObject.Find("door_pivot").GetComponent<Door>().OpenDoor();




            }
        }

        private void ControllerTouchInteractableObject(object o, ObjectInteractEventArgs e)
        {
            OnControllerTouchInteractableObject.Invoke(o, e);
        }

        private void ControllerStartUntouchInteractableObject(object o, ObjectInteractEventArgs e)
        {
            OnControllerStartUntouchInteractableObject.Invoke(o, e);
        }

        private void ControllerUntouchInteractableObject(object o, ObjectInteractEventArgs e)
        {
            OnControllerUntouchInteractableObject.Invoke(o, e);
        }

        private void ControllerRigidbodyActivated(object o, ObjectInteractEventArgs e)
        {
            OnControllerRigidbodyActivated.Invoke(o, e);
        }

        private void ControllerRigidbodyDeactivated(object o, ObjectInteractEventArgs e)
        {
            OnControllerRigidbodyDeactivated.Invoke(o, e);
        }
    }
}