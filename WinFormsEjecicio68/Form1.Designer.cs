namespace WinFormsEjecicio68
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
            errorProvider1 = new ErrorProvider(components);
            splitContainer1 = new SplitContainer();
            btnSalir = new Button();
            btnCancelar = new Button();
            btnOk = new Button();
            txtNumero = new TextBox();
            label1 = new Label();
            dgvfactor = new DataGridView();
            ColNumero = new DataGridViewTextBoxColumn();
            ColFactor = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvfactor).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnSalir);
            splitContainer1.Panel1.Controls.Add(btnCancelar);
            splitContainer1.Panel1.Controls.Add(btnOk);
            splitContainer1.Panel1.Controls.Add(txtNumero);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvfactor);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(658, 42);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 51);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(300, 173);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 51);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(150, 173);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 51);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(275, 104);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 107);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese un numero";
            // 
            // dgvfactor
            // 
            dgvfactor.AllowUserToAddRows = false;
            dgvfactor.AllowUserToDeleteRows = false;
            dgvfactor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvfactor.Columns.AddRange(new DataGridViewColumn[] { ColNumero, ColFactor });
            dgvfactor.Dock = DockStyle.Fill;
            dgvfactor.Location = new Point(0, 0);
            dgvfactor.Name = "dgvfactor";
            dgvfactor.ReadOnly = true;
            dgvfactor.RowTemplate.Height = 25;
            dgvfactor.Size = new Size(800, 180);
            dgvfactor.TabIndex = 0;
            // 
            // ColNumero
            // 
            ColNumero.HeaderText = "Numero ingresado";
            ColNumero.Name = "ColNumero";
            ColNumero.ReadOnly = true;
            // 
            // ColFactor
            // 
            ColFactor.HeaderText = "Numero Factorisado";
            ColFactor.Name = "ColFactor";
            ColFactor.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvfactor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ErrorProvider errorProvider1;
        private SplitContainer splitContainer1;
        private Button btnSalir;
        private Button btnCancelar;
        private Button btnOk;
        private TextBox txtNumero;
        private Label label1;
        private DataGridView dgvfactor;
        private DataGridViewTextBoxColumn ColNumero;
        private DataGridViewTextBoxColumn ColFactor;
    }
}