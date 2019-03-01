﻿namespace virtual_receptionist.DataAccessLayer.Model
{
    /// <summary>
    /// Szoba egyed modell osztálya
    /// </summary>
    public class Room
    {
        #region Adattagok

        /// <summary>
        /// Szoba elnevezése
        /// </summary>
        private string name;

        /// <summary>
        /// Szobaszám
        /// </summary>
        private int number;

        /// <summary>
        /// Szobakategória
        /// </summary>
        private RoomCategory category;

        /// <summary>
        /// Szoba férőhelye
        /// </summary>
        private int capacity;

        #endregion

        #region Konstruktorok

        /// <summary>
        /// Room osztály konstruktora
        /// </summary>
        /// <param name="name">Szoba elnevezése</param>
        /// <param name="number">Szobaszám</param>
        /// <param name="category">Szobakategória</param>
        /// <param name="capacity">Szoba férőhelye</param>
        public Room(string name, int number, RoomCategory category, int capacity)
        {
            this.name = name;
            this.number = number;
            this.category = category;
            this.capacity = capacity;
        }

        /// <summary>
        /// Room osztály üres konstruktora
        /// </summary>
        public Room()
        {
        }

        #endregion

        #region Getter és setter tulajdonságok

        /// <summary>
        /// Szoba elnevezése
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Szobaszám
        /// </summary>
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        /// <summary>
        /// Szobakategória
        /// </summary>
        public RoomCategory Category
        {
            get { return category; }
            set { category = value; }
        }

        /// <summary>
        /// Szoba férőhelye
        /// </summary>
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Room osztályból készült objektum string típusúvá alakítása
        /// </summary>
        /// <returns>Visszaadja a Room típusú objektumot string típusúra alakítva</returns>
        public override string ToString()
        {
            return $"{name} {number} {category} {capacity}";
        }

        #endregion
    }
}