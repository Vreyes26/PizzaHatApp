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
            this.boxTipoPizza = new System.Windows.Forms.ComboBox();
            this.boxTamaño = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
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
            // boxTipoPizza
            // 
            this.boxTipoPizza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boxTipoPizza.FormattingEnabled = true;
            this.boxTipoPizza.Items.AddRange(new object[] {
            "Italiana",
            "Hawaiiana",
            "Española"});
            this.boxTipoPizza.Location = new System.Drawing.Point(111, 121);
            this.boxTipoPizza.Name = "boxTipoPizza";
            this.boxTipoPizza.Size = new System.Drawing.Size(121, 21);
            this.boxTipoPizza.TabIndex = 2;
            this.boxTipoPizza.Text = "Tipo Pizza";
            // 
            // boxTamaño
            // 
            this.boxTamaño.FormattingEnabled = true;
            this.boxTamaño.Items.AddRange(new object[] {
            "Individual",
            "Mediana",
            "Familiar",
            "XL"});
            this.boxTamaño.Location = new System.Drawing.Point(327, 121);
            this.boxTamaño.Name = "boxTamaño";
            this.boxTamaño.Size = new System.Drawing.Size(121, 21);
            this.boxTamaño.TabIndex = 3;
            this.boxTamaño.Text = "Tamaño";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Bebida",
            "Papas",
            "Palitos de ajo"});
            this.checkedListBox1.Location = new System.Drawing.Point(534, 121);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.checkedListBox1.Size = new System.Drawing.Size(95, 49);
            this.checkedListBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(542, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Agregados";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.boxTamaño);
            this.Controls.Add(this.boxTipoPizza);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Caja";
            this.Text = "Caja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxTipoPizza;
        private System.Windows.Forms.ComboBox boxTamaño;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label2;
    }
}