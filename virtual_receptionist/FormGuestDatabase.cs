﻿using System;
using System.Windows.Forms;
using virtual_receptionist.SupervisingController;

namespace virtual_receptionist.View
{
    /// <summary>
    /// Vendégadatbázis-kezelő ablak
    /// </summary>
    public partial class FormGuestDatabase : Form
    {
        #region Adattagok

        /// <summary>
        /// Prezenter osztály egy példánya
        /// </summary>
        private Presenter presenter;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Vendégadatbázis-kezelő ablak konstruktora, amely összeköti a főmenü ablakot a vendégadatbázis-kezelő ablakkal
        /// </summary>
        /// <param name="formMainMenu">Főmenü ablak egy példánya</param>
        public FormGuestDatabase()
        {
            InitializeComponent();
            presenter = new Presenter();
        }

        #endregion

        #region UI események

        private void FormGuestDatabase_Load(object sender, EventArgs e)
        {
            presenter.InitalizeGuestTable(listViewGuests);
        }

        private void listViewGuests_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            presenter.BanSettingColumnWidtChanging(e);
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            presenter.BackToMainMenu();
        }

        private void buttonAddGuest_Click(object sender, EventArgs e)
        {
            presenter.AddNewRecordInGuestTable(listViewGuests);
        }

        private void buttonUpdateGuest_Click(object sender, EventArgs e)
        {
            presenter.UpdateRecordInGuestTable(listViewGuests);
        }

        private void buttonDeleteGuest_Click(object sender, EventArgs e)
        {
            presenter.DeleteRecordInGuestTable(listViewGuests);
        }

        #endregion
    }
}
