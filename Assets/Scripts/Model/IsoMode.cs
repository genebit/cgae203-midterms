﻿using Mechanics;
using UnityEngine;

namespace Model
{
    [System.Serializable]
    public class IsoModel
    {
        public Cinemachine.CinemachineVirtualCamera virtualCamera;

        public PlayerController player;

        public InventoryController inventory;

        public TamedCatsController tamedCats;

        public ActionPromptController playerActionPrompt;

        public GameplayTimer timer;

        public GameObject hudCanvas;

    }
}