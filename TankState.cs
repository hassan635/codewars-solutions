using System;
namespace codewars_solutions
{
    public interface ITankUnit
    {
        ITankUnitState State { get; set; }
        bool CanMove { get; }
        int Damage { get; }
    }

    public interface ITankUnitState
    {
        bool CanMove { get; set; }
        int Damage { get; set; }
    }

    public class SiegeState : ITankUnitState
    {
        public SiegeState()
        {
            CanMove = false;
            Damage = 20;
        }

        public bool CanMove { get; set; }
        public int Damage { get; set; }
    }

    public class TankState : ITankUnitState
    {
        public TankState()
        {
            CanMove = true;
            Damage = 5;
        }

        public bool CanMove { get; set; }
        public int Damage { get; set; }
    }

    public class Tank : ITankUnit
    {
        public Tank()
        {
            State = new TankState();
        }

        public ITankUnitState State { get; set; }

        public bool CanMove
        {
            get { return State.CanMove; }
        }
        public int Damage
        {
            get { return State.Damage; }
        }
    }
}
