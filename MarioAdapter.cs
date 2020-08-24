﻿using System;
namespace codewars_solutions
{
    //This sample shows an implementation of Adaptor design pattern
    public class Target
    {
        public int Health { get; set; }
    }
    public interface IUnit
    {
        void Attack(Target target);
    }

    public class Marine : IUnit
    {
        public void Attack(Target target)
        {
            target.Health -= 6;
        }
    }

    public class Zealot : IUnit
    {
        public void Attack(Target target)
        {
            target.Health -= 8;
        }
    }

    public class Zergling : IUnit
    {
        public void Attack(Target target)
        {
            target.Health -= 5;
        }
    }

    public class Mario
    {
        public int jumpAttack()
        {
            Console.WriteLine("Mamamia!");
            return 3;
        }
    }

    public class MarioAdapter : IUnit
    {
        private Mario _mario;

        public MarioAdapter(Mario Mario)
        {
            _mario = Mario;
        }

        public void Attack(Target Target)
        {
            Target.Health -= _mario.jumpAttack();
        }
    }
}
