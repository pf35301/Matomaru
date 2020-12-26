﻿using System.Collections.Generic;
using UnityEngine;

namespace Matomaru.Main {

    [CreateAssetMenu(menuName = "ScriptableObject/PixelCanvasData")]
    public class PixelCanvasData : ScriptableObject, IPixelCanvas {
        public List<PixelCanvasListWrapper> Canvas { get; set; }
    }
}