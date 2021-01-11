﻿using System;
using System.Collections.Generic;

using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Bags;
using SpaceStation.Utilities.Messages;

namespace SpaceStation.Models.Astronauts
{
    public abstract class Astronaut : IAstronaut
    {
        private const double AstronautOxygentDecreasment = 10;
        
        private string name;
        private double oxygen;
        private readonly Backpack bag;

        public Astronaut(string name, double oxygen)
        {
            this.Name = name;
            this.Oxygen = oxygen;
            this.bag = new Backpack();
        }

        public string Name
        {
            get { return this.name; }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(ExceptionMessages.InvalidAstronautName);
                }

                this.name = value;
            }
        }

        public double Oxygen
        {
            get { return this.oxygen; }

            protected set
            {
                if(value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidOxygen);
                }
                
                this.oxygen = value;
            }
        }

        public bool CanBreath
        {
            get
            {
                return this.Oxygen > 0;
            }
        }

        public IBag Bag => this.bag;

        public virtual void Breath()
        {
            this.Oxygen -= AstronautOxygentDecreasment;

            if(this.Oxygen < 0)
            {
                this.Oxygen = 0;
            }
        }
    }
}
