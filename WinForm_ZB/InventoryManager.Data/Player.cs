﻿using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace InventoryManager.Data
{
    public class Player : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Score { get; set; }
        public List<Item> Inventory { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
