﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player : INotifyPropertyChanged
    {
        private string _name;
        private string _class;
        private int _hitPoints;
        private int _gold;
        private int _level;
        private int _experiencePoints;
        public string Name { get { return _name; } set { _name = value; OnPropertyChanged("Name"); } }
        public string CharacterClass { get { return _class; } set { _class = value; OnPropertyChanged("Class"); } }
        public int HitPoints { get { return _hitPoints; } set { _hitPoints = value; OnPropertyChanged("HitPoints"); } }
        public int Gold { get { return _gold; } set { _gold = value; OnPropertyChanged("Gold"); } }
        public int Level { get { return _level; } set { _level = value; OnPropertyChanged("Level"); } }
        public int ExperiencePoints { get { return _experiencePoints; } set { _experiencePoints = value; OnPropertyChanged("ExperiencePoints"); } }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
        //public Player(string name, string characterClass, int hitPoints, int gold, int level, int experiencePoints)
        //{
        //    Name = name;
        //    CharacterClass = characterClass;
        //    HitPoints = hitPoints;
        //    Gold = gold;
        //    Level = level;
        //    ExperiencePoints = experiencePoints;
        //}
        
    }
}
