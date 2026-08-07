/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 30/07/2026 */
using Forms_Admin;
using Forms_Admin.Funciones;
using Forms_Admin.Funciones.Catalogs;
using Formularios_Admin;
using Plantilla_Admin.Tabs;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Plantilla_Admin
{
    public partial class FrUcMainFunciones : UserControl
    {
        private Button _activeButton = null;

        private static readonly Color IdleBack = Color.Black;
        private static readonly Color HoverBack = Color.FromArgb(120, 30, 34);
        private static readonly Color ActiveBack = Color.FromArgb(178, 44, 48);
        private static readonly Color IdleFore = Color.FromArgb(220, 210, 210);

        public FrUcMainFunciones()
        {
            InitializeComponent();
            WireNavButtons();

            BtnPeliculas.PerformClick();
        }

        private void WireNavButtons()
        {
            Button[] navButtons = { BtnPeliculas, BtnFunciones, BtnPromocion, BtnSalas, BtnCartelera};

            foreach (Button b in navButtons)
            {
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.BackColor = IdleBack;
                b.ForeColor = IdleFore;
                //b.FlatAppearance.MouseOverBackColor = Color.Transparent;

                b.MouseEnter += NavButton_MouseEnter;
                b.MouseLeave += NavButton_MouseLeave;
            }

            BtnPeliculas.Click += (s, e) => Navegar(BtnPeliculas, new FrUcPeliculas());
            BtnFunciones.Click += (s, e) => Navegar(BtnFunciones, new FrUcFunciones());
            BtnPromocion.Click += (s, e) => Navegar(BtnPromocion, new FrUcPromociones());
            BtnSalas.Click += (s, e) => Navegar(BtnSalas, new FrUcSalas());
            BtnCartelera.Click += (s, e) => Navegar(BtnCartelera, new FrUcCartelera());

            CbCatalog.SelectedIndexChanged += CbCatalog_SelectedIndexChanged;
        }

        private void Navegar(Button btn, UserControl pagina)
        {
            SetActive(btn);
            ResetCombo();
            funcargarpagina(pagina);
        }

        private void SetActive(Button btn)
        {
            if (_activeButton != null)
            {
                _activeButton.BackColor = IdleBack;
                _activeButton.ForeColor = IdleFore;
            }

            _activeButton = btn;
            btn.BackColor = ActiveBack;
            btn.ForeColor = Color.White;
        }

        private void ResetActiveButton()
        {
            if (_activeButton != null)
            {
                _activeButton.BackColor = IdleBack;
                _activeButton.ForeColor = IdleFore;
                _activeButton = null;
            }
        }

        private void HighlightCombo()
        {
            CbCatalog.StateCommon.ComboBox.Back.Color1 = ActiveBack;
            CbCatalog.StateCommon.ComboBox.Content.Color1 = Color.White;
        }

        private void ResetCombo()
        {
            CbCatalog.StateCommon.ComboBox.Back.Color1 = IdleBack;
            CbCatalog.StateCommon.ComboBox.Content.Color1 = IdleFore;
        }

        private void NavButton_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn && btn != _activeButton)
            {
                btn.BackColor = ActiveBack;
                btn.ForeColor = Color.White;
            }
        }

        private void NavButton_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn && btn != _activeButton)
            {
                btn.BackColor = IdleBack;
                btn.ForeColor = IdleFore;
            }
        }

        private void CbCatalog_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetActiveButton();
            HighlightCombo();

            switch (CbCatalog.SelectedItem?.ToString())
            {
                case "Cines":
                    funcargarpagina(new FrUcCines());
                    break;
                case "Ciudades":
                    funcargarpagina(new FrUcCiudades());
                    break;
                case "Clasificaciones":
                    funcargarpagina(new FrUcClasificaciones());
                    break;
                case "Estados De Película":
                    funcargarpagina(new FrUcEstadosDePelicula());
                    break;
                case "Formatos De Película":
                    funcargarpagina(new FrUcFormatosDePelicula());
                    break;
                case "Generos":
                    funcargarpagina(new FrUcGeneros());
                    break;
                case "Tipos De Sala":
                    funcargarpagina(new FrUcTiposDeSala());
                    break;
                default:
                    break;
            }
        }

        private void funcargarpagina(UserControl pagina)
        {
            foreach (Control c in PnlMain.Controls) c.Dispose();
            PnlMain.Controls.Clear();
            pagina.Dock = DockStyle.Fill;
            PnlMain.Controls.Add(pagina);
        }

        private void BtnCartelera_Click(object sender, EventArgs e)
        {

        }
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 03/08/2026 */