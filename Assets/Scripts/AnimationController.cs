using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Foundry
{
    public class AnimationController : MonoBehaviour
    {

        public Animator anim;
        public Toggle myToggle;

        

        private void onTrigger(){
            Debug.Log("entering void");
            if(myToggle.isOn){
                Debug.Log("entering yes bool");
                anim.SetBool("YesSpinBool",true);
            }
            else
            {
                Debug.Log("entering no bool");
                anim.SetBool("YesSpinBool", false);
            }
        }

        // Start is called before the first frame update
        void Start()
        {
            anim = GetComponent<Animator>();

        }

        // Update is called once per frame
        void Update()
        {
            onTrigger();
        
        }
    }
}
