/* Inicio de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 30/07/2026 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Componentes
{
    public class CustomFilePicker : Button
    {
        private string _filePath = "";

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FilePath
        {
            get => _filePath;
            set
            {
                _filePath = value ?? "";
                Text = string.IsNullOrEmpty(_filePath)
                    ? "Seleccionar imagen..."
                    : Path.GetFileName(_filePath);
                ForeColor = string.IsNullOrEmpty(_filePath)
                    ? Color.FromArgb(160, 165, 175)
                    : Color.FromArgb(230, 230, 230);
            }
        }

        [DefaultValue("Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif")]
        public string Filter { get; set; } = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

        public event EventHandler FileSelected;

        public CustomFilePicker()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderColor = Color.White;
            FlatAppearance.BorderSize = 0;
            TextAlign = ContentAlignment.MiddleLeft;
            Font = new Font("Segoe UI", 8.5f);
            BackColor = Color.FromArgb(55, 60, 72);
            ForeColor = Color.FromArgb(160, 165, 175);
            Padding = new Padding(8, 0, 0, 0);
            Margin = new Padding(5);
            Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Cursor = Cursors.Hand;
            UseVisualStyleBackColor = false;
            MinimumSize = new Size(190, 30);
            MaximumSize = new Size(0, 30);
            Text = "Seleccionar imagen...";
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = Filter;
                dialog.Title = "Seleccionar imagen";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    FilePath = dialog.FileName;
                    FileSelected?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}
/* Fin de Codigo de Diego Fernando Santizo Samayoa con carnet: 0901-22-15950 en la
 * fecha de: 31/07/2026 */