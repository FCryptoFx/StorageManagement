namespace StorageManagement
{
    partial class MainForm
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
            dataGridViewProduct = new DataGridView();
            buttonNewProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Location = new Point(43, 27);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.RowTemplate.Height = 25;
            dataGridViewProduct.Size = new Size(711, 353);
            dataGridViewProduct.TabIndex = 0;
            // 
            // buttonNewProduct
            // 
            buttonNewProduct.Location = new Point(665, 386);
            buttonNewProduct.Name = "buttonNewProduct";
            buttonNewProduct.Size = new Size(89, 23);
            buttonNewProduct.TabIndex = 1;
            buttonNewProduct.Text = "Añadir";
            buttonNewProduct.UseVisualStyleBackColor = true;
            buttonNewProduct.Click += buttonNewProduct_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonNewProduct);
            Controls.Add(dataGridViewProduct);
            Name = "MainForm";
            Text = "Storage Management";
            Activated += MainForm_Activated;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridViewProduct;
        private Button buttonNewProduct;
    }
}