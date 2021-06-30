using System;
using System.Collections.Generic;
using System.Text;

namespace Catacombs_Of_Class
{
    class Door
    {
        public DoorState State { get; private set; }

        private uint _passcode;

        public Door(uint passcode)
        {
            State = DoorState.ClosedLocked;
            _passcode = passcode;
        }

        public void ChangePasscode(uint passcode, uint newPasscode)
        {
            if (passcode == _passcode)
            {
                _passcode = newPasscode;
            }
        }

        public void Unlock(uint passcode)
        {
            if (passcode == _passcode && State == DoorState.ClosedLocked)
            {
                State = DoorState.ClosedUnlocked;
            }
        }

        public void Open()
        {
            if (State == DoorState.ClosedUnlocked)
            {
                State = DoorState.Open;
            }
        }

        public void Close()
        {
            if (State == DoorState.Open)
            {
                State = DoorState.ClosedUnlocked;
            }
        }

        public void Lock(uint passcode)
        {
            if (passcode == _passcode && State == DoorState.ClosedUnlocked)
            {
                State = DoorState.ClosedLocked;
            }
        }
    }

    enum DoorState
    {
        Unknown,
        Open,
        ClosedUnlocked,
        ClosedLocked
    }
}
