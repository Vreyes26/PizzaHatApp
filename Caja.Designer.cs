using System.Windows.Forms;

namespace PizzaHatApp
{
    partial class Caja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caja));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEspañola = new System.Windows.Forms.RadioButton();
            this.buttonHawaiiana = new System.Windows.Forms.RadioButton();
            this.buttonItaliana = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonXL = new System.Windows.Forms.RadioButton();
            this.buttonFamiliar = new System.Windows.Forms.RadioButton();
            this.buttonMediana = new System.Windows.Forms.RadioButton();
            this.buttonIndividual = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonPA = new System.Windows.Forms.RadioButton();
            this.buttonPapas = new System.Windows.Forms.RadioButton();
            this.buttonBebida = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTotalPedido = new System.Windows.Forms.Label();
            this.buttonCalcular2 = new System.Windows.Forms.Button();
            this.ListaPedidos = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "PEDIDOS PIZZA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEspañola);
            this.groupBox1.Controls.Add(this.buttonHawaiiana);
            this.groupBox1.Controls.Add(this.buttonItaliana);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(127, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 132);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de pizza";
            // 
            // buttonEspañola
            // 
            this.buttonEspañola.AutoSize = true;
            this.buttonEspañola.Location = new System.Drawing.Point(7, 76);
            this.buttonEspañola.Name = "buttonEspañola";
            this.buttonEspañola.Size = new System.Drawing.Size(84, 20);
            this.buttonEspañola.TabIndex = 2;
            this.buttonEspañola.TabStop = true;
            this.buttonEspañola.Text = "Española";
            this.buttonEspañola.UseVisualStyleBackColor = true;
            // 
            // buttonHawaiiana
            // 
            this.buttonHawaiiana.AutoSize = true;
            this.buttonHawaiiana.Location = new System.Drawing.Point(7, 49);
            this.buttonHawaiiana.Name = "buttonHawaiiana";
            this.buttonHawaiiana.Size = new System.Drawing.Size(90, 20);
            this.buttonHawaiiana.TabIndex = 1;
            this.buttonHawaiiana.TabStop = true;
            this.buttonHawaiiana.Text = "Hawaiiana";
            this.buttonHawaiiana.UseVisualStyleBackColor = true;
            // 
            // buttonItaliana
            // 
            this.buttonItaliana.AutoSize = true;
            this.buttonItaliana.Location = new System.Drawing.Point(7, 22);
            this.buttonItaliana.Name = "buttonItaliana";
            this.buttonItaliana.Size = new System.Drawing.Size(69, 20);
            this.buttonItaliana.TabIndex = 0;
            this.buttonItaliana.TabStop = true;
            this.buttonItaliana.Text = "Italiana";
            this.buttonItaliana.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonXL);
            this.groupBox2.Controls.Add(this.buttonFamiliar);
            this.groupBox2.Controls.Add(this.buttonMediana);
            this.groupBox2.Controls.Add(this.buttonIndividual);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(326, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 132);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tamaño pizza";
            // 
            // buttonXL
            // 
            this.buttonXL.AutoSize = true;
            this.buttonXL.Location = new System.Drawing.Point(7, 92);
            this.buttonXL.Name = "buttonXL";
            this.buttonXL.Size = new System.Drawing.Size(41, 20);
            this.buttonXL.TabIndex = 3;
            this.buttonXL.TabStop = true;
            this.buttonXL.Text = "XL";
            this.buttonXL.UseVisualStyleBackColor = true;
            // 
            // buttonFamiliar
            // 
            this.buttonFamiliar.AutoSize = true;
            this.buttonFamiliar.Location = new System.Drawing.Point(7, 68);
            this.buttonFamiliar.Name = "buttonFamiliar";
            this.buttonFamiliar.Size = new System.Drawing.Size(74, 20);
            this.buttonFamiliar.TabIndex = 2;
            this.buttonFamiliar.TabStop = true;
            this.buttonFamiliar.Text = "Familiar";
            this.buttonFamiliar.UseVisualStyleBackColor = true;
            // 
            // buttonMediana
            // 
            this.buttonMediana.AutoSize = true;
            this.buttonMediana.Location = new System.Drawing.Point(7, 44);
            this.buttonMediana.Name = "buttonMediana";
            this.buttonMediana.Size = new System.Drawing.Size(79, 20);
            this.buttonMediana.TabIndex = 1;
            this.buttonMediana.TabStop = true;
            this.buttonMediana.Text = "Mediana";
            this.buttonMediana.UseVisualStyleBackColor = true;
            // 
            // buttonIndividual
            // 
            this.buttonIndividual.AutoSize = true;
            this.buttonIndividual.Location = new System.Drawing.Point(7, 20);
            this.buttonIndividual.Name = "buttonIndividual";
            this.buttonIndividual.Size = new System.Drawing.Size(83, 20);
            this.buttonIndividual.TabIndex = 0;
            this.buttonIndividual.TabStop = true;
            this.buttonIndividual.Text = "Individual";
            this.buttonIndividual.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonPA);
            this.groupBox3.Controls.Add(this.buttonPapas);
            this.groupBox3.Controls.Add(this.buttonBebida);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(527, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(124, 132);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Agregado";
            // 
            // buttonPA
            // 
            this.buttonPA.AutoSize = true;
            this.buttonPA.Location = new System.Drawing.Point(7, 68);
            this.buttonPA.Name = "buttonPA";
            this.buttonPA.Size = new System.Drawing.Size(108, 20);
            this.buttonPA.TabIndex = 2;
            this.buttonPA.TabStop = true;
            this.buttonPA.Text = "Palitos de ajo";
            this.buttonPA.UseVisualStyleBackColor = true;
            // 
            // buttonPapas
            // 
            this.buttonPapas.AutoSize = true;
            this.buttonPapas.Location = new System.Drawing.Point(7, 44);
            this.buttonPapas.Name = "buttonPapas";
            this.buttonPapas.Size = new System.Drawing.Size(66, 20);
            this.buttonPapas.TabIndex = 1;
            this.buttonPapas.TabStop = true;
            this.buttonPapas.Text = "Papas";
            this.buttonPapas.UseVisualStyleBackColor = true;
            // 
            // buttonBebida
            // 
            this.buttonBebida.AutoSize = true;
            this.buttonBebida.Location = new System.Drawing.Point(7, 20);
            this.buttonBebida.Name = "buttonBebida";
            this.buttonBebida.Size = new System.Drawing.Size(70, 20);
            this.buttonBebida.TabIndex = 0;
            this.buttonBebida.TabStop = true;
            this.buttonBebida.Text = "Bebida";
            this.buttonBebida.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(527, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(127, 376);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 32);
            this.buttonEliminar.TabIndex = 11;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(365, 379);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(42, 16);
            this.labelTotal.TabIndex = 12;
            this.labelTotal.Text = "Total:";
            // 
            // labelTotalPedido
            // 
            this.labelTotalPedido.AutoSize = true;
            this.labelTotalPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPedido.Location = new System.Drawing.Point(413, 379);
            this.labelTotalPedido.Name = "labelTotalPedido";
            this.labelTotalPedido.Size = new System.Drawing.Size(15, 16);
            this.labelTotalPedido.TabIndex = 13;
            this.labelTotalPedido.Text = "0";
            // 
            // buttonCalcular2
            // 
            this.buttonCalcular2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcular2.Location = new System.Drawing.Point(282, 376);
            this.buttonCalcular2.Name = "buttonCalcular2";
            this.buttonCalcular2.Size = new System.Drawing.Size(77, 32);
            this.buttonCalcular2.TabIndex = 14;
            this.buttonCalcular2.Text = "Calcular";
            this.buttonCalcular2.UseVisualStyleBackColor = true;
            this.buttonCalcular2.Click += new System.EventHandler(this.buttonCalcular2_Click);
            // 
            // ListaPedidos
            // 
            this.ListaPedidos.FormattingEnabled = true;
            this.ListaPedidos.Location = new System.Drawing.Point(127, 245);
            this.ListaPedidos.Name = "ListaPedidos";
            this.ListaPedidos.Size = new System.Drawing.Size(333, 121);
            this.ListaPedidos.TabIndex = 15;
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListaPedidos);
            this.Controls.Add(this.buttonCalcular2);
            this.Controls.Add(this.labelTotalPedido);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Caja";
            this.Text = "Caja";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton buttonEspañola;
        private System.Windows.Forms.RadioButton buttonHawaiiana;
        private System.Windows.Forms.RadioButton buttonItaliana;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton buttonXL;
        private System.Windows.Forms.RadioButton buttonFamiliar;
        private System.Windows.Forms.RadioButton buttonMediana;
        private System.Windows.Forms.RadioButton buttonIndividual;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton buttonPA;
        private System.Windows.Forms.RadioButton buttonPapas;
        private System.Windows.Forms.RadioButton buttonBebida;
        private System.Windows.Forms.Button button1;
        private Button buttonEliminar;
        private Label labelTotal;
        private Label labelTotalPedido;
        private Button buttonCalcular2;
        private ListBox ListaPedidos;
    }
}