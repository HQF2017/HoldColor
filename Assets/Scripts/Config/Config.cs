﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace HoldColor.Config {
    static class GameConfig {
        public static int _ScreenWidth = 1920;
        public static int _ScreenHeight = 1080;
        public static bool _FullScreen = false;
        
    }
    static class CampDefine
    {
        public static Color Orange = new Color(255f / 255f, 183f / 255f, 77f / 255f);
        public static Color Blue = new Color(79f / 255f, 195f / 255f, 247f / 255f);
        public static Color Green = new Color(129f / 255f, 199f / 255f, 132f / 255f);
        public static Color Purple = new Color(149f / 255f, 177f / 255f, 205f / 255f);
    }
    static class CameraConfig {
        public static float _MoveSpeed = 0.1f;
    }
    static class PlayerConfig
    {
        public static float _MoveSpeed = 0.5f;
        public static float _FiringRate = 1.0f;
        public static int _Damage = 5;
        public static float _BulletSpeed = 3.0f;
        public static float _InteractAreaRadius = 5.0f;
        public static int _TotalHealth = 300;
        public static int _TotalEnergy = 100;
    }

    static class HingeConfig
    {
        public static int _AddResourceByCycle = 4;
        public static float _AddResourceCycle = 2.0f;
        public static int _AddHealthBySecond = 10;
        public static float _InteractAreaRadius = 10.0f;
        public static int _TotalHealth = 3000;
        public static int _TotalEnergy = 1000;
    }

    static class ReserveConfig
    {
        public static int _AddEnergyByCycle = 10;
        public static float _AddEnergyCycle = 1.0f;
        public static float _InteractAreaRadius = 10.0f;
        public static int _TotalHealth = 500;
        public static int _TotalEnergy = 1000;
    }

    static class TurretConfig
    {
        public static float _FiringRate = 1.5f;
        public static int _Damage = 100;
        public static float _BulletSpeed = 3.0f;
        public static int _TotalHealth = 1000;
        public static int _TotalEnergy = 1000;
        public static float _InteractAreaRadius = 15f;
    }
}
