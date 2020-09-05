using System;
using System.Collections.Generic;
using System.Text;

namespace MH.Builder
{
    public class BurgerBuilder
    {
        public int size;

        public bool cheese = false;
        public bool pepperoni = false;
        public bool lettuce = false;
        public bool tomato = false;

        public BurgerBuilder(int size)
        {
            this.size = size;
        }

        public BurgerBuilder AddPepperoni()
        {
            this.pepperoni = true;
            return this;
        }

        public BurgerBuilder AddLettuce()
        {
            this.lettuce = true;
            return this;
        }

        public BurgerBuilder AddCheese()
        {
            this.cheese = true;
            return this;
        }

        public BurgerBuilder AddTomato()
        {
            this.tomato = true;
            return this;
        }

        public Burger Build()
        {
            return new Burger(this);
        }
    }
}