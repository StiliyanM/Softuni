using System;
using System.Linq;

namespace P08PetClinics
{
    public class Clinic
    {
        private int roomsCount;

        private int currentIndex;

        public Clinic(string name, int roomsCount)
        {
            this.Name = name;
            this.RoomsCount = roomsCount;

            this.Pets = new Pet[roomsCount];

            currentIndex =  roomsCount / 2;
        }
        public string Name { get; set; }

        public Pet[] Pets { get; set; }

        public int RoomsCount
        {
            get { return roomsCount; }
            set
            {
                if(value % 2 == 0)
                {
                    throw new InvalidOperationException("Invalid Operation!");

                }
                roomsCount = value;
            }
        }

        public bool AddPet(Pet pet)
        {
            var counter = 0;

            while (counter <= (this.Pets.Length - 1) / 2)
            {
                if(this.Pets[currentIndex - counter] == null)
                {
                    this.Pets[currentIndex - counter] = pet;
                    return true;
                }

                var maxIndex = Math.Min(currentIndex + counter, this.Pets.Length - 1);
                if (this.Pets[maxIndex] == null)
                {
                    this.Pets[maxIndex] = pet;
                    return true;
                }

                counter++;
            }

            return false;
        }

        public bool ReleasePet()
        {
            for (int i = currentIndex; i < this.Pets.Length; i++)
            {
                if(this.Pets[i] != null)
                {
                    this.Pets[i] = null;
                    return true;
                }
            }

            for (int i = 0; i < currentIndex; i++)
            {
                if (this.Pets[i] != null)
                {
                    this.Pets[i] = null;
                    return true;
                }
            }

            return false;
        }

        public bool HasEmptyRooms()
        {
            return this.Pets.Any(p => p == null);
        }

        public void Print()
        {
            for (int i = 1; i <= this.RoomsCount; i++)
            {
                Print(i);
            }
        }

        public void Print(int roomNumber)
        {
            roomNumber--;
            if (this.Pets[roomNumber] == null)
            {
                Console.WriteLine("Room empty");
            }
            else
            {
                Console.WriteLine(this.Pets[roomNumber]);
            }
        }
    }
}
