namespace Pseudo_ParcialForms1
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            Cancelar = new Button();
            OK = new Button();
            radio = new TextBox();
            altura = new TextBox();
            generatriz = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label5 = new Label();
            ResultA = new TextBox();
            ResultV = new TextBox();
            label4 = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Cancelar);
            panel1.Controls.Add(OK);
            panel1.Controls.Add(radio);
            panel1.Controls.Add(altura);
            panel1.Controls.Add(generatriz);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(994, 100);
            panel1.TabIndex = 0;
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(648, 10);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(75, 49);
            Cancelar.TabIndex = 7;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            OK.Location = new Point(567, 10);
            OK.Name = "OK";
            OK.Size = new Size(75, 49);
            OK.TabIndex = 6;
            OK.Text = "OK";
            OK.UseVisualStyleBackColor = true;
            OK.Click += OK_Click;
            // 
            // radio
            // 
            radio.Location = new Point(446, 63);
            radio.Name = "radio";
            radio.Size = new Size(100, 23);
            radio.TabIndex = 5;
            // 
            // altura
            // 
            altura.Location = new Point(446, 36);
            altura.Name = "altura";
            altura.Size = new Size(100, 23);
            altura.TabIndex = 4;
            // 
            // generatriz
            // 
            generatriz.Location = new Point(446, 10);
            generatriz.Name = "generatriz";
            generatriz.Size = new Size(100, 23);
            generatriz.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(201, 63);
            label3.Name = "label3";
            label3.Size = new Size(187, 21);
            label3.TabIndex = 2;
            label3.Text = "Ingrese el valor rel radio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(201, 36);
            label2.Name = "label2";
            label2.Size = new Size(206, 21);
            label2.TabIndex = 1;
            label2.Text = "Ingrese el valor de la altura";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(201, 12);
            label1.Name = "label1";
            label1.Size = new Size(239, 21);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el valor de la generatriz";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(994, 403);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(ResultA);
            panel3.Controls.Add(ResultV);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(994, 403);
            panel3.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(401, 89);
            label5.Name = "label5";
            label5.Size = new Size(44, 21);
            label5.TabIndex = 3;
            label5.Text = "Area";
            // 
            // ResultA
            // 
            ResultA.Enabled = false;
            ResultA.Location = new Point(374, 113);
            ResultA.Name = "ResultA";
            ResultA.Size = new Size(100, 23);
            ResultA.TabIndex = 2;
            // 
            // ResultV
            // 
            ResultV.Enabled = false;
            ResultV.Location = new Point(480, 113);
            ResultV.Name = "ResultV";
            ResultV.Size = new Size(100, 23);
            ResultV.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(492, 89);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 0;
            label4.Text = "Volumen";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 503);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Pseudo_ParcialForms1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn ColArea;
        private DataGridViewTextBoxColumn ColVolumen;
        private Button Cancelar;
        private Button OK;
        private TextBox radio;
        private TextBox altura;
        private TextBox generatriz;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox ResultA;
        private TextBox ResultV;
        private ErrorProvider errorProvider1;
    }
}