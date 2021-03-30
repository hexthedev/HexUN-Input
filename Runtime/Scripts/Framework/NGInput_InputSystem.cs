using HexCS.Core;

using HexUN.Behaviour;
using HexUN.Framework;
using HexUN.Framework.Input;

using System.Collections.Generic;

using UnityEngine;
using UnityEngine.InputSystem;

namespace HexUN.Input
{
    public class NGInput_InputSystem : ANGHexPersistent<NGInput_InputSystem>, IInput
    {
        private const string cLogCategory = nameof(NGInput_InputSystem);

        private Dictionary<string, Key> _map = new Dictionary<string, Key>();

        public void Awake()
        {
            foreach(Key k in UTEnum.GetEnumAsArray<Key>())
            {
                _map[k.ToString()] = k;
            }
        }

        public bool GetKeyDown(KeyCode key)
        {
            if(_map.TryGetValue(key.ToString(), out Key trueKey))
            {
                return Keyboard.current[trueKey].isPressed;
            }

            NGHexServices.Instance.Log.Warn(cLogCategory,  $"Could not translate unity {key} to InputSystem key" );

            return false;
        }
    }
}