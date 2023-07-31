namespace StorageManagement
{
    partial class NewProductForm
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
            textBoxCodeProd = new TextBox();
            textBoxDescription = new TextBox();
            textBoxLocation = new TextBox();
            textBoxStorage = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonOk = new Button();
            buttonCancel = new Button();
            numericUpDownCalcStock = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCalcStock).BeginInit();
            SuspendLayout();
            // 
            // textBoxCodeProd
            // 
            textBoxCodeProd.Location = new Point(23, 50);
            textBoxCodeProd.Name = "textBoxCodeProd";
            textBoxCodeProd.Size = new Size(289, 23);
            textBoxCodeProd.TabIndex = 0;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(23, 109);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(289, 23);
            textBoxDescription.TabIndex = 1;
            // 
            // textBoxLocation
            // 
            textBoxLocation.Location = new Point(23, 176);
            textBoxLocation.Name = "textBoxLocation";
            textBoxLocation.Size = new Size(289, 23);
            textBoxLocation.TabIndex = 2;
            // 
            // textBoxStorage
            // 
            textBoxStorage.Location = new Point(23, 240);
            textBoxStorage.Name = "textBoxStorage";
            textBoxStorage.Size = new Size(289, 23);
            textBoxStorage.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 32);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(98, 15);
            label1.TabIndex = 5;
            label1.Text = "Codigo Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 91);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(69, 15);
            label2.TabIndex = 6;
            label2.Text = "Descripción";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 158);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(60, 15);
            label3.TabIndex = 7;
            label3.Text = "Ubicación";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 222);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(54, 15);
            label4.TabIndex = 8;
            label4.Text = "Almacen";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 281);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(92, 15);
            label5.TabIndex = 9;
            label5.Text = "Stock Calculado";
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(138, 342);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 10;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(232, 342);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // numericUpDownCalcStock
            // 
            numericUpDownCalcStock.Location = new Point(23, 299);
            numericUpDownCalcStock.Name = "numericUpDownCalcStock";
            numericUpDownCalcStock.Size = new Size(120, 23);
            numericUpDownCalcStock.TabIndex = 12;
            // 
            // NewProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 383);
            Controls.Add(numericUpDownCalcStock);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxStorage);
            Controls.Add(textBoxLocation);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxCodeProd);
            Name = "NewProductForm";
            Text = "New Product";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCalcStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCodeProd;
        private TextBox textBoxDescription;
        private TextBox textBoxLocation;
        private TextBox textBoxStorage;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonOk;
        private Button buttonCancel;
        private NumericUpDown numericUpDownCalcStock;
    }
}