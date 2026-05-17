namespace ConvertFiles
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            label1 = new Label();
            buttonSeleccionar = new Button();
            label2 = new Label();
            textBoxRuta = new TextBox();
            buttonExaminar = new Button();
            folderBrowserDialogRuta = new FolderBrowserDialog();
            openFileDialogArchivo = new OpenFileDialog();
            buttonConvertir = new Button();
            textBoxNombre = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(163, 21);
            label1.TabIndex = 0;
            label1.Text = "Selecciona un archivo:";
            // 
            // buttonSeleccionar
            // 
            buttonSeleccionar.Location = new Point(395, 32);
            buttonSeleccionar.Name = "buttonSeleccionar";
            buttonSeleccionar.Size = new Size(98, 29);
            buttonSeleccionar.TabIndex = 1;
            buttonSeleccionar.Text = "Seleccionar";
            buttonSeleccionar.UseVisualStyleBackColor = true;
            buttonSeleccionar.Click += buttonSeleccionar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 87);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 2;
            label2.Text = "Examinar ruta:";
            // 
            // textBoxRuta
            // 
            textBoxRuta.Location = new Point(137, 84);
            textBoxRuta.Name = "textBoxRuta";
            textBoxRuta.ReadOnly = true;
            textBoxRuta.Size = new Size(252, 29);
            textBoxRuta.TabIndex = 3;
            // 
            // buttonExaminar
            // 
            buttonExaminar.Location = new Point(395, 84);
            buttonExaminar.Name = "buttonExaminar";
            buttonExaminar.Size = new Size(98, 29);
            buttonExaminar.TabIndex = 4;
            buttonExaminar.Text = "Examinar";
            buttonExaminar.UseVisualStyleBackColor = true;
            buttonExaminar.Click += buttonExaminar_Click;
            // 
            // openFileDialogArchivo
            // 
            openFileDialogArchivo.FileName = "openFileDialog1";
            // 
            // buttonConvertir
            // 
            buttonConvertir.BackColor = Color.Brown;
            buttonConvertir.FlatStyle = FlatStyle.Flat;
            buttonConvertir.ForeColor = Color.White;
            buttonConvertir.Location = new Point(22, 137);
            buttonConvertir.Name = "buttonConvertir";
            buttonConvertir.Size = new Size(163, 29);
            buttonConvertir.TabIndex = 5;
            buttonConvertir.Text = "Convertir a PDF";
            buttonConvertir.UseVisualStyleBackColor = false;
            buttonConvertir.Click += buttonConvertir_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(185, 29);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.ReadOnly = true;
            textBoxNombre.Size = new Size(204, 29);
            textBoxNombre.TabIndex = 6;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(543, 186);
            Controls.Add(textBoxNombre);
            Controls.Add(buttonConvertir);
            Controls.Add(buttonExaminar);
            Controls.Add(textBoxRuta);
            Controls.Add(label2);
            Controls.Add(buttonSeleccionar);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConvertFiles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonSeleccionar;
        private Label label2;
        private TextBox textBoxRuta;
        private Button buttonExaminar;
        private FolderBrowserDialog folderBrowserDialogRuta;
        private OpenFileDialog openFileDialogArchivo;
        private Button buttonConvertir;
        private TextBox textBoxNombre;
    }
}
