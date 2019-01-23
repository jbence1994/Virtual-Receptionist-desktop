﻿using System;
using System.Windows.Forms;
using virtual_receptionist.Presenter;

namespace virtual_receptionist.View
{
    /// <summary>
    /// Számlázó modul tételek felvételéhez szükséges modális ablak
    /// </summary>
    public partial class FormModalBillingItems : Form
    {
        #region Adattagok

        /// <summary>
        /// Számlázó modul tételek felvételéhez szükséges modális ablak prezenter egy példánya
        /// </summary>
        private ModalBillingItemsPresenter presenter;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Számlázó modul tételek felvételét vagy módosításához szükséges modális ablak konstruktora
        /// </summary>
        public FormModalBillingItems()
        {
            InitializeComponent();
            presenter = new ModalBillingItemsPresenter(listViewBillingItems);
        }

        #endregion

        #region UI események

        private void FormModalBillingItems_Load(object sender, EventArgs e)
        {
            presenter.InitializeBillingItemsListView();
        }

        private void listViewBillingItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.SetControlsWithData(textBoxQuantity, maskedTextBoxItemDiscount, buttonAdd, textBoxItem,
                textBoxPrice, maskedTextBoxVAT, textBoxUnit);
        }

        private void listViewBillingItems_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            presenter.BlockSettingColumnWidth(e, 160);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxItemDiscount.MaskFull)
            {

            }
        }

        #endregion
    }
}
