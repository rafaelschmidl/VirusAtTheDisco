using System;
using System.Collections.Generic;
using System.Text;

namespace VirusAtTheDisco
{
    class InfectionAtDisco
    {
        public List<Person> PersonsAtDisco { get; set; }
        public int AllPersonsInfected { get; set; }

        public InfectionAtDisco(int personsAtDisco)
        {
            PersonsAtDisco = new List<Person>();
            PopulateDisco(personsAtDisco);
            AllPersonsInfected = 0;
            FirstHour();
        }

        private void PopulateDisco(int personsAtDisco)
        {
            for (int i = 0; i < personsAtDisco; i++)
            {
                PersonsAtDisco.Add(new Person());
            }
        }

        private void FirstHour()
        {
            PersonsAtDisco[0].IsInfected = true;
            AllPersonsInfected++;
        }

        public void NextHour()
        {
            int personsBeingInfected = 0;

            foreach (Person person in PersonsAtDisco)
            {
                if (person.IsInfected)
                {
                    person.TimeSinceInfection++;
                    personsBeingInfected++;
                    if (person.TimeSinceInfection == person.TimePersonIsContagious)
                    {
                        MakePersonImune(person);
                    }
                }
            }

            InfectPersons(personsBeingInfected);
        }

        private void MakePersonImune(Person person)
        {
            person.IsImune = true;
            person.IsInfected = false;
            AllPersonsInfected--;
        }

        private void InfectPersons(int personsBeingInfected)
        {
            int infected = 0;

            foreach (Person person in PersonsAtDisco)
            {
                if (AllPersonsInfected >= PersonsAtDisco.Count)
                {
                    Console.WriteLine("All persons are infected...");
                    break;
                }
                else if (infected == personsBeingInfected)
                {
                    break;
                }
                else if (!person.IsImune && !person.IsInfected)
                {
                    person.IsInfected = true;
                    infected++;
                    AllPersonsInfected++;
                }
            }
        }
    }
}