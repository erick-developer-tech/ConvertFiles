using Spire.Doc;
namespace ConvertFiles
{
    public partial class FrmPrincipal : Form
    {
        // Variables globales para guardar las rutas dentro de la clase
        private string rutaDocx = string.Empty;
        private string rutaDestino = string.Empty;
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        // Método para limpiar las rutas y los TextBox después de la conversión
        private void Limpiar()
        {
            textBoxNombre.Clear();
            textBoxRuta.Clear();
            rutaDocx = string.Empty;
            rutaDestino = string.Empty;
        }
        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            // Configuramos el filtro para que solo busque archivos de Word
            openFileDialogArchivo.Filter = "Documentos Word (*.docx)|*.docx";
            openFileDialogArchivo.Title = "Selecciona el archivo DOCX a convertir";
            // Mostramos el diálogo para seleccionar el archivo
            if (openFileDialogArchivo.ShowDialog() == DialogResult.OK)
            {
                rutaDocx = openFileDialogArchivo.FileName;
                textBoxNombre.Text = Path.GetFileName(rutaDocx);
            }
        }

        private void buttonExaminar_Click(object sender, EventArgs e)
        {
            folderBrowserDialogRuta.Description = "Selecciona la carpeta donde se guardará el PDF";

            // Mostramos el diálogo para seleccionar la carpeta
            if (folderBrowserDialogRuta.ShowDialog() == DialogResult.OK)
            {
                // Guardamos la ruta seleccionada en la variable global
                rutaDestino = folderBrowserDialogRuta.SelectedPath;
                // Mostramos la ruta seleccionada en tu TextBox
                textBoxRuta.Text = rutaDestino;
            }
        }

        private async void buttonConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                // Validamos que el usuario haya seleccionado tanto el archivo DOCX como la carpeta de destino
                if (string.IsNullOrEmpty(rutaDocx) || string.IsNullOrEmpty(rutaDestino))
                {
                    MessageBox.Show("Por favor, selecciona un archivo DOCX y una carpeta de destino antes de convertir.", 
                        "Información Incompleta", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // Construimos la ruta final del PDF usando el mismo nombre que el DOCX pero con extensión .pdf
                string nombreSinExtension = Path.GetFileNameWithoutExtension(rutaDocx);
                // Aseguramos que la ruta final del PDF sea correcta
                string rutaFinalPdf = Path.Combine(rutaDestino, nombreSinExtension + ".pdf");

                Progreso progreso = new Progreso();
                progreso.Show();
                this.Enabled = false;

                // Realizamos la conversión en un hilo separado para no bloquear la interfaz
                await Task.Run(() =>
                {
                    Document doc = new Document();
                    doc.LoadFromFile(rutaDocx);
                    doc.SaveToFile(rutaFinalPdf, FileFormat.PDF);
                });

                progreso.Close();
                this.Enabled = true;
                Limpiar(); //Limpia las rutas al terminar
                this.BringToFront();

                // Mensaje de confirmación
                MessageBox.Show("¡Archivo convertido a PDF con éxito!", "Proceso Terminado", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                this.Enabled = true; // Aseguramos reactivar la app si falla
                MessageBox.Show($"Hubo un problema al convertir el archivo: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
