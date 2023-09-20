namespace SannaFer.CAI.EJ._01
{
    partial class DatosForm
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
            label1 = new Label();
            DocumentoText = new TextBox();
            NombreText = new TextBox();
            label2 = new Label();
            ApellidoText = new TextBox();
            label3 = new Label();
            FechaText = new TextBox();
            label4 = new Label();
            AceptarBtn = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 42);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Decumento";
            // 
            // DocumentoText
            // 
            DocumentoText.Location = new Point(57, 65);
            DocumentoText.Name = "DocumentoText";
            DocumentoText.Size = new Size(194, 27);
            DocumentoText.TabIndex = 1;
            DocumentoText.TextChanged += DocText_TextChanged;
            // 
            // NombreText
            // 
            NombreText.Location = new Point(57, 132);
            NombreText.Name = "NombreText";
            NombreText.Size = new Size(194, 27);
            NombreText.TabIndex = 3;
            NombreText.TextChanged += NombreText_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 109);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // ApellidoText
            // 
            ApellidoText.Location = new Point(57, 193);
            ApellidoText.Name = "ApellidoText";
            ApellidoText.Size = new Size(194, 27);
            ApellidoText.TabIndex = 5;
            ApellidoText.TextChanged += ApellidoText_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 170);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            // 
            // FechaText
            // 
            FechaText.Location = new Point(57, 259);
            FechaText.Name = "FechaText";
            FechaText.Size = new Size(194, 27);
            FechaText.TabIndex = 7;
            FechaText.TextChanged += FechaText_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 236);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 6;
            label4.Text = "Fecha Nacimiento";
            // 
            // AceptarBtn
            // 
            AceptarBtn.Location = new Point(57, 325);
            AceptarBtn.Name = "AceptarBtn";
            AceptarBtn.Size = new Size(94, 29);
            AceptarBtn.TabIndex = 8;
            AceptarBtn.Text = "Aceptar";
            AceptarBtn.UseVisualStyleBackColor = true;
            AceptarBtn.Click += AceptarBtn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(157, 325);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DatosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 433);
            Controls.Add(button2);
            Controls.Add(AceptarBtn);
            Controls.Add(FechaText);
            Controls.Add(label4);
            Controls.Add(ApellidoText);
            Controls.Add(label3);
            Controls.Add(NombreText);
            Controls.Add(label2);
            Controls.Add(DocumentoText);
            Controls.Add(label1);
            Name = "DatosForm";
            Text = "Datos Personales";
            Load += DatosForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox DocumentoText;
        private TextBox NombreText;
        private Label label2;
        private TextBox ApellidoText;
        private Label label3;
        private TextBox FechaText;
        private Label label4;
        private Button AceptarBtn;
        private Button button2;
    }
}