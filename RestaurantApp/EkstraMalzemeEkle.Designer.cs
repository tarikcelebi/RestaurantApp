namespace RestaurantApp
{
    partial class EkstraMalzemeEkle
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
            grpboxExtraProductAdd = new GroupBox();
            btnExtraProduct = new Button();
            label2 = new Label();
            label1 = new Label();
            nudExtraProductPrice = new NumericUpDown();
            txtExtraProductName = new TextBox();
            grpboxExtraProductAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudExtraProductPrice).BeginInit();
            SuspendLayout();
            // 
            // grpboxExtraProductAdd
            // 
            grpboxExtraProductAdd.Controls.Add(btnExtraProduct);
            grpboxExtraProductAdd.Controls.Add(label2);
            grpboxExtraProductAdd.Controls.Add(label1);
            grpboxExtraProductAdd.Controls.Add(nudExtraProductPrice);
            grpboxExtraProductAdd.Controls.Add(txtExtraProductName);
            grpboxExtraProductAdd.Location = new Point(172, 74);
            grpboxExtraProductAdd.Name = "grpboxExtraProductAdd";
            grpboxExtraProductAdd.Size = new Size(425, 269);
            grpboxExtraProductAdd.TabIndex = 1;
            grpboxExtraProductAdd.TabStop = false;
            grpboxExtraProductAdd.Text = "Ekstra Malzeme Ekle";
            // 
            // btnExtraProduct
            // 
            btnExtraProduct.Location = new Point(79, 222);
            btnExtraProduct.Name = "btnExtraProduct";
            btnExtraProduct.Size = new Size(271, 23);
            btnExtraProduct.TabIndex = 4;
            btnExtraProduct.Text = "Ekle";
            btnExtraProduct.UseVisualStyleBackColor = true;
            btnExtraProduct.Click += btnExtraProduct_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 167);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 3;
            label2.Text = "Fiyat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 87);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 2;
            label1.Text = "Adı";
            // 
            // nudExtraProductPrice
            // 
            nudExtraProductPrice.Location = new Point(79, 159);
            nudExtraProductPrice.Name = "nudExtraProductPrice";
            nudExtraProductPrice.Size = new Size(271, 23);
            nudExtraProductPrice.TabIndex = 1;
            // 
            // txtExtraProductName
            // 
            txtExtraProductName.Location = new Point(79, 84);
            txtExtraProductName.Name = "txtExtraProductName";
            txtExtraProductName.Size = new Size(271, 23);
            txtExtraProductName.TabIndex = 0;
            // 
            // EkstraMalzemeEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpboxExtraProductAdd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EkstraMalzemeEkle";
            Text = "EkstraMalzemeEkle";
            grpboxExtraProductAdd.ResumeLayout(false);
            grpboxExtraProductAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudExtraProductPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpboxExtraProductAdd;
        private Button btnExtraProduct;
        private Label label2;
        private Label label1;
        private NumericUpDown nudExtraProductPrice;
        private TextBox txtExtraProductName;
    }
}