using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoneyardClasses
{
    public class Boneyard
    {
        private List<Domino> listOfDominos = new List<Domino>();
        public int DominosRemaining
        {
            get
            {
                return listOfDominos.Count;
            }
        }
        public Domino this[int index]
        {
            get
            {
                return listOfDominos[index];
            }
            set
            {
                listOfDominos[index] = value;
            }
        }
        public void BoneYard(int maxDots)
        {
            listOfDominos.Clear();
            for (int i = 0; i <= maxDots; i++)
            {
                for (int j = i; j <= maxDots; j++)
                {
                    Domino domino = new Domino(i, j);
                    listOfDominos.Add(domino);
                }
            }
        }
        public bool IsEmpty()
        {
            if (listOfDominos.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Domino Draw()
        {
            if (listOfDominos.Count == 0)
            {
                return null;
            }
            else
            {
                Domino domino = listOfDominos[0];
                listOfDominos.RemoveAt(0);
                return domino;
            }
        }
        public void Shuffle()
        {
            Random gen = new Random();
            for (int i = 0; i < listOfDominos.Count; i++)
            {
                int rnd = gen.Next(0, listOfDominos.Count);
                Domino domino = listOfDominos[rnd];
                listOfDominos[rnd] = listOfDominos[i];
                listOfDominos[i] = domino;
            }
        }
        public override string ToString()
        {
            string output = "";
            foreach (Domino domino in listOfDominos)
            {
                output += domino.ToString() + "\n";
            }
            return output;
        }
    }
    public class Domino
    {
        public int LeftDot { get; set; }
        public int RightDot { get; set; }
        public Domino(int leftDot, int rightDot)
        {
            LeftDot = leftDot;
            RightDot = rightDot;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return (LeftDot + RightDot).ToString();
        }
    }
}
