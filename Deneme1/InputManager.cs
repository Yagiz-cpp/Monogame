using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme1
{
    internal class InputManager
    {
        public Dictionary<Keys, Input> keyBindingKeyboard;
        public Dictionary<Buttons, Input> keyBingingGamepad;

        private bool isUsingKeyboard;

        private int playerInput;
        public InputManager(bool pIsUsingKeyboard)
        {
            isUsingKeyboard = pIsUsingKeyboard;

            keyBindingKeyboard = new Dictionary<Keys, Input>
            {
                { Keys.W, Input.Up },
                { Keys.A, Input.Left },
                { Keys.S, Input.Down },
                { Keys.D, Input.Right },
                { Keys.Escape, Input.Back }
            };
        }

        public void Update(PlayerIndex pPlayer = PlayerIndex.One) 
        {
            if (isUsingKeyboard)
            {
                Keys[] pressedKeys = Keyboard.GetState(pPlayer).GetPressedKeys();
                foreach (Keys keys in pressedKeys)
                {
                    if (keyBindingKeyboard.ContainsKey(key))
                    { 
                        
                    }


                }
            } else
            {

            }
    }
}
