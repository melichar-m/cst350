﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ButtonGrid.Models
{
    public class ButtonModel
    {
        public int Id { get; set; }
        public int ButtonState { get; set; }

        public ButtonModel()
        {

        }
        public ButtonModel(int id, int buttonState)
        {
            Id = id;
            ButtonState = buttonState;
        }
    }
}