﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using HoloToolkit.Unity;
using UnityEngine;

namespace Academy
{
    public class ScreensManager : Singleton<AstronautManager>
    {
        private float expandAnimationCompletionTime;

        public GameObject screen1;
        public GameObject screen2;
        public GameObject screen3;
        public GameObject screen4;
        public GameObject screen5;
        public GameObject screen6;
        public GameObject screen7;
        public GameObject screen8;
        public GameObject screen9;
        public GameObject screen10;
        public GameObject screen11;
        public GameObject screen12;
        public GameObject screen13;
        public GameObject screen14;
        public GameObject screen15;


        public GameObject[] TextSizeVariations;
        public GameObject[] FontVariations;
        public GameObject[] DistanceVariations;

        public GameObject[] IVATasks;
        public GameObject[] TranslationTasks;
        public GameObject[] EVATasks;

        
        //public GameObject[] 
        // Store a bool for whether our astronaut model is expanded or not.
        private bool isModelExpanding = false;

        private void Update()
        {

            if (Input.GetKeyDown(KeyCode.LeftBracket))
            {
                Debug.Log("Previous Task Button Pressed");
            }

            if (Input.GetKeyDown(KeyCode.RightBracket))
            {
                Debug.Log("Next Task Button Pressed");
            } 


            if (isModelExpanding && Time.realtimeSinceStartup >= expandAnimationCompletionTime)
            {
                isModelExpanding = false;

                Animator[] expandedAnimators = ExpandModel.Instance.ExpandedModel.GetComponentsInChildren<Animator>();
                foreach (Animator animator in expandedAnimators)
                {
                    animator.enabled = false;
                }
            }


        }
        public void NextTaskCommand()
        {
            Debug.Log("NEXT TASK COMMAND ACTIVATED");
            for(int i = 0; i<=TextSizeVariations.Length; i++){
                if(TextSizeVariations[i].activeSelf.Equals(true)){
                    TextSizeVariations[i].gameObject.SetActive(false);
                    TextSizeVariations[i+1].gameObject.SetActive(true);
                    break;
                }
            }
            for(int i = 0; i<=FontVariations.Length; i++){
                if(FontVariations[i].activeSelf.Equals(true)){
                    FontVariations[i].gameObject.SetActive(false);
                    FontVariations[i+1].gameObject.SetActive(true);
                    break;
                }
            }

        }

        public void PreviousTaskCommand()
        {
            Debug.Log("PREVIOUS TASK COMMAND ACTIVATED");
            for(int i = 0; i<=TextSizeVariations.Length; i++){
                if(TextSizeVariations[i].activeSelf.Equals(true)){
                    TextSizeVariations[i].gameObject.SetActive(false);
                    TextSizeVariations[i-1].gameObject.SetActive(true);
                    break;
                }
            }
            for(int i = 0; i<=FontVariations.Length; i++){
                if(FontVariations[i].activeSelf.Equals(true)){
                    FontVariations[i].gameObject.SetActive(false);
                    FontVariations[i-1].gameObject.SetActive(true);
                    break;
                }
            }

        }

        public void ShowStatusCommand()
        {
           screen9.gameObject.SetActive(true);
            
        }
        public void HideStatusCommand()
        {
            if(screen9.gameObject.activeSelf.Equals(true)){
           screen9.gameObject.SetActive(false);
            }
        }
        public void hideCommand()
        {
            if(screen2.gameObject.activeSelf.Equals(true)){
           screen2.gameObject.SetActive(false);
           screen3.gameObject.SetActive(true);
            }
        }

        public void IVACommand()
        {
            if(screen5.gameObject.activeSelf.Equals(true)){
           screen5.gameObject.SetActive(false);
           screen6.gameObject.SetActive(true);
            }
        }
        public void TranslationCommand()
        {
            if(screen5.gameObject.activeSelf.Equals(true)){
           screen5.gameObject.SetActive(false);
           screen7.gameObject.SetActive(true);
            }
        }
        public void EVACommand()
        {
            if(screen5.gameObject.activeSelf.Equals(true)){
           screen5.gameObject.SetActive(false);
           screen8.gameObject.SetActive(true);
            }
        }

        public void showCommand()
        {
            if(screen2.gameObject.activeSelf.Equals(true)){
           screen2.gameObject.SetActive(false);
           screen3.gameObject.SetActive(true);
            }
        }

        public void WindowCommand()
        {
            if(screen3.gameObject.activeSelf.Equals(true)){
           screen3.gameObject.SetActive(false);
           screen4.gameObject.SetActive(true);
            }
        }

        public void ChecklistCommand()
        {
            if(screen4.gameObject.activeSelf.Equals(true)){
            screen4.gameObject.SetActive(false);
            screen5.gameObject.SetActive(true);
            }
        }



        public void HeyScoutCommand()
        {
            if(screen1.gameObject.activeSelf.Equals(true)){
            screen1.gameObject.SetActive(false);
            screen2.gameObject.SetActive(true);
            }
           
           
            // Swap out the current model for the expanded model.
          /* GameObject currentModel = ExpandModel.Instance.gameObject;
            GameObject expandedModel = ExpandModel.Instance.ExpandedModel;

            expandedModel.transform.position = currentModel.transform.position;
            expandedModel.transform.rotation = currentModel.transform.rotation;
            expandedModel.transform.localScale = currentModel.transform.localScale;

            currentModel.SetActive(false);
            expandedModel.SetActive(true);

            // Play animation.  Ensure the Loop Time check box is disabled in the inspector for this animation to play it once.
            Animator[] expandedAnimators = expandedModel.GetComponentsInChildren<Animator>();
            // Set local variables for disabling the animation.
            if (expandedAnimators.Length > 0)
            {
                expandAnimationCompletionTime = Time.realtimeSinceStartup + expandedAnimators[0].runtimeAnimatorController.animationClips[0].length * 0.9f;
            }

            // Set the expand model flag.
            isModelExpanding = true;

            ExpandModel.Instance.Expand();*/
        }
    }
}